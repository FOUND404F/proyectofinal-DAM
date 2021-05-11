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
    /// Ventana del menú principal que permite al jugador crear una nueva partida, cargar una o salir de la aplicación.
    /// </summary>
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnNuevaPartida_Click(object sender, EventArgs e)
        {
            NewGame nuevaPartida = new NewGame();
            nuevaPartida.Show();
            this.Close();
        }
        /// <summary>
        /// Evento donde se cargará una partida.Se utiliza un OpenDialog y solo filtra los archivos .cfg
        /// </summary>
        private void cargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Ficheros binarios|*.cfg";
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bool cargado = BinaryController.cargarBinario(openFileDialog1.FileName);
                if (cargado)
                {
                    MessageBox.Show("Partida cargada con éxito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SecondaryMenu secundario = new SecondaryMenu();
                    secundario.Show();
                    this.Close();
                }
            }
        }
        private void btnCerrarJuego_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        private void btnCreditos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trabajo de fin de grado creado por Raquel Heredia Diaz", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
