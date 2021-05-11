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
using System.Windows.Forms;
namespace Prueba
{
    /// <summary>
    /// Esta clase contiene los datos de las cartas y sus efectos.
    /// </summary>
    [Serializable]
    public class Card
    {
        private int idCarta;
        private string nombreCarta;
        private int tipo;
        private string descripcionCarta;
        private int numeroMana;
        private int daño;
        private int curacion;
        private int precio;
        private bool cartaTemporal;

        public int IdCarta { get => idCarta; set => idCarta = value; }
        public string NombreCarta { get => nombreCarta; set => nombreCarta = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        public string DescripcionCarta { get => descripcionCarta; set => descripcionCarta = value; }
        public int NumeroMana { get => numeroMana; set => numeroMana = value; }
        public int Daño { get => daño; set => daño = value; }
        public int Curacion { get => curacion; set => curacion = value; }
        public int Precio { get => precio; set => precio = value; }
        public bool CartaTemporal { get => cartaTemporal; set => cartaTemporal = value; }

        public Card(int idCarta, string nombreCarta, int tipo, string descripcionCarta,
            int numeroMana, int daño, int curacion, int precio, bool cartaTemporal)
        {
            this.idCarta = idCarta;
            this.nombreCarta = nombreCarta;
            this.tipo = tipo;
            this.descripcionCarta = descripcionCarta;
            this.numeroMana = numeroMana;
            this.daño = daño;
            this.curacion = curacion;
            this.precio = precio;
            this.cartaTemporal = cartaTemporal;
        }
        /// <summary>
        /// Método donde se programan los efectos de las cartas según su tipo.
        /// </summary>
        public void usarCarta(Character propietario, Character objetivo)
        {
            switch (this.tipo)
            {
                case 1:
                    //carta tipo 1: daño.
                    objetivo.Vida -= daño;
                    break;
                case 2:
                    //carta tipo 2: curación.
                    propietario.Vida += curacion;
                    if (propietario.Vida > propietario.VidaMaxima)
                    {
                        propietario.Vida = propietario.VidaMaxima;
                    }
                    break;
                case 3:
                    //carta tipo 3: robar.
                    if (daño > 0) //De tu mazo.
                    {
                        for (int i = 0; i < daño; i++)
                        {
                            if (Fight.robarJugador)
                            {
                                Fight.robarCarta();
                            }
                        }
                    }
                    if (curacion > 0) //Del mazo enemigo.
                    {
                        for (int i = 0; i < curacion; i++)
                        {
                            if (Fight.mazoEnemigo.Count != 0 && Fight.mano.Count + 1 <= 6)
                            {
                                Fight.posicionRobada = Fight.mano.Count();
                                Fight.mano.Add(Fight.mazoEnemigo[0]);
                                Fight.mazoEnemigo.RemoveAt(0);
                            }
                        }
                    }
                    break;
                case 4:
                    //carta tipo 4: robo vida.
                    objetivo.Vida -= daño;
                    propietario.Vida += curacion;
                    if (propietario.Vida > propietario.VidaMaxima)
                    {
                        propietario.Vida = propietario.VidaMaxima;
                    }
                    break;
                case 5:
                    //carta tipo 5: criatura.
                    if (this.idCarta == 22) //Aris.
                    {
                        propietario.Vida += this.curacion;
                        if (Fight.mazoEnemigo.Count != 0 && Fight.mano.Count + 1 <= 6)
                        {
                            Fight.posicionRobada = Fight.mano.Count();
                            Fight.mano.Add(Fight.mazoEnemigo[0]);
                            Fight.mazoEnemigo.RemoveAt(0);
                        }
                    }
                    else if (this.idCarta == 23)
                    {
                        propietario.Vida += this.curacion;
                        for (int i = 0; i <= 1; i++)
                        {
                            if (Fight.mazoEnemigo.Count != 0 && Fight.mano.Count + 1 <= 6)
                            {
                                Fight.posicionRobada = Fight.mano.Count();
                                Fight.mano.Add(Fight.mazoEnemigo[0]);
                                Fight.mazoEnemigo.RemoveAt(0);
                            }
                        }
                    }
                    else if (this.idCarta == 24)
                    {
                        propietario.Vida += this.curacion;
                        for (int i = 0; i <= 2; i++)
                        {
                            if (Fight.mazoEnemigo.Count != 0 && Fight.mano.Count + 1 <= 6)
                            {
                                Fight.posicionRobada = Fight.mano.Count();
                                Fight.mano.Add(Fight.mazoEnemigo[0]);
                                Fight.mazoEnemigo.RemoveAt(0);
                            }
                        }
                    }
                    else if (this.idCarta == 25) //Phyri.
                    {
                        objetivo.Vida -= daño;
                        propietario.Vida += curacion;
                        if (propietario.Vida > propietario.VidaMaxima)
                        {
                            propietario.Vida = propietario.VidaMaxima;
                        }
                        Fight.robarCarta();
                    }
                    else if (this.idCarta == 26)
                    {
                        objetivo.Vida -= daño;
                        propietario.Vida += curacion;
                        if (propietario.Vida > propietario.VidaMaxima)
                        {
                            propietario.Vida = propietario.VidaMaxima;
                        }
                        for (int i = 0; i <= 1; i++)
                        {
                            Fight.robarCarta();
                        }    
                    }
                    else if (this.idCarta == 27)
                    {
                        objetivo.Vida -= daño;
                        propietario.Vida += curacion;
                        if (propietario.Vida > propietario.VidaMaxima)
                        {
                            propietario.Vida = propietario.VidaMaxima;
                        }
                        for (int i = 0; i <= 2; i++)
                        {
                            Fight.robarCarta();
                        }
                    }
                    else if (this.idCarta == 28) //Jackal.
                    {
                        objetivo.Vida -= daño;
                        Fight.robarCartaDaño();
                    }
                    else if (this.idCarta == 29)
                    {
                        objetivo.Vida -= daño;
                        for (int i = 0; i <= 1; i++)
                        {
                            Fight.robarCartaDaño();
                        }
                    }
                    else if (this.idCarta == 30)
                    {
                        objetivo.Vida -= daño;
                        for (int i = 0; i <= 2; i++)
                        {
                            Fight.robarCartaDaño();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
