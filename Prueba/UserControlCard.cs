/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prueba.Properties;
/// <summary>
/// Aqui se crean las cartas fisicamente en el combate.
/// </summary>
namespace Prueba
{
    public partial class UserControlCard : UserControl
    {

        private int originalX = 0;
        private int originalY = 0;
        private int x = 0;
        private int y = 0;

        public string nombre;
        public string descripcion;
        public int mana;
        public int tipo;
        public int posicionMano;

        public UserControlCard(string nombre, string descripcion, int mana, int tipo, int posicionMano)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.mana = mana;
            this.tipo = tipo;
            this.posicionMano = posicionMano;
            InitializeComponent();
        }
        /// <summary>
        /// Evento para que al presionar la carta se use.
        /// </summary>
        private void UserControl_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
        /// <summary>
        /// Evento para que la carta se pueda mover arrastrandola con el cursor.
        /// </summary>
        private void UserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = (this.Left + e.X) - x;
                this.Top = (this.Top + e.Y) - y;
            }
        }
        /// <summary>
        /// Evento para que al soltar la carta se use.
        /// </summary>
        private void UserControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = originalX;
                this.Top = originalY;
                hacerFuncion();
                this.Location = new Point(originalX, originalY);
            }
        }
        private void UserControlCarta_Load(object sender, EventArgs e)
        {
            lblNombreCarta.Text = nombre;
            lblDescripcionCarta.Text = descripcion;
            lblMana.Text = mana.ToString();
            lblTipo.Text = tipo.ToString();
        }
        /// <summary>
        /// Método que indica la posición original de las cartas. Sirve para que se coloquen en su sitio original.
        /// </summary>
        public void recibirPosicionOriginal (int posicionX, int posicionY)
        {
            originalX = posicionX;
            originalY = posicionY;
        }
        public virtual void hacerFuncion()
        {
           
        }
        /// <summary>
        /// Método que coloca las imágenes de cada carta existente.
        /// </summary>
        /// <param name="id"> id - id de las cartas de la base de datos</param>
        public void cambiarFoto(int id)
        {
            switch (id)
            {
                case 1:
                    this.pictureBox2.Image = Resources.Quemar;
                    break;
                case 2:
                    this.pictureBox2.Image = Resources.Golpe;
                    break;
                case 3:
                    this.pictureBox2.Image = Resources.Curar;
                    break;
                case 4:
                    this.pictureBox2.Image = Resources.Maldicion;
                    break;
                case 5:
                    this.pictureBox2.Image = Resources.Disparo_certero;
                    break;
                case 6:
                    this.pictureBox2.Image = Resources.Curar_2;
                    break;
                case 7:
                    this.pictureBox2.Image = Resources.Ayuda;
                    break;
                case 8:
                    this.pictureBox2.Image = Resources.Ventisca;
                    break;
                case 9:
                    this.pictureBox2.Image = Resources.Mordisco;
                    break;
                case 10:
                    this.pictureBox2.Image = Resources.Succion;
                    break;
                case 11:
                    this.pictureBox2.Image = Resources.Pillaje;
                    break;
                case 12:
                    this.pictureBox2.Image = Resources.Chupasangre;
                    break;
                case 13:
                    this.pictureBox2.Image = Resources.Estallido;
                    break;
                case 14:
                    this.pictureBox2.Image = Resources.Curar_3;
                    break;
                case 15:
                    this.pictureBox2.Image = Resources.Asalto;
                    break;
                case 16:
                    this.pictureBox2.Image = Resources.Infeccion;
                    break;
                case 17:
                    this.pictureBox2.Image = Resources.Picadura;
                    break;
                case 18:
                    this.pictureBox2.Image = Resources.Fuerza_sobrenatural;
                    break;
                case 19:
                    this.pictureBox2.Image = Resources.AyudaExtra;
                    break;
                case 20:
                    this.pictureBox2.Image = Resources.Ataque_basico;
                    break;
                case 21:
                    this.pictureBox2.Image = Resources.Golpe_fantasmal;
                    break;
                case 22:
                    this.pictureBox2.Image = Resources.Aris;
                    break;
                case 23:
                    this.pictureBox2.Image = Resources.Aris2;
                    break;
                case 24:
                    this.pictureBox2.Image = Resources.Aris3;
                    break;
                case 25:
                    this.pictureBox2.Image = Resources.Phyri;
                    break;
                case 26:
                    this.pictureBox2.Image = Resources.Phyri2;
                    break;
                case 27:
                    this.pictureBox2.Image = Resources.Phyri3;
                    break;
                case 28:
                    this.pictureBox2.Image = Resources.Jackal;
                    break;
                case 29:
                    this.pictureBox2.Image = Resources.Jackal2;
                    break;
                case 30:
                    this.pictureBox2.Image = Resources.Jackal3;
                    break;
                default:
                    break;
            }
        }
    }
}
