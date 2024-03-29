﻿using System;
using System.Collections.Generic;

namespace cajero_automatico
{
    class Program
    {
        static void Billetes(string cantidad)
        {
            Stack<int> BilletesDeCien = new Stack<int>();
            Stack<int> BilletesDeDoscientos = new Stack<int>();
            Stack<int> BilletesDeQuinientos = new Stack<int>();
            Stack<int> BilletesDeMil = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                BilletesDeCien.Push(100);
                BilletesDeDoscientos.Push(200);
                BilletesDeQuinientos.Push(500);
                BilletesDeMil.Push(1000);
            }
            Console.WriteLine("Hello World desde billetes!"); 
            Console.WriteLine("Esta es la cantidad {0}", cantidad);
            int cantidadInt;
            cantidadInt = Convert.ToInt32(cantidad);
            if (cantidadInt == 100)
            {
                BilletesDeCien.Pop();
            } if (cantidadInt == 200)
            {
                BilletesDeDoscientos.Pop();
            } if (cantidadInt == 500)
            {
                BilletesDeQuinientos.Pop();
            } if (cantidadInt == 1000)
            {
                BilletesDeMil.Pop();
            } 
            int[] BilletesDeCienArr = BilletesDeCien.ToArray();
            int[] BilletesDeDoscientosArr = BilletesDeDoscientos.ToArray();
            int[] BilletesDeQuinientosArr = BilletesDeQuinientos.ToArray();
            int[] BilletesDeMilArr = BilletesDeMil.ToArray();

            Console.WriteLine("Quedan {0} billetes de 100",BilletesDeCienArr.Length);
            Console.WriteLine("Quedan {0} billetes de 200",BilletesDeDoscientosArr.Length);
            Console.WriteLine("Quedan {0} billetes de 500",BilletesDeQuinientosArr.Length);
            Console.WriteLine("Quedan {0} billetes de 1000",BilletesDeMilArr.Length);
            while (BilletesDeCienArr.Length > 0)
            {
                Main();
            }
        }
            // Lo que estoy pensando aqui es hacer el void para la asignacion de los billetes hacia la cantidad haciendo operaciones 
            // sobre la cantidad y que me vaya eliminando elementos de mi array a traves de un pop

            // Como pensaba hacerlo era a traves de condicionantes if else if else pero siento que se hara muy extenso el codigo
        static void Main()
        {
            string cantidad = "";
            Console.WriteLine("Ingresa la cantidad que deseas: ");
            cantidad = Console.ReadLine();
            Billetes(cantidad);

        }
    }
}
