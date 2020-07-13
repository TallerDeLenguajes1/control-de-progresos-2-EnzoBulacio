using System;
using System.Collections.Generic;
using System.Text;

namespace Peronajes
{
    class Personaje
    {
        //caracteristicas
        private int velocidad;
        private int fuerza;
        private int nivel;
        private int armadura;
        public int Velocidad { get => velocidad; set => velocidad = value; }
        public int Fuerza { get => fuerza; set => fuerza = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int Armadura { get => armadura; set => armadura = value; }
        //personalidad
        private string tipo;
        private string nombre;
        private string fecha;
        private int edad;
        private int salud;
        private int p;
        
        public string Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Salud { get => salud; set => salud = value; }
        public int P { get => p; set => p = value; }

        public Personaje(string p)
        {
            this.p = p;
            nombre = p;
            velocidad = new Random().Next(1, 100);
            fuerza = new Random().Next(1, 1000);
            nivel = new Random().Next(1,100);
            armadura = new Random().Next(1, 500);
        }
    }
}
