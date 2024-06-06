using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_MODERNISTA
{
    internal class SistemaOperativo
    {
        public int cantPaginas { get; set; } //Memoria Virtual -- Esta no hace nada,es meramente representativa en este proyecto
        public int cantMarcoPaginas { get; set; } //Memoria Fisica
        public string algoritmo { get; set; }

        public SistemaOperativo(int CantPaginas, int CantMarcoPaginas, string Algoritmo)
        {
            cantPaginas = CantPaginas;
            cantMarcoPaginas = CantMarcoPaginas;
            algoritmo = Algoritmo;
        }

        public int getCantMarcoPaginas()
        {
            return cantMarcoPaginas;
        }
    }
}
