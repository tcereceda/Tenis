using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tenis.Test
{
    /// <summary>
    /// Descripción resumida de UnitTest2
    /// </summary>
    [TestClass]
    public class MarcadorTest
    {
        [TestMethod]
        public void ResultadoIguales()
        {
            Set[] numeroDeSets = new Set[3];
            Jugador Nadal = new Jugador();
            Nadal.Nombre = "Nadal";
            Nadal.NumeroSets = new Set[3];

            for (int i = 0; i < Nadal.NumeroSets.Length; i++)
            {
                Nadal.NumeroSets[i] = new Set();
            }

            Jugador Federer = new Jugador();
            Federer.Nombre = "Federer";
            Federer.NumeroSets = new Set[3];

            for (int i = 0; i < Federer.NumeroSets.Length; i++)
            {
                Federer.NumeroSets[i] = new Set();
            }

            //Marcador 
            Nadal.Puntos = 3;   // 40
            Federer.Puntos = 3; // 40

            Marcador marcador = new Marcador(Nadal, Federer, numeroDeSets);
            marcador.SetActual = 1;

            marcador.addResultadoJuego(Nadal);
          
            Assert.IsTrue(marcador.Iguales);

        }

        [TestMethod]
        public void NuevoJuegoPuntosACero()
        {
            Set[] numeroDeSets = new Set[3];
            Jugador Nadal = new Jugador();
            Nadal.Nombre = "Nadal";
            Nadal.NumeroSets = new Set[3];

            for (int i = 0; i < Nadal.NumeroSets.Length; i++)
            {
                Nadal.NumeroSets[i] = new Set();
            }

            Jugador Federer = new Jugador();
            Federer.Nombre = "Federer";
            Federer.NumeroSets = new Set[3];

            for (int i = 0; i < Federer.NumeroSets.Length; i++)
            {
                Federer.NumeroSets[i] = new Set();
            }

            //Marcador 
            Nadal.Puntos = 4;   // gana
            Federer.Puntos = 2; // 30

            Marcador marcador = new Marcador(Nadal, Federer, numeroDeSets);
            marcador.SetActual = 1;

            marcador.addResultadoJuego(Nadal);

            Assert.AreEqual(0, Nadal.Puntos);
        }

        [TestMethod]
        public void CambioDeSet()
        {
            Set[] numeroDeSets = new Set[3];
            Jugador Nadal = new Jugador();
            Nadal.Nombre = "Nadal";
            Nadal.NumeroSets = new Set[3];

            for (int i = 0; i < Nadal.NumeroSets.Length; i++)
            {
                Nadal.NumeroSets[i] = new Set();
            }

            Jugador Federer = new Jugador();
            Federer.Nombre = "Federer";
            Federer.NumeroSets = new Set[3];

            for (int i = 0; i < Federer.NumeroSets.Length; i++)
            {
                Federer.NumeroSets[i] = new Set();
            }

            //Marcador 
            Nadal.Puntos = 4;   // gana
            Federer.Puntos = 2; // 30

            Nadal.Juegos = 5;
            Federer.Juegos = 4;

            Marcador marcador = new Marcador(Nadal, Federer, numeroDeSets);
            marcador.SetActual = 1;

            marcador.addResultadoJuego(Nadal);

            Assert.AreEqual(2, marcador.SetActual);
        }
    }
}
