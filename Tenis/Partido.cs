using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    public class Partido
    {
        private Jugador jugador1;
        private Jugador jugador2;
        private Int32 sets;     
        private Marcador marcador;
        public Set[] numeroSets;
        private Int32 setActual;

        public Partido(Jugador Jugador1, Jugador Jugador2, Int32 Sets)
        {
            this.jugador1 = Jugador1;
            this.jugador2 = Jugador2;
            this.sets = Sets;
           
            this.marcador = new Marcador(jugador1, jugador2, numeroSets);
        }

        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public Marcador Marcador { get => marcador; set => marcador = value; }
        public int SetActual { get => setActual; set => setActual = value; }

        public void puntoAl(Jugador jugador)
        {
            if (Marcador.TieBreak)
            {
                jugador.Puntos++;
                Marcador.addResultadoTieBreak(jugador);
            }

            else if (!Marcador.Iguales)
            {
                jugador.Puntos++;

                Marcador.addResultadoJuego(jugador);
            }
            else
            {
                if (jugador == jugador1) Marcador.Ventaja--;
                if (jugador == jugador2) Marcador.Ventaja++;

                Marcador.addVentaja(Marcador.Ventaja, jugador);
            }

        }

    }
}
