using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    public class Jugador
    {
        private string nombre;
        private Int32 puntos = 0 ;
        private Int32 juegos = 0;
        private Int32 sets = 0;
        private Set[] numeroSets;

        public string Nombre { get => nombre; set => nombre = value; }

        public Int32 Puntos { get => puntos; set => puntos = value; }
        public int Juegos { get => juegos; set => juegos = value; }
        public int Sets { get => sets; set => sets = value; }
        public Set[] NumeroSets { get => numeroSets; set => numeroSets = value; }
    }
}
