using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace laba4
{
    // Класс использует конструктор без параметров (ограничение).
    public class CollectionType<T> : IAdd_Delete_Look<T> where T : new()
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
    }
    
    class Program
    {
         static void Main(string[] args)
         {
            try
            {
                CollectionType<int> obj = new CollectionType<int>();            
                Console.Write("Введите кол-во эл-в мн-ва: ");
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
