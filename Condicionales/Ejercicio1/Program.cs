﻿using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.WriteLine("Ingrese numero");
            n1 = int.Parse(Console.ReadLine());

            if(n1 > 10)
                Console.WriteLine("Es mayor a 10");

            else
            Console.WriteLine("No es mayor a 10");
        }
    }
}