using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    internal class Programas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public bool VidaExtra { get; set; }

        public Programas(int id, string nombre, string estado, bool vidaExtra)
        {
            Id = id;
            Nombre = nombre;
            Estado = estado;
            VidaExtra = vidaExtra;
        }
    }
}
