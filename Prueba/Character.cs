/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    /// <summary>
    /// En esta clase de define al personaje. Se trata de una clase objeto.
    /// </summary>
    [Serializable]
    public class Character  
    {
        private List<Card> mazo = new List<Card>();

        private string nombre;
        private int vida;
        private int vidaMaxima;
        private int numeroMana;
        private int manaMaximo;
        private int dinero = 10;
        private bool estaMuerto = false;
        private int nivel = 1;

        public List<Card> Mazo { get => mazo; set => mazo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Vida { get => vida; set => vida = value; }
        public int NumeroMana { get => numeroMana; set => numeroMana = value; }
        public int Dinero { get => dinero; set => dinero = value; }
        public int VidaMaxima { get => vidaMaxima; set => vidaMaxima = value; }
        public bool EstaMuerto { get => estaMuerto; set => estaMuerto = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public int ManaMaximo { get => manaMaximo; set => manaMaximo = value; }

        /// <summary>
        /// Método que restablece los valores del maná y la vida al comenzar un nuevo combate.
        /// </summary>
        public void reiniciarCombate()
        {
            vida = vidaMaxima;
            manaMaximo = 3;
            numeroMana = 3;
            estaMuerto = false;
        }
    }
}


