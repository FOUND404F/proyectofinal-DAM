/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using MySql.Data.MySqlClient;
using Prueba.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prueba
{
    /// <summary>
    /// Ventana donde se mejora la carta inicial y adquiere efectos mejorados.
    /// </summary>
    public partial class UpgradeCard : Form
    {
        public UpgradeCard()
        {
            InitializeComponent();
            textDinero.Text = GameProgress.jugador.Dinero.ToString(); //Se actualiza el dinero en la interfaz.
        }
        private void MejorarCarta_Load(object sender, EventArgs e)
        {
            cargarCartaInicial();
            cajaTexto.Text = " Tu alma inquieta demanda un cambio... ¿Mejorar carta inicial por 100  de oro?";

        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            SecondaryMenu secundario = new SecondaryMenu();
            secundario.Show();
            this.Close();
        }
        private void btnMejorar_Click(object sender, EventArgs e)
        {
            if(GameProgress.jugador.Dinero >= 100){ 
                for (int i = 0; i < GameProgress.jugador.Mazo.Count; i++)
                {
                    Card carta = GameProgress.jugador.Mazo[i];
                    if (carta.IdCarta == 22)
                    {
                        imagen1.Image = Resources.Aris; //Cambia la imagen en la interfaz.
                        GameProgress.jugador.Mazo.RemoveAt(i); //Se borra la anterior carta del mazo básico.
                        mejorarCarta(carta.IdCarta + 1); //Se suma 1 al id, es decir, obtiene la carta número 23 en este caso.
                        break;
                    }
                    else if (carta.IdCarta == 23)
                    {
                        imagen1.Image = Resources.Aris2;
                        GameProgress.jugador.Mazo.RemoveAt(i);
                        mejorarCarta(carta.IdCarta + 1);
                        break;
                    }
                    else if (carta.IdCarta == 25)
                    {
                        imagen1.Image = Resources.Phyri2;
                        GameProgress.jugador.Mazo.RemoveAt(i);
                        mejorarCarta(carta.IdCarta + 1);
                        break;
                    }
                    else if (carta.IdCarta == 26)
                    {
                        imagen1.Image = Resources.Phyri3;
                        GameProgress.jugador.Mazo.RemoveAt(i);
                        mejorarCarta(carta.IdCarta + 1);
                        break;
                    }
                    else if (carta.IdCarta == 28)
                    {
                        imagen1.Image = Resources.Jackal2;
                        GameProgress.jugador.Mazo.RemoveAt(i);
                        mejorarCarta(carta.IdCarta + 1);
                        break;
                    }
                    else if (carta.IdCarta == 29)
                    {
                        imagen1.Image = Resources.Jackal3;
                        GameProgress.jugador.Mazo.RemoveAt(i);
                        mejorarCarta(carta.IdCarta + 1);
                        break;
                    }
                    else if(carta.IdCarta == 24 || carta.IdCarta == 27 || carta.IdCarta == 30) //Si las cartas tienen este id el programa entrará en esta condición.
                    {
                        cajaTexto.Text = "¡La carta está al máximo!";
                    }
                }
                textDinero.Text = GameProgress.jugador.Dinero.ToString(); //Se actualiza el dinero.
                cargarCartaInicial();
                BinaryController.guardarBinario(GameProgress.jugador); //Se guarda la partida.
            }
            else
            {
                MessageBox.Show("Insuficiente dinero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método que carga las imágenes de las cartas según su id de la base de datos.
        /// </summary>
        private void cargarCartaInicial()
        {
            for (int i = 0; i < GameProgress.jugador.Mazo.Count; i++)
            {
                Card carta = GameProgress.jugador.Mazo[i];
                if (carta.IdCarta == 22)
                {
                    imagen1.Image = Resources.Aris;
                }
               else if (carta.IdCarta == 23)
                {
                    imagen1.Image = Resources.Aris2;
                }
                else if (carta.IdCarta == 24)
                {
                    imagen1.Image = Resources.Aris3;
                }
                else if (carta.IdCarta == 25)
                {
                    imagen1.Image = Resources.Phyri;
                }
                else if (carta.IdCarta == 26)
                {
                    imagen1.Image = Resources.Phyri2;
                }
                else if (carta.IdCarta == 27)
                {
                    imagen1.Image = Resources.Phyri3;
                }
                else if (carta.IdCarta == 28)
                {
                    imagen1.Image = Resources.Jackal;
                }
                else if (carta.IdCarta == 29)
                {
                    imagen1.Image = Resources.Jackal2;
                }
                else if (carta.IdCarta == 30)
                {
                    imagen1.Image = Resources.Jackal3;
                }
            }
        }
        /// <summary>
        /// Método que carga los datos de las cartas iniciales según su id en la base de datos.
        /// </summary>
        private void mejorarCarta(int idCartaMejorar)
        {
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from carta where idCarta='" + idCartaMejorar + "'");
            MySqlDataReader reader = con.executeSelect();

            if (reader.HasRows)
            {
                reader.Read();
                int idCarta = reader.GetInt32(0);
                string nombreCarta = reader.GetString(1);
                string descripcionCarta = reader.GetString(2);
                int numeroMana = reader.GetInt32(3);
                int tipo = reader.GetInt32(4);
                int daño = reader.GetInt16(5);
                int curacion = reader.GetInt16(6);
                bool cartaTemporal = reader.GetBoolean(7);
                int precio = reader.GetInt16(8);
                Card carta = new Card(idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                cajaTexto.Text ="¡Enhorabuena! El nuevo efecto de la carta es: " + descripcionCarta;
                GameProgress.jugador.Mazo.Add(carta); //Se añade la nueva carta al mazo.
                GameProgress.jugador.Dinero -= 100; 
            }
            con.closeConnection();
        }
    }
}
