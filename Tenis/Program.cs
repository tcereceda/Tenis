using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();
           
            Int32 sets=0;

            Partido partido = new Partido(jugador1, jugador2, sets);
            partido.SetActual = 0;

            Console.WriteLine("Nombre del jugador 1:");
            jugador1.Nombre = Console.ReadLine();

            Console.WriteLine("Nombre del jugador 2:");
            jugador2.Nombre = Console.ReadLine();

            while (partido.numeroSets == null)
            {
                Console.WriteLine("Numero de sets del partido (3 o 5):");

                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero == 3 || numero == 5)
                {
                    partido.numeroSets = new Set[numero];
                    jugador1.NumeroSets = new Set[numero];

                    for (int i=0; i< jugador1.NumeroSets.Length; i++) {
                        jugador1.NumeroSets[i] = new Set();
                    }

                    jugador2.NumeroSets = new Set[numero];

                    for (int i = 0; i < jugador2.NumeroSets.Length; i++)
                    {
                        jugador2.NumeroSets[i] = new Set();
                    }
                }
            }

            Marcador marcador = new Marcador(jugador1, jugador2, partido.numeroSets);
            
            // Sorteo de quien saca primero
            Random random = new Random();
            int saca = random.Next(1, 3);
            if (saca == 1)
            {
                Console.WriteLine(jugador1.Nombre + " iniciará el partido sacando");
            }
            else
            {
                Console.WriteLine(jugador2.Nombre + " iniciará el partido sacando");
            }

            // Set 1
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            // Set2
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            //TieBreak
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            // Set3
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            // Set4
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);

            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);

            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador1);
            partido.puntoAl(jugador2);
            partido.puntoAl(jugador1);
        }
    }
}
