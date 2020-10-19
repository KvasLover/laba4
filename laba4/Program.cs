﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace laba4
{
    public class Set
    {
        List<int> multiplisity = new List<int>();
        public static Set operator ++(Set Var) //перегрузка ++
        {
            Random rand = new Random();
            Var.Add(rand.Next());
            return Var;
        }
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
        public int Count() //подсчёт эл-в мн-ва
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
        public static Set operator <=(Set Var, Set Var2) //перегрузка <=
        {
            if (Var.Count() < Var2.Count())
                Console.WriteLine("Первое мн-во меньше второго");
            else if(Var.Count() > Var2.Count())
                Console.WriteLine("Первое мн-во больше второго");
            else
                Console.WriteLine("Первое мн-во такого же размера, как второе");
            Console.WriteLine();
            return Var;
        }
        public static Set operator >=(Set Var, Set Var2) //требование для перегрузки <=
        {
            return Var;
        }
        public static Set operator %(Set Var, Set Var2) //перегрузка %
        {
            Console.Write("К какой позиции получить доступ? ");
            int position = Convert.ToInt32(Console.ReadLine());
            Var.Remove(Var,position-1);
            return Var;
        }
        public void Remove(Set Var,int position)
        {
            Var.multiplisity.RemoveAt(position);
        }
        public class Owner //2)
        {
            int id;
            string name, organization;
            public void Init() //инициализация
            {
                Console.Write("Введите Id: ");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите имя создателя: ");
                name = Console.ReadLine();
                Console.Write("Введите организацию создателя: ");
                organization = Console.ReadLine();
                Console.WriteLine();
            }
            public void Info() //вывод содержимого
            {
                Console.WriteLine($"Id: {id}, имя создателя: {name}, организация создателя: {organization}");
            }
        }
        public class Date //3)
        {
            int day, month, year;
            public void Init() //инициализация
            {
                Console.Write("Введите день создания: ");
                day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц создания: ");
                month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите год создания: ");
                year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            public void Info() //вывод содержимого
            {
                Console.WriteLine($"Дата создания проекта: {day}.{month}.{year}");
            }
        }
        public static class StatisticOperation //4)
        {
            public static int Sum(Set Var) //сумма эл-в
            {
                int sum = 0;
                for (int i = 0; i < Var.Count(); i++)
                {
                    sum += Var.multiplisity[i];
                }
                return sum;
            }
            public static int Max_min_difference(Set Var) //разница между максимальным и минимальным
            {
                int max = Var.multiplisity[0], min = max;
                for (int i = 0; i < Var.Count(); i++)
                {
                    if (Var.multiplisity[i] > max)
                        max = Var.multiplisity[i];
                    if (Var.multiplisity[i] < min)
                        min = Var.multiplisity[i];
                }
                return max - min;
            }
            public static int Amount(Set Var) //кол-во эл-в
            {
                int counter = 0;
                for (int i = 0; i < Var.Count(); i++)
                {
                    counter++;
                }
                return counter;
            }
        }
    }
    /*public static class Wider
    {        
        public static string Wide_String(this string str)
        {
            string str2;
            for(int i = 0; i < str.Length; i++)
            {
                str2[i] = str[i] + 1;
            }
            return str2;
        }
    }*/
    
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
            Console.WriteLine("Первое множество без и с новым эл-м");
            obj.Info(size1);

            obj++; //добавление нового эл-та (случайное число) в мн-во
            obj.Info(size1+1);
            Console.WriteLine();

            Set obj2 = new Set();
            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Введите элемент {i + 1} второго мн-ва: ");
                obj2.Add(Convert.ToInt32(Console.ReadLine()));
            }
            (obj + obj2).Info(size1+3);

            obj = obj % obj2;

            Console.WriteLine();
            Console.WriteLine("Первое мн-во без заданного эл-та: ");
            obj.Info(size1+2);
            Console.WriteLine("Второе мн-во: ");
            obj2.Info(2);
            Console.WriteLine();

            obj = obj <= obj2;

            Set.Date date = new Set.Date();
            date.Init();
            date.Info();

            Set.Owner owner = new Set.Owner();
            owner.Init();
            owner.Info();

            Console.WriteLine($"Сумма эл-в первого мн-ва: {Set.StatisticOperation.Sum(obj)}");
        }     
    }
}
