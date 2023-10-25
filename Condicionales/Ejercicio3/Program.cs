using System;
using System.Security.Cryptography;
using System.Timers;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe;
            Console.WriteLine("Ingrese venta:");
            importe = float.Parse(Console.ReadLine());

            if(importe >= 1000)
                if(importe >= 5000)
                    importe = importe * 0.82f;
                else
                    importe = importe * 0.90f;

            Console.WriteLine("Importe a cobrar es de: " + importe);
            
        }

    }

}