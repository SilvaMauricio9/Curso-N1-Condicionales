﻿using System;
using System.Runtime.InteropServices;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo");
            n4 = int.Parse(Console.ReadLine());
            if(n1 > 100){
                Console.WriteLine(n1 + ":Es mayor a 100");
            }
            if(n2 > 100){
                Console.WriteLine(n2 + ":Es mayor a 100");
            }
            if(n3 > 100){
                Console.WriteLine(n3 + ":Es mayor a 100");
            }
            if(n4 > 100){
                Console.WriteLine(n4 + ":Es mayor a 100");
            }
            Console.WriteLine("Fin del programa");
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.
        }
    }

}
