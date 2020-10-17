using System;
using System.Collections.Generic;

namespace laba4
{
    public class Set
    {
        List<int> multiplisity = new List<int>();
        public static Set operator ++(Set Var)
        {
            Random rand = new Random();
            Var.Add(rand.Next());
            return Var;
        }
        public void Add(int num) //метод добавления нового эл-та в мн-во
        {
            multiplisity.Add(num);
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
            Set set = new Set();
            Console.Write("Введите начальное кол-во эл-в мн-ва: ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for(int i=0;i<size1;i++)
            {
                Console.Write($"Введите элемент {i+1}: ");
                set.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine();
            Console.WriteLine("Множество: ");
            set.Info(size1);

            set++; //добавление нового эл-та (случайное число) в мн-во
            set.Info(size1+1);
        }     
    }
}
