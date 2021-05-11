/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using MySql.Data.MySqlClient;
using Prueba.Properties;
using System;
using System.Windows.Forms;
namespace Prueba
{
    /// <summary>
    /// Ventana donde se puede leer el lore de los personajes.
    /// </summary>
    public partial class Encyclopedia : Form
    {
        private int indice = 1;
        private int idMaximo;
        public Encyclopedia()
        {
            InitializeComponent();
            leerEnciclopedia();
            idMaximo = recuperarIdMax();
        }
        /// <summary>
        /// Método que busca los datos en la base de datos mediante el índice de la enciclopedia.
        /// </summary>
        private void leerEnciclopedia ()
        {
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from datosEnciclopedia where id= " + indice + "");
            MySqlDataReader reader = con.executeSelect();

            if (reader.HasRows)
            {
                reader.Read();
                int id = reader.GetInt32(0);
                string nombre = reader.GetString(1);
                string etimologia = reader.GetString(2);
                string comportamiento = reader.GetString(3);

                textBoxNombre.Text = nombre;
                textBoxEtimologia.Text = etimologia;
                textBoxComportamiento.Text = comportamiento;
                cargarImagen(id);
            }
            con.closeConnection();
        }
        /// <summary>
        /// Método que carga las imágenes según un id del resource.
        /// </summary>
        /// <param name="id">int - identificador de la carta para cargar su imagen correspondiente</param>
        private void cargarImagen(int id)
        {
            if (id == 1)
            {
                imagenPrincipal.Image = Resources.Aris3;
            }
            else if (id == 2)
            {
                imagenPrincipal.Image = Resources.Phyri3;
            }
            else if (id == 3)
            {
                imagenPrincipal.Image = Resources.Jackal3;
            }
            else if (id == 4)
            {
                imagenPrincipal.Image = Resources.YellowBluEnciclopedia;
            }
            else if (id == 5)
            {
                imagenPrincipal.Image = Resources.SlimeEnciclopedia;
            }
            else if (id == 6)
            {
                imagenPrincipal.Image = Resources.GolemEnciclopedia;
            }
            else if (id == 7)
            {
                imagenPrincipal.Image = Resources.GargolaEnciclopedia;
            }
            else if (id == 8)
            {
                imagenPrincipal.Image = Resources.CaballoEnciclopedia;
            }
            else if (id == 9)
            {
                imagenPrincipal.Image = Resources.LeonEnciclopedia;
            }
        }
        /// <summary>
        /// Método que permite que no colapse el programa al llegar al límite de id, es decir, cuando se hayan cargado toda
        /// la información e imágenes.
        /// </summary>
        /// <returns>int - retorna el idMaximo de la enciclopedia de la base de datos</returns>
        public int recuperarIdMax ()
        {
            int idMax = 0;
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select max(id) from datosEnciclopedia");
            MySqlDataReader reader = con.executeSelect();

            if (reader.HasRows)
            {
                reader.Read();
                idMax = reader.GetInt32(0);
            }
            con.closeConnection();

            return idMax;
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            SecondaryMenu secundario = new SecondaryMenu();
            secundario.Show();
            this.Close();
        }
        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            if (indice-1 >= 1) //Permite retroceder en el índice. 
            {
                indice -= 1; 
                leerEnciclopedia();
            }
        }
        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (indice + 1 <= idMaximo) //Permite avanzar en el índice.
            {
                indice += 1; 
                leerEnciclopedia();
            }
        }
    }
}
