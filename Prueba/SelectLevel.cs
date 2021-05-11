/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
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
    /// Ventana  donde el jugador selecciona los diferentes niveles.
    /// </summary>
    public partial class SelectLevel : Form
    {
        private List<Button> botonesMapa = new List<Button>();
        public SelectLevel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Método en donde se crean los enemigos y se les asigna un nivel.
        /// </summary>
        private void inicioCombate_click(object sender, EventArgs e)
        {
            Character enemigo = null;
            Image imagenEnemigo = null;
            Image imagenFondo = null;
            var boton = sender as Button;
            if (boton.Name.Contains("Primero"))
            {
                enemigo = Enemies.crearEnemigo(1); //Aqui se indica que enemigo pertenece a este nivel.
                imagenEnemigo = Resources.SlimeContenido; //Se carga su imagen en el combate.
                imagenFondo = Resources.fondo1; //Se carga el escenario del combate, es decir, el fondo.
            }
            else if (boton.Name.Contains("Segundo"))
            {
                enemigo = Enemies.crearEnemigo(2);
                imagenEnemigo = Resources.Slime;
                imagenFondo = Resources.fondo1;

            }
            else if (boton.Name.Contains("Tercero"))
            {
                enemigo = Enemies.crearEnemigo(3);
                imagenEnemigo = Resources.GolemContenido;
                imagenFondo = Resources.fondo2;

            }
            else if (boton.Name.Contains("Cuarto"))
            {
                enemigo = Enemies.crearEnemigo(4);
                imagenEnemigo = Resources.Golem;
                imagenFondo = Resources.fondo2;

            }
            else if (boton.Name.Contains("Quinto"))
            {
                enemigo = Enemies.crearEnemigo(5);
                imagenEnemigo = Resources.GargolaContenido;
                imagenFondo = Resources.fondo3;

            }
            else if (boton.Name.Contains("Sexto"))
            {
                enemigo = Enemies.crearEnemigo(6);
                imagenEnemigo = Resources.Gargola;
                imagenFondo = Resources.fondo3;

            }
            else if (boton.Name.Contains("Septimo"))
            {
                enemigo = Enemies.crearEnemigo(7);
                imagenEnemigo = Resources.UnicornioContenido;
                imagenFondo = Resources.fondo4;

            }
            else if (boton.Name.Contains("Octavo"))
            {
                enemigo = Enemies.crearEnemigo(8);
                imagenEnemigo = Resources.Unicornio;
                imagenFondo = Resources.fondo4;

            }
            else if (boton.Name.Contains("Noveno"))
            {
                enemigo = Enemies.crearEnemigo(9);
                imagenEnemigo = Resources.ManticoraContenido;
                imagenFondo = Resources.fondo5;

            }
            else if (boton.Name.Contains("Final"))
            {
                enemigo = Enemies.crearEnemigo(10);
                imagenEnemigo = Resources.Manticora;
                imagenFondo = Resources.fondo5;
            }

            Fight combate = new Fight(enemigo, imagenEnemigo, imagenFondo);
            this.Visible = false;
            combate.Show();
            this.Close();
        }
        private void btnAtras_Click(object sender, EventArgs e)
        {
            SecondaryMenu secundario = new SecondaryMenu();
            secundario.Show();
            this.Close();
        }
        private void SeleccionarNivel_Load(object sender, EventArgs e)
        {
            botonesMapa.Add(btnNivelPrimero);
            botonesMapa.Add(btnNivelSegundo);
            botonesMapa.Add(btnNivelTercero);
            botonesMapa.Add(btnNivelCuarto);
            botonesMapa.Add(btnNivelQuinto);
            botonesMapa.Add(btnNivelSexto);
            botonesMapa.Add(btnNivelSeptimo);
            botonesMapa.Add(btnNivelOctavo);
            botonesMapa.Add(btnNivelNoveno);
            botonesMapa.Add(btnNivelFinal);

            for (int i = 0; i < botonesMapa.Count(); i++)
            {
                //Al completar un nivel este se bloqueará y el siguiente se desbloqueará.
                if (GameProgress.jugador.Nivel - 1 == i)
                {
                    botonesMapa[i].Enabled = true;
                }
                else
                {
                    botonesMapa[i].Enabled = false;
                }
            }
        }
    }
}
