using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.IO;

namespace laba4
{
    // Класс использует конструктор без параметров (ограничение).
    public class CollectionType<T> : IAdd_Delete_Look<T>/* where T : new()*/
    {   
        // Объявление обобщённой коллекции.
        public List<T> multiplisity = new List<T>();

        // Метод добавления нового эл-та в мн-во.
        public void Add(T num) 
        {
            multiplisity.Add(num);
        }

        // Метод вывода мн-ва.
        public void Info(int size1) 
        {
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"{multiplisity[i]} ");
            }
            Console.WriteLine();
        }

        // Метод удаления элемента коллекции с заданной позицией.
        public void Remove(CollectionType<T> Var,int position)
        {
            Var.multiplisity.RemoveAt(position);
        }        
        public void Write_to_file(int size1)
        {
            string Path = @"D:\labs\OOP\laba4-8\file.txt";
            using (StreamWriter file = new StreamWriter(Path, false))
            {
                for (int i = 0; i < size1; i++)
                {
                    file.WriteLine(multiplisity[i]);
                    //file.Write(multiplisity[i]+" ");
                }
            }
        }
        public static void Read_from_file(int size1)
        {
            string Path = @"D:\labs\OOP\laba4-8\file.txt";
            Console.Write("Содержимое файла: ");
            using (StreamReader file = new StreamReader(Path))
            {
                Console.WriteLine(file.ReadToEnd());
            }
        }
    }
    
    class Program
    {
         static void Main(string[] args)
         {
            try
            {
                CollectionType<int> obj = new CollectionType<int>();            
                Console.Write("Введите кол-во эл-в коллекции: ");
                int size1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                for(int i=0;i<size1;i++)
                {
                    Console.Write($"Введите элемент {i+1}: ");
                    obj.Add(Convert.ToInt32(Console.ReadLine()));
                }
                Console.WriteLine();
                Console.WriteLine("Множество: ");
                obj.Info(size1);                
                Console.WriteLine();

                // 3).
                Quest a = new Quest();
                Console.Write("Введите Var: ");
                a.Var = Console.ReadLine();
                Class_for_3<Quest> obj2 = new Class_for_3<Quest>()
                {
                    Get_Set = a,
                };
                obj2.show();

                // 4).
                obj.Write_to_file(size1);
                CollectionType<char>.Read_from_file(size1);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец блока обработки исключений catch и программы.");
            }
        }        
    }
}
