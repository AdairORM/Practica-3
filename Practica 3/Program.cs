using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Lista
            List<Estudiante> listaEstudiantes = new List<Estudiante>();
            listaEstudiantes.Add(new Estudiante(1, "Juan", 20));
            listaEstudiantes.Add(new Estudiante(2, "Maria", 22));
            listaEstudiantes.Add(new Estudiante(3, "Carlos", 21));
            #endregion

            #region Cola
            Queue<Estudiante> colaEstudiantes = new Queue<Estudiante>();

            
            #endregion

            #region Métodos
            #region lista, eliminar y buscar
            listaEstudiantes.Remove(listaEstudiantes[1]);
            Estudiante estudianteEncontrado = listaEstudiantes.Find(e => e.Nombre == "Carlos Ruiz");
            Console.WriteLine("Estudiante encontrado en la lista: " + estudianteEncontrado);
            #endregion

            #region Cola, encolar, desencolar
            foreach (var estudiante in listaEstudiantes)
            {
                colaEstudiantes.Enqueue(estudiante);
            }
            Estudiante primerEstudiante = colaEstudiantes.Dequeue();
            Console.WriteLine("Primer estudiante desencolado: " + primerEstudiante);

            #endregion
            Estudiante estudianteFrente = colaEstudiantes.Peek();
            Console.WriteLine("Estudiante al frente de la cola: " + estudianteFrente);

            Console.WriteLine("Contenido final de la cola:");
            foreach (var estudiante in colaEstudiantes)
            {
                Console.WriteLine(estudiante);
            }
            Console.ReadLine();
            #endregion

        }
    }
}
