﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            Console.Write("A + B = {0}", a+b);

            int d = a - b;
            Console.Write("A - B = {0}",a-b);

            int e = a * b;
            Console.Write("A * B = {0}", a*b);

            int f = a / b;
            Console.Write("A / B = {0}", a /b);


            Console.ReadKey();
        }
    }
}
