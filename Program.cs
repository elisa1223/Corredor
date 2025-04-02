using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
// diego es gai 

namespace Consolacorredores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Carrera de hilos!");

            // Crear tres corredores
            Thread corredorA = new Thread(Correr);
            Thread corredorB = new Thread(Correr);
            Thread corredorC = new Thread(Correr);

            corredorA.Start("Corredor A");
            corredorB.Start("Corredor B");
            corredorC.Start("Corredor C");

            corredorA.Join();
            corredorB.Join();
            corredorC.Join();

            Console.WriteLine("¡Carrera terminada!");
        }

        static void Correr(object nombre)
        {
            Random rnd = new Random();
            for (int pasos = 1; pasos <= 10; pasos++)
            {
                Console.WriteLine($"{nombre} avanzó a la posición: {pasos}");
                Thread.Sleep(rnd.Next(100, 500)); // Velocidad aleatoria
            }
            Console.WriteLine($"🏁 {nombre} terminó la carrera!");
        }
    }
}

