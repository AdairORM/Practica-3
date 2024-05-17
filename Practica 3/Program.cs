using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Program
    {

        /*#region Actividad1
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
            #endregion
        }*/


        /*#region Actividad 2
        static void Main(string[] args)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>
            {
            new Estudiante(1, "Juan Perez", 20),
            new Estudiante(2, "Maria Gomez", 22),
            new Estudiante(3, "Carlos Ruiz", 21)
            };

            Console.WriteLine("Lista original:");
            MostrarLista(listaEstudiantes);

            Console.WriteLine("Lista original:");
            MostrarLista(listaEstudiantes);

            // Ordenar por Nombre
            BubbleSort(listaEstudiantes, CompararPorNombre);
            Console.WriteLine("\nLista ordenada por Nombre:");
            MostrarLista(listaEstudiantes);

            // Ordenar por Edad
            BubbleSort(listaEstudiantes, CompararPorEdad);
            Console.WriteLine("\nLista ordenada por Edad:");
            MostrarLista(listaEstudiantes);

            Console.ReadLine();
        }

        static void BubbleSort(List<Estudiante> lista, Comparison<Estudiante> comparar)
        {
            int n = lista.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (comparar(lista[j], lista[j + 1]) > 0)
                    {
                        // Intercambiar lista[j] y lista[j + 1]
                        Intercambiar(lista, j, j + 1);
                    }
                }
            }
        }

        static void Intercambiar(List<Estudiante> lista, int i, int j)
        {
            Estudiante temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }

        static int CompararPorNombre(Estudiante e1, Estudiante e2)
        {
            return e1.Nombre.CompareTo(e2.Nombre);
        }

        static int CompararPorEdad(Estudiante e1, Estudiante e2)
        {
            return e1.Edad.CompareTo(e2.Edad);
        }

        static void MostrarLista(List<Estudiante> lista)
        {
            foreach (var estudiante in lista)
            {
                Console.WriteLine(estudiante);
            }
        }
        #endregion*/


        /*#region Actividad 3
        static void Main(string[] args)
        {
            List<Estudiante> listaEstudiantes = new List<Estudiante>
        {
            new Estudiante(1, "Juan Perez", 20),
            new Estudiante(2, "Maria Gomez", 22),
            new Estudiante(3, "Carlos Ruiz", 21)
        };

            string nombreBuscado = "Carlos Ruiz";

            // Búsqueda lineal simple
            int iteracionesLinealSimple = 0;
            Estudiante resultadoLinealSimple = BusquedaLinealSimple(listaEstudiantes, nombreBuscado, ref iteracionesLinealSimple);
            Console.WriteLine("Resultado de búsqueda lineal simple: ", resultadoLinealSimple);
            Console.WriteLine("Iteraciones de búsqueda lineal simple: " + iteracionesLinealSimple);

            // Búsqueda lineal optimizada
            int iteracionesLinealOptimizada = 0;
            Estudiante resultadoLinealOptimizada = BusquedaLinealOptimizada(listaEstudiantes, nombreBuscado, ref iteracionesLinealOptimizada);
            Console.WriteLine("Resultado de búsqueda lineal optimizada: " + resultadoLinealOptimizada);
            Console.WriteLine("Iteraciones de búsqueda lineal optimizada: " + iteracionesLinealOptimizada);
            Console.ReadLine();

        }

        static Estudiante BusquedaLinealSimple(List<Estudiante> lista, string nombre, ref int iteraciones)
        {
            foreach (var estudiante in lista)
            {
                iteraciones++;
                if (estudiante.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    // Continúa buscando incluso después de encontrar el elemento
                }
            }
            return null;
        }

        static Estudiante BusquedaLinealOptimizada(List<Estudiante> lista, string nombre, ref int iteraciones)
        {
            foreach (var estudiante in lista)
            {
                iteraciones++;
                if (estudiante.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    // Devuelve el elemento inmediatamente después de encontrarlo
                    return estudiante;
                }
            }
            return null;
        }

        #endregion*/

    }











}

