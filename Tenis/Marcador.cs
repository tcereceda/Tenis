using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    public class Marcador
    {

        private Jugador jugador1;
        private Jugador jugador2;
        private Int16 ventaja;
        private bool iguales = false;
        private bool tieBreak = false;
        private Set[] numeroSets;
        private Int32 setActual;
        private static readonly string[] traducePuntos = { "0","15","30","40","gana el juego" };

        public Marcador(Jugador jugador1, Jugador jugador2, Set[] numeroSets)
        {
            this.Jugador1 = jugador1;
            this.Jugador2 = jugador2;
            this.NumeroSets = numeroSets;
            this.setActual = 0;
        }
        public int SetActual { get => setActual; set => setActual = value; }
        public Jugador Jugador1 { get => jugador1; set => jugador1 = value; }
        public Jugador Jugador2 { get => jugador2; set => jugador2 = value; }
        public short Ventaja { get => ventaja; set => ventaja = value; }
        public bool Iguales { get => iguales; set => iguales = value; }
        public bool TieBreak { get => tieBreak; set => tieBreak = value; }
        public Set[] NumeroSets { get => numeroSets; set => numeroSets = value; }

        public void addResultadoJuego(Jugador ganador)
        {
            string resultado="";

                if (Jugador1.Puntos == 4 && Jugador2.Puntos <= 2)
                {
                    resultado = Jugador1.Nombre + " gana el juego";
                    Jugador1.Juegos++;
                    Jugador1.NumeroSets[setActual].Juegos++;
                    nuevoJuego();
                }
                else if (Jugador2.Puntos == 4 && Jugador1.Puntos <= 2) 
                {
                    resultado = Jugador2.Nombre + " gana el juego";
                    Jugador2.Juegos++;
                    Jugador2.NumeroSets[setActual].Juegos++;
                    nuevoJuego();
                }
                else if (Jugador1.Puntos == 3 && Jugador2.Puntos == 3)
                {
                    Iguales = true;
                    Ventaja = 0;
                    resultado = "Punto de " + ganador.Nombre + " 40-40";
                    Console.WriteLine(resultado + "    " + tablero());
                }
                else
                {
                    resultado = "Punto de " + ganador.Nombre + " " + traducePuntos[Jugador1.Puntos] + "-" + traducePuntos[Jugador2.Puntos];
                    Console.WriteLine(resultado + "    " + tablero());
                }
        }

        public void addVentaja(Int16 ventaja,Jugador ganador) {
            string resultado;

            if (ventaja < -1 || ventaja > 1)
            {
                resultado = ganador.Nombre + " gana el juego";
                ganador.Juegos++;
                ganador.NumeroSets[setActual].Juegos++;
                nuevoJuego();
            }
            else if (ventaja == -1) resultado = "Punto de " + ganador.Nombre + " Ad-40";
            else if (ventaja == 1) resultado = "Punto de " + ganador.Nombre + " 40-Ad";
            else resultado = "Punto de " + ganador.Nombre + " 40-40";

            Console.WriteLine(resultado + "    " + tablero());
        }

        public void addResultadoTieBreak(Jugador ganador)
        {
            if (Jugador1.Puntos >= 7 && Jugador1.Puntos - Jugador2.Puntos >= 2)
            {
                Jugador1.NumeroSets[setActual].Juegos++;
                Jugador1.Sets++;
                nuevoSet();
                Jugador1.Juegos = 0;
                Jugador2.Juegos = 0;
                Jugador1.Puntos = 0;
                Jugador2.Puntos = 0;
                SetActual++;
                TieBreak = false;
                Console.WriteLine(ganador.Nombre + " gana el set    " + tablero());
            }
            else if (Jugador2.Puntos >= 7 && Jugador2.Puntos - Jugador1.Puntos >= 2)
            {
                Jugador2.NumeroSets[setActual].Juegos++;
                Jugador2.Sets++;
                nuevoSet();
                Jugador1.Juegos = 0;
                Jugador2.Juegos = 0;
                Jugador1.Puntos = 0;
                Jugador2.Puntos = 0;
                SetActual++;
                TieBreak = false;
                Console.WriteLine(ganador.Nombre + " gana el set    " + tablero());
            }
            else
            {
                string resultado;
                resultado = Jugador1.Puntos + "-" + Jugador2.Puntos;
                Console.WriteLine("Punto de " + ganador.Nombre + " " + resultado + "    "+ tablero());
            }
        }

        public string tablero()
        {
            string tablero = "(";
            for (int i = 0; i < jugador1.NumeroSets.Length; i++)
            {
                tablero += Jugador1.NumeroSets[i].Juegos + "-" + Jugador2.NumeroSets[i].Juegos + ", ";
            }

            tablero = tablero.Substring(0, tablero.Length - 2);
            tablero += ")";

            return tablero;
        }

        public void nuevoJuego()
        {
            // Inicializamos los puntos
            Jugador1.Puntos=0;
            Jugador2.Puntos = 0;
            Iguales = false;
            Ventaja = 0;

            // Calcular si ya ha conseguido un set
            if ((Jugador1.Juegos == 6 && Jugador2.Juegos < 5) || (Jugador1.Juegos == 7 && Jugador2.Juegos == 5))
            {
                Jugador1.Sets++;
                Jugador1.Juegos = 0;
                Jugador2.Juegos = 0;
                nuevoSet();
                SetActual++;
                Console.WriteLine(Jugador1.Nombre + " gana el set    " + tablero());

            }
            else if ((Jugador2.Juegos == 6 && Jugador1.Juegos < 5) || (Jugador2.Juegos == 7 && Jugador2.Juegos == 5))
            {
                Jugador2.Sets++;
                Jugador1.Juegos = 0;
                Jugador2.Juegos = 0;
                nuevoSet();
                SetActual++;
                Console.WriteLine(Jugador2.Nombre + " gana el set    " + tablero());
            }
            else if (Jugador1.Juegos == 6 && Jugador2.Juegos == 6)
            {
                TieBreak = true;
               
            }
        }

        public void nuevoSet()
        {
            if (Jugador1.NumeroSets.Length == 3)
            {
                if (Jugador1.Sets == 2)
                {
                    Console.WriteLine("¡¡" + Jugador1.Nombre.ToUpper() + " GANA EL PARTIDO!!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }

                else if (Jugador2.Sets == 2)
                {
                   
                    Console.WriteLine("¡¡" + Jugador2.Nombre.ToUpper() + " GANA EL PARTIDO!!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            else if (Jugador1.NumeroSets.Length == 5)
            {
                if (Jugador1.Sets == 3)
                {
                    Console.WriteLine("¡¡" + Jugador1.Nombre.ToUpper() + " GANA EL PARTIDO!!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                else if (Jugador2.Sets == 3)
                {
                    Console.WriteLine("¡¡" + Jugador2.Nombre.ToUpper() + " GANA EL PARTIDO!!");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
