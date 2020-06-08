using System;
using System.Collections.Generic;
using System.Collections;

namespace Султанова_19_11_2_ИСиП_Основы_алгоритмизации_08._06._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList List = new ArrayList() { 1, 2, -3, -4, -5, -6, -7, 8, 9, 10 };
            List.RemoveAt(0); // удаление первого элемента
            List.RemoveAt(9); // удаление последнего элемента
            foreach (object o in List)
            {
                Console.WriteLine(o);
            }
            List.AddRange(new int[] { 0, 0, 0, 0,0 });
            foreach (object o in List)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Общее число элементов коллекции: {0}", List.Count);

        }
    }
}
