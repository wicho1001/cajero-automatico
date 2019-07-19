using System;

namespace cajero_automatico
{
    class Program
    {
        static 
        void Billetes(string cantidad)
        {
            int[] BilletesDeCien = {100, 100, 100, 100, 100, 100};
            int[] BilletesDeDoscientos = {200, 200, 200, 200, 200, 200};
            int[] BilletesDeQuinientos = {500, 500, 500, 500, 500, 500};
            int[] BilletesDeMil = {1000, 1000, 1000, 1000, 1000, 1000};
            Console.WriteLine("Hello World desde billetes!"); 
            Console.WriteLine("Esta es la cantidad {0}", cantidad);
            Console.WriteLine(BilletesDeCien[0]);
        }
            // Lo que estoy pensando aqui es hacer el void para la asignacion de los billetes hacia la cantidad haciendo operaciones 
            // sobre la cantidad y que me vaya eliminando elementos de mi array a traves de un pop

            // Como pensaba hacerlo era a traves de condicionantes if else if else pero siento que se hara muy extenso el codigo
        static void Main(string[] args)
        {
            string cantidad = "";
            Console.WriteLine("Ingresa la cantidad que deseas: ");
            cantidad = Console.ReadLine();
            Billetes(cantidad);

        }
    }
}
