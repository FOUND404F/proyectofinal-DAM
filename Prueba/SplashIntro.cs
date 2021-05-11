/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using System;
using System.Windows.Forms;

namespace Prueba
{
    /// <summary>
    /// Formulario de carga de mi aplicación. Esta simula una pantalla de carga de un videojuego.
    /// </summary>
    public partial class SplashIntro : Form
    {
        #region atributos
        private int cargar;
        private int repeticiones;
        #endregion
        public SplashIntro()
        {
            InitializeComponent();
        }
        private void SplashIntro_Load(object sender, EventArgs e)
        {
            cargar = 0;
            Random r = new Random();
            repeticiones = 2;  //r.Next(2, 6);
            timerBarraCarga.Interval = 500;
            timerBarraCarga.Tick += timer_Tick;
            timerBarraCarga.Start();

            timerMensajeCarga.Interval = 50;
            timerMensajeCarga.Tick += timerMensajeCarga_Tick;
            timerMensajeCarga.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (cargar != repeticiones)
            {
                barraCarga.Value += 100 / repeticiones;
                cargar++;
            }
            else
            {
                timerMensajeCarga.Stop();
                timerBarraCarga.Stop();
                ScreenTitle titulo = new ScreenTitle();
                titulo.Show();
                this.Close();
            }
        }
        private void timerMensajeCarga_Tick(object sender, EventArgs e)
        {
            labelLoading.Left += 5;
            if (labelLoading.Left > Width - 20)
            {
                labelLoading.Left -= Width;
            }
        }
    }
}
