﻿using membrosEstaticos;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
       
        static void Main(string[] args)
        {
            

            //permite utilizar os métodos de uma classe sem ter que estanciar o objeto

            Console.WriteLine("Entre com o valor: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circ = Calculadora.Circuferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circuferencia: " + Circ);
            Console.WriteLine("Circuferencia: " + Circ);
            Console.WriteLine("Valor de PI: " + Calculadora.Pi);
        }

        
    }
}