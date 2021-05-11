/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
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
    /// Pantalla de presentación de la aplicación.
    /// </summary>
    public partial class ScreenTitle : Form
    {
        public ScreenTitle()
        {
            InitializeComponent();
            timer1.Interval = 600; //Intervalo de tiempo del timer.
        }
        private void PantallaTitulo_KeyPress(object sender, KeyPressEventArgs e) //Evento que al pulsar un botón abre la siguiente ventana.
        {
                MainMenu principal = new MainMenu();
                principal.Show();
                this.Close();
        }
        private void timer1_Tick(object sender, EventArgs e) //Timer que permite que el label "parpadee" en el intervalo de tiempo previamente establecido.
        {
            lblPresentacion.Visible = !lblPresentacion.Visible;
        }

        private void ScreenTitle_Load(object sender, EventArgs e)
        {

        }
    }
}
