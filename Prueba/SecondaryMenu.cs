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
    /// Ventana de menú secundario que permite al jugador acceder a los niveles, a la tienda, a la mejora de carta
    /// inicial y a la enciclopedia.
    /// </summary>
    public partial class SecondaryMenu : Form
    {
        public SecondaryMenu()
        {
            InitializeComponent();

        }
        private void btnSeleccionarNivel_Click(object sender, EventArgs e)
        {
            SelectLevel nivel = new SelectLevel();
            nivel.Show();
            this.Close();

        }
        private void btnTienda_Click(object sender, EventArgs e)
        {
            Shop tienda = new Shop();
            tienda.Show();
            this.Close();

        }
        private void btnMejorarCarta_Click(object sender, EventArgs e)
        {
            UpgradeCard mejorar = new UpgradeCard();
            mejorar.Show();
            this.Close();

        }
        private void btnEnciclopedia_Click(object sender, EventArgs e)
        {
            Encyclopedia enciclopedia = new Encyclopedia();
            enciclopedia.Show();
            this.Close();

        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            MainMenu principal = new MainMenu();
            principal.Show();
            this.Close();

        }
    }
}
