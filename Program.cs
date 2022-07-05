using System;

namespace ConsoleApp3Ejercicio1deCastagnerisSebastian
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidad, tiempo, metro, distancia, metros;

            Console.WriteLine("Ingrese la velocidad del Automovil");
            velocidad = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tiempo de viaje:");
            tiempo = double.Parse(Console.ReadLine());

            distancia = velocidad * tiempo;
            metros = distancia * 0.001;


            Console.WriteLine($"El Automovil recorrió {distancia} metros.");
            Console.WriteLine($"Expresado en kilometros, el Automovil recorrió {metros} kms.");

            Console.ReadLine();
        }
        
    }
}
