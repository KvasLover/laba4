using System;
using System.Collections.Generic;
using System.Text;

namespace laba4
{
    class Class_for_3<T> where T : Quest
    {
        public T x;
        public T Get_Set
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public void show()
        {
            Console.WriteLine($"Содержимое объекта: {x.Var}");
        }
    }
}
