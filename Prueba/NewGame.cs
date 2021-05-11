/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using MySql.Data.MySqlClient;
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
    /// Ventana donde se pondrá crear una nueva partida seleccionando un nombre y una carta inicial.
    /// </summary>
    public partial class NewGame : Form
    {
        private int idCartaEscogida = 0;
        private List<Card> cartasIniciales;
        public NewGame()
        {
            InitializeComponent();
        }
        private void NuevaPartida_Load(object sender, EventArgs e)
        {
            cartasIniciales = new List<Card>();
            cargarCartasIniciales();
            cargarNuevoJugador();
        }
        /// <summary>
        /// Método donde se definen los datos del jugador y se crea su mazo básico.
        /// </summary>
        private void cargarNuevoJugador()
        {
            //Aqui se crear el jugador.
            GameProgress.jugador = new Character();
            GameProgress.jugador.Vida = 30;
            GameProgress.jugador.VidaMaxima = 30;
            GameProgress.jugador.Dinero = 500;
            GameProgress.jugador.Nivel = 1;

            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from carta"); //Se cargan todas las cartas de la base de datos para crear un mazo.
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

                Card carta = new Card(idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                //Se crea el mazo básico del jugador.
                if (idCarta == 1) //Aqui se añaden las cartas al mazo del jugador por id.
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 2)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 3)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 4)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 5)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 7)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 8)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 9)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 10)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 11)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 17)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 20)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                }
                else if (idCarta == 21)
                {
                    GameProgress.jugador.Mazo.Add(carta);
                    GameProgress.jugador.Mazo.Add(carta);
                }
            }
            con.closeConnection();
        }
        /// <summary>
        /// Evento que permite que solo se puedan escribir letras y espacios en el textBox.
        /// </summary>
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e) 
        {
            string nombre = textBoxNombre.Text;
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar) && textBoxNombre.Text.Length != 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Evento del botón que, al pulsar "OK", el panel que hay debajo del pictureBox cambie de color.
        /// </summary>
        private void btnCartaZorro_Click(object sender, EventArgs e) 
        {
            paneColorido1.BackColor = Color.GreenYellow;
            paneColorido2.BackColor = Color.Red;
            paneColorido3.BackColor = Color.Red;
            idCartaEscogida = 22;
        }
        private void btnCartaBuho_Click(object sender, EventArgs e)
        {
            paneColorido2.BackColor = Color.GreenYellow;
            paneColorido1.BackColor = Color.Red;
            paneColorido3.BackColor = Color.Red;
            idCartaEscogida = 25;
        }
        private void btnCartaConejo_Click(object sender, EventArgs e)
        {
            paneColorido3.BackColor = Color.GreenYellow;
            paneColorido1.BackColor = Color.Red;
            paneColorido2.BackColor = Color.Red;
            idCartaEscogida = 28;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Length >= 0 && idCartaEscogida != 0)
            {
                GameProgress.jugador.Nombre = textBoxNombre.Text;
                cargarCartaElegida();
                SecondaryMenu menusecundario = new SecondaryMenu();
                BinaryController.guardarBinario(GameProgress.jugador);
                MessageBox.Show("Partida creada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menusecundario.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una carta o puesto un nombre", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Método que añade la carta escogida al mazo del jugador.
        /// </summary>
        private void cargarCartaElegida()
        {
            foreach (Card carta in cartasIniciales)
            {
                if(carta.IdCarta == idCartaEscogida)
                {
                    GameProgress.jugador.Mazo.Add(carta); 
                }
            }
        }
        /// <summary>
        /// Método que carga las cartas iniciales según su id conectandose a la base de datos.
        /// </summary>
        private void cargarCartasIniciales()
        {
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from carta where idCarta = 22 or idCarta = 25 or idCarta = 28"); 
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

                Card carta = new Card(idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                cartasIniciales.Add(carta);
            }
            con.closeConnection();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            MainMenu principal = new MainMenu();
            principal.Show();
            this.Close();
        }
    }
}
