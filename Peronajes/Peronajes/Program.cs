using System;

namespace Peronajes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Altair", "Ezio", "Kassandra", "Jacob"};
            int cant;
            Console.WriteLine("ingrese la cantidad de personajes");
            cant = int.Parse(Console.ReadLine());
            Personaje player;
            for(int i=0;i == cant; i++)
            {
                player = new Personaje(nombres[new Random().Next(0, 4)]

            }
        }
    }
}
