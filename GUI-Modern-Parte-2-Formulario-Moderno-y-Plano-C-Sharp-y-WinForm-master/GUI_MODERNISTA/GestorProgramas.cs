using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    internal class GestorProgramas
    {
        public static Queue<Programas> ColaProgramas { get; } = new Queue<Programas>();
        public static List<Programas> Memoria { get; set; } = new List<Programas>();
        public static int MemoriaSize { get; set; } = 5;
        public static void AgregarProgramas(Programas programa)
        {
            if (Memoria.Count < MemoriaSize)
            {
                ColaProgramas.Enqueue(programa);
                Memoria.Add(programa);
            }
            else
            {
                Programas programaRemovido = ColaProgramas.Dequeue();
                RemoverProgramaDeMemoria(programaRemovido);

                ColaProgramas.Enqueue(programa);
                Memoria.Add(programa);
            }
        }

        private static void RemoverProgramaDeMemoria(Programas programa)
        {
            Memoria.Remove(programa);
        }

        public static Programas EliminarProgramas()
        {
            return ColaProgramas.Dequeue();
        }

        public static int ContarProgramas()
        {
            return ColaProgramas.Count;
        }

        public static Queue<Programas> ObtenerColaProgramas()
        {
            return ColaProgramas;
        }
    }
}
