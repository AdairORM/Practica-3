using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Estudiante
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }


        public Estudiante(int id, string nombre, int edad)
        {
            ID = id;
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Nombre}, Edad: {Edad}";
        }
    }
}
