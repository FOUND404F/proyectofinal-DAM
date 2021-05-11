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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    /// <summary>
    /// Ventana de la tienda de la aplicación. Aqui se pueden comprar nuevas cartas y añadirlas al mazo
    /// básico del jugador.
    /// </summary>
    public partial class Shop : Form
    {
        private delegate void cerrarVentana(); 
        private List<Card> cartasTienda = new List<Card>();

        public Shop()
        {
            InitializeComponent();
            cargarCartasTienda();
            textDinero.Text = GameProgress.jugador.Dinero.ToString(); 
            cajaTexto.Text = "¡Bienvenid@! Presiona una de las imágenes para saber sus detalles.";
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            imagenDueñoTienda.Image = Resources.YellowBlue2_FINAL;
            cajaTexto.Text = "¡Hasta pronto!";
            Task task = Task.Run(() => cerrar()); //Se crea un hilo secundario, que se ejecutará al pulsar el botón "Atrás".
        }
        /// <summary>
        /// Método que se ejecuta al cerrar la ventana mediante el botón "Atrás".
        /// </summary>
        private void cerrar()
        {
            Thread.Sleep(2000);
            this.Invoke(new cerrarVentana(this.cerrarHilo)); //Se usa Invoke por que no puede acceder al hilo principal.
        }
        /// <summary>
        /// Método que permite al jugador acceder a la ventana de MENÚ SECUNDARIO.
        /// </summary>
        private void cerrarHilo()
        {
            SecondaryMenu secundario = new SecondaryMenu();
            secundario.Show();
            this.Close();
        }
        /// <summary>
        /// Método de compra de las cartas.
        /// </summary>
        private void comprar(object sender, EventArgs e)
        {
            var button = sender as Button;
            int posicionCarta = 0;
            if (button.Name.Contains("1"))
            {
                posicionCarta = 0;
            }
            else if (button.Name.Contains("2"))
            {
                posicionCarta = 1;
            }
            else if (button.Name.Contains("3"))
            {
                posicionCarta = 2;
            }
            else if (button.Name.Contains("4"))
            {
                posicionCarta = 3;
            }
            Card cartaComprada = cartasTienda[posicionCarta];
            if(GameProgress.jugador.Dinero >= cartaComprada.Precio)
            {
                GameProgress.jugador.Mazo.Add(cartaComprada); //Se añade la carta al mazo básico.
                GameProgress.jugador.Dinero -= cartaComprada.Precio; //Se resta el dinero.
                textDinero.Text = GameProgress.jugador.Dinero.ToString(); //Se actualiza el dinero en la interfaz.
                MessageBox.Show("Carta " + cartaComprada.NombreCarta + " comprada");
                BinaryController.guardarBinario(GameProgress.jugador); //Se guarda la partida.
            }
            else
            {
                MessageBox.Show("¡Insuficiente dinero!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método que se encarga de cargar las cartas según su id.
        /// </summary>
        private void cargarCartasTienda()
        {
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from carta where idCarta between 13 and 16"); 
            MySqlDataReader reader = con.executeSelect();

            while (reader.Read())
            {
                int idCarta = reader.GetInt32(0);
                string nombreCarta = reader.GetString(1);
                string descripcionCarta = reader.GetString(2);
                int numeroMana = reader.GetInt32(3);
                int tipo = reader.GetInt32(4);
                int daño = reader.GetInt16(5);
                int curacion = reader.GetInt16(6);
                bool cartaTemporal = reader.GetBoolean(7);
                int precio = reader.GetInt16(8);
               
                Card carta = new Card (idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                cartasTienda.Add(carta); 
            }
        }
        /// <summary>
        /// Evento en el que aparece texto en la caja de texto al pulsar una imagen de las cartas.
        /// </summary>
        private void imagen1_Click(object sender, EventArgs e) 
        {
            cajaTexto.Text = "Esta carta se llama ESTADILLO. Es una carta de DAÑO y tiene 8 de poder. " +
                "Cuesta 80 de oro ¿La quieres?";
        }

        private void imagen2_Click(object sender, EventArgs e)
        {
            cajaTexto.Text = "Esta carta se llama CURA MÁXIMA. Es una carta de CURACIÓN y tiene 7 de poder." +
                " Cuesta 80 de oro ¿La quieres?";
        }

        private void imagen3_Click(object sender, EventArgs e)
        {
            cajaTexto.Text = "Esta carta se llama ASALTO. Es una carta de ROBO. Te permitirá robar 3 cartas al enemigo." +
                " Cuesta 60 de oro ¿La quieres?";
        }

        private void imagen4_Click(object sender, EventArgs e)
        {
            cajaTexto.Text = "Esta carta se llama INFECCIÓN. Es una carta de ROBO DE VIDA y tiene 7 de poder." +
                " Cuesta 80 de oro ¿La quieres?";
        }
    }
}

