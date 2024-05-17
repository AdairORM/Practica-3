using System;

namespace Practica_3
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public Estudiante( string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $" Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
