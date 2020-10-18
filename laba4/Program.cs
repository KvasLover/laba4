using System;
using System.Collections.Generic;
using System.Linq;

namespace laba4
{
    public class Set
    {
        List<int> multiplisity = new List<int>();
        //List<int> multiplisity2 = new List<int>();
        public static Set operator ++(Set Var)
        {
            Random rand = new Random();
            Var.Add(rand.Next());
            return Var;
        } //перегрузка ++
        public void Add(int num) //метод добавления нового эл-та в мн-во
        {
            multiplisity.Add(num);
        }
        public static Set operator +(Set Var, Set Var2) //перегрузка +
        {
            int a = Var2.Count();
            for (int i = 0; i < a; i++)
            {
                Var.Add(Var2.multiplisity[i]);
            }
            return Var;
        }
        public int Count()
        {
            return multiplisity.Count();
        }
        public void Info(int size1) //метод вывода мн-ва
        {
            for (int i = 0; i < size1; i++)
            {
                Console.Write($"{multiplisity[i]} ");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
         static void Main(string[] args)
         {
            Set obj = new Set();
            Console.Write("Введите начальное кол-во эл-в мн-ва: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i=0;i<size1;i++)
            {
                Console.Write($"Введите элемент {i+1}: ");
                obj.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Множества: ");
            obj.Info(size1);

            obj++; //добавление нового эл-та (случайное число) в мн-во
            obj.Info(size1+1);

            Set obj2 = new Set();
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Введите элемент {i + 1}: ");
                obj2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            (obj + obj2).Info(size1+3);

            
            
        }     
    }
}
