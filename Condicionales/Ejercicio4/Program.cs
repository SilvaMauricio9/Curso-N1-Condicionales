﻿using System;
using System.Runtime.CompilerServices;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, menor;

            Console.WriteLine("Ingrese un numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero:");
            n4 = int.Parse(Console.ReadLine());

            if(n1 < n2)
                menor = n1;
            else
                menor = n2;
            if(n3 < menor)
                menor = n3;
            if(n4 < menor)
                menor = n4;
            Console.WriteLine("El menor es: " + menor);

            //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.
        }
    }
}
