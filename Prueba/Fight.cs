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
    ///Ventana que controla el sistema de combate.
    /// </summary>
    public partial class Fight : Form
    {
        private delegate void cartaEnemiga(Card cartaUsada); //Un delegado es un tipo que encapsula de forma segura un método.
        private delegate void finalizarCombate();
        private Image imagenEnemigo;
        private Image imagenFondo;
        public static BindingList<Card> mano = new BindingList<Card>(); //Una BindingList es una lista con eventos.
        public static List<DamageCard> fotosCartas = new List<DamageCard>();
        public static List<Card> mazoMezclado = new List<Card>();
        public static Character enemigoReal;
        public static List<Card> mazoEnemigo = new List<Card>();
        public static List<Card> manoEnemiga = new List<Card>();
        private int turno = 1;
        public static int posicionRobada;
        public static bool robarJugador = true;
        public Fight(Character enemigo, Image imagenEnemigo, Image imagenFondo)
        {
            this.imagenEnemigo = imagenEnemigo;
            this.imagenFondo = imagenFondo;
            mano = new BindingList<Card>();
            fotosCartas = new List<DamageCard>();
            mazoMezclado = new List<Card>();
            mazoEnemigo = new List<Card>();
            manoEnemiga = new List<Card>();
            enemigoReal = enemigo;
            InitializeComponent();
            mano.ListChanged += ControlMano;
        }
        /// <summary>
        /// Evento de control de la mano para comprobar si se añaden o se borran de la lista.
        /// </summary>
        void ControlMano(object sender, ListChangedEventArgs e) 
        {
            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                recargarMano();
                try
                {
                    progressBarEnemigo.Value = enemigoReal.Vida * 100 / enemigoReal.VidaMaxima;
                    progressBarJugador.Value = GameProgress.jugador.Vida * 100 / GameProgress.jugador.VidaMaxima;
                    textManaJugador.Text = GameProgress.jugador.NumeroMana.ToString();
                    lblVidaEnemigo.Text = enemigoReal.Vida + " / " + enemigoReal.VidaMaxima;
                    lblVidaJugador.Text = GameProgress.jugador.Vida + " / " + GameProgress.jugador.VidaMaxima;
                }
                catch (ArgumentOutOfRangeException) //Excepción cuando el enemigo o el jugador se quedan en vida negativa.
                {
                    progressBarEnemigo.Value = 0;
                    progressBarJugador.Value = 0;
                }
                if (enemigoReal.Vida <= 0) //El enemigo ha sido derrotado por que se ha quedado sin vida.
                {
                    terminarCombate();
                }
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded) //El jugador roba una carta.
            {
                crearCarta(100 * (posicionRobada + 1), 285, mano[posicionRobada], posicionRobada);
                textManaJugador.Text = GameProgress.jugador.NumeroMana.ToString();
                recargarMano();
                textContadorCartas.Text = mazoMezclado.Count().ToString();
                textContadorCartasEnemigo.Text = mazoEnemigo.Count().ToString();
            }
            else if (e.ListChangedType == ListChangedType.Reset) //El jugador se ha quedado sin cartas.
            {
                robarJugador = false;
                MessageBox.Show("¡No quedan cartas! Se reiniciará el nivel...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SelectLevel mapa = new SelectLevel();
                mapa.Show();
                this.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textNombreEnemigo.Text = enemigoReal.Nombre;
            this.fotoFondo.Image = imagenFondo;
            this.fotoEnemigo.Image = imagenEnemigo;
            GameProgress.jugador.reiniciarCombate(); //Restablece la vida y el maná del jugador.
            enemigoReal.reiniciarCombate(); //Restablece la vida y el maná del enemigo.
            textManaJugador.Text = GameProgress.jugador.NumeroMana.ToString();
            textManaEnemigo.Text = enemigoReal.NumeroMana.ToString();
            mazoMezclado = desordenarLista(GameProgress.jugador.Mazo);
            mazoEnemigo = desordenarLista(enemigoReal.Mazo);
            lblVidaEnemigo.Text = enemigoReal.Vida + " / " + enemigoReal.VidaMaxima;
            lblVidaJugador.Text = GameProgress.jugador.Vida + " / " + GameProgress.jugador.VidaMaxima;
            while (mano.Count < 4)
            {
                robarCarta();
            }
            recargarMano();
            textContadorCartas.Text = mazoMezclado.Count().ToString();
            textContadorCartasEnemigo.Text = mazoEnemigo.Count().ToString();
        }
        /// <summary>
        /// Método que carga las cartas del jugador en la mano.
        /// </summary>
        /// <param name="posicionX">int - Se refiere a su posición en el eje Y</param>
        /// <param name="posicionY">int - Se refiere a su posición en el eje X</param>
        /// <param name="carta">Carta - Se trata de la carta en sí</param>
        /// <param name="posicionMano">int - Se refiere a la posición que tiene una carta en la mano</param>
        private void crearCarta(int posicionX, int posicionY, Card carta, int posicionMano)
        {
            DamageCard cartaDaño = new DamageCard(carta.NombreCarta, carta.DescripcionCarta, carta.NumeroMana,
                carta.Tipo, posicionMano);
            cartaDaño.recibirPosicionOriginal(posicionX, posicionY);
            cartaDaño.Location = new Point(posicionX, posicionY);
            cartaDaño.cambiarFoto(carta.IdCarta);
            fotosCartas.Add(cartaDaño);
            if (posicionMano == -1) //Cuando el enemigo usa una carta.
            {
                cartaDaño.Enabled = false;
                this.Controls.Add(cartaDaño);
            }
            cartaDaño.BringToFront();
        }
        /// <summary>
        /// Método que devuelve la lista desordenada aleatoriamente.
        /// </summary>
        private List<Card> desordenarLista(List<Card> original)
        {
            List<Card> copia = new List<Card>(); //Se hace una copia de la lista.
            for (int i = 0; i < original.Count; i++)
            {
                copia.Add(original[i]);
            }
            List<Card> copiaDesordenada = new List<Card>();
            Random randNum = new Random();
            while (copia.Count > 0)
            {
                //Añade una carta a la lista desordenada y la borra de la lista copiada.
                int val = randNum.Next(0, copia.Count - 1);
                copiaDesordenada.Add(copia[val]);
                copia.RemoveAt(val);
            }
            return copiaDesordenada;
        }

        /// <summary>
        /// Método para el jugador cuando roba una carta de su mazo.
        /// </summary>
        public static void robarCarta()
        {
            if (mano.Count < 6) //El jugador no puede robar del mazo si tiene 6 cartas en la mano.
            {
                if (mazoMezclado.Count != 0)
                {
                    posicionRobada = mano.Count;
                    mano.Add(mazoMezclado[0]);
                    mazoMezclado.RemoveAt(0);
                }
                else
                {
                    if (mano.Count == 0)
                    {
                        robarJugador = false;
                        mano.Clear();
                    }
                }
            }
        }
        /// <summary>
        /// Método que muestra las cartas de manera visual.
        /// </summary>
        private void recargarMano()
        {
            int x = 100;
            int y = 285;
            for (int i = 0; i < mano.Count; i++)
            {
                fotosCartas[i].posicionMano = i;
                fotosCartas[i].Location = new Point(x, y);
                this.Controls.Add(fotosCartas[i]);
                fotosCartas[i].BringToFront();
                x += 100;
            }
        }
        /// <summary>
        /// Método que cuando el jugador roba exclusivamente cartas de daño gracias a una carta inicial.
        /// </summary>
        public static void robarCartaDaño()
        {
            if (mano.Count < 6)
            {
                if (mazoMezclado.Count != 0)
                {
                    for (int i = 0; i < mazoMezclado.Count(); i++)
                    {
                        if (mazoMezclado[i].Tipo == 1) //Si la carta es de tipo 1 la roba del mazo.
                        {
                            posicionRobada = mano.Count;
                            mano.Add(mazoMezclado[i]);
                            mazoMezclado.RemoveAt(i);
                            break;
                        }
                    }
                }
                else
                {
                    if (mano.Count == 0)
                    {
                        mano.Clear();
                    }
                }
            }
        }
        /// <summary>
        /// Método que borra todas las cartas visualmente.
        /// </summary>
        private void eliminarMano()
        {
            for (int i = 0; i < fotosCartas.Count; i++)
            {
                this.Controls.Remove(fotosCartas[i]);
            }
        }
        private void Combate_Enter(object sender, EventArgs e)
        {
            eliminarMano();
            recargarMano();
        }
        /// <summary>
        /// Método utilizado para actualizar los datos del combate del jugador.
        /// </summary>
        private void pasarTurno()
        {
            GameProgress.jugador.ManaMaximo += 1;
            GameProgress.jugador.NumeroMana = GameProgress.jugador.ManaMaximo;
            textManaJugador.Text = GameProgress.jugador.NumeroMana.ToString();
            robarCarta();
            textContadorCartas.Text = mazoMezclado.Count().ToString();
            textContadorCartasEnemigo.Text = mazoEnemigo.Count().ToString();
        }
        private void btnFinalizarTurno_Click(object sender, EventArgs e)
        {
            pasarTurno();
            if (robarJugador)
            {
                controlComponentes(false);
                Task task = Task.Run(() => turnoEnemigo());
                task.GetAwaiter().OnCompleted(() => controlComponentes(true));
            }
        }
        /// <summary>
        /// Método en el que el jugador le pasa turno al enemigo. Es utilizado también para el robo de cartas del enemigo.
        /// </summary>
        private void turnoEnemigo()
        {
            if (turno == 1) //En esta condición siempre va a entrar el programa cada vez que sea el primer turno.
            {
                for (int i = 0; i <= 3; i++) //Roba 3 cartas de su mazo.
                {
                    manoEnemiga.Add(mazoEnemigo[0]);
                    mazoEnemigo.RemoveAt(0);
                }
                usarCartas();
            }
            else
            {
                enemigoReal.ManaMaximo += 1;
                enemigoReal.NumeroMana = enemigoReal.ManaMaximo;
                if (mazoEnemigo.Count > 0) //Si tiene cartas intentará usarlas segun su maná.
                {
                    manoEnemiga.Add(mazoEnemigo[0]);
                    mazoEnemigo.RemoveAt(0);
                    usarCartas();
                }
                else
                {
                    if (manoEnemiga.Count == 0) // Si el enemigo no tiene cartas en la mano ha perdido.
                    {
                        this.Invoke(new finalizarCombate(terminarCombate));
                    }
                    else
                    {
                        usarCartas();
                    }
                }
            }
        }
        /// <summary>
        /// Método que ejecuta la IA para usar las cartas posibles de su mano con aleatoriedad.
        /// </summary>
        private void usarCartas()
        {
            List<Card> cartasUsables = new List<Card>(); //Se vuelve a usar una copia de la lista.
            for (int i = 0; i < manoEnemiga.Count(); i++)
            {
                cartasUsables.Add(manoEnemiga[i]);
            }

            while (cartasUsables.Count != 0) //Si es distinto a 0 dicha lista saca una carta aleatoria del mazo.
            {
                Random r = new Random();
                int random = r.Next(0, cartasUsables.Count - 1);
                Card carta = cartasUsables[random];
                if (enemigoReal.NumeroMana >= carta.NumeroMana)
                {
                    enemigoReal.NumeroMana -= carta.NumeroMana;
                    if (carta.Tipo != 3) // Si la carta no es de tipo 3 (robar) se usa la carta.
                    {
                        carta.usarCarta(enemigoReal, GameProgress.jugador);
                    }
                    else // Si no, el jugador roba de su mazo y entrará en esta condición.
                    {
                        if (mazoEnemigo.Count > 0)
                        {
                            if (carta.Daño > 0) //Si la carta tiene efecto de robar de tu propio mazo.
                            {
                                for (int i = 0; i < carta.Daño; i++)
                                {
                                    if (mazoEnemigo.Count > 0 && manoEnemiga.Count + 1 <= 6)
                                    {
                                        manoEnemiga.Add(mazoEnemigo[0]);
                                        mazoEnemigo.RemoveAt(0);
                                    }
                                }
                            }
                        }
                        if (carta.Curacion > 0) //Si la carta tiene efecto de robar al contrario.
                        {
                            for (int i = 0; i < carta.Curacion; i++) 
                            {
                                if (mazoMezclado.Count > 0 && manoEnemiga.Count + 1 <= 6)
                                {
                                    manoEnemiga.Add(mazoMezclado[0]);
                                    mazoMezclado.RemoveAt(0);
                                }
                            }
                        }
                    }
                    manoEnemiga.Remove(carta);
                    this.Invoke(new cartaEnemiga(this.mostrarCarta), carta); //Se muestra la carta usada del enemigo en la interfaz.
                    Thread.Sleep(2000); // El tiempo que permanece la carta en la interfaz.
                    this.Invoke(new cartaEnemiga(this.borrarCarta), carta);
                    if (GameProgress.jugador.Vida <= 0)
                    {
                        MessageBox.Show("¡No te quedan fuerzas para continuar! El nivel se reiniciará...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                }
                cartasUsables.Remove(carta);
            }
        }
        /// <summary>
        /// Método utilizado cuando el jugador gana un combate.
        /// </summary>
        private void terminarCombate()
        {
            if (GameProgress.jugador.Nivel == 10) //Una vez que se complete el nivel 10 se reiniciará el 1.
            {
                GameProgress.jugador.Nivel = 1;
                MessageBox.Show("La demo termina aquí. Gracias por jugar :)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("¡Has ganado! Obtienes 30 de oro", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                repartirRecompensas();
                GameProgress.jugador.Nivel += 1;
                GameProgress.jugador.Dinero += 30;
            }
            SelectLevel mapa = new SelectLevel();
            mapa.Show();
            this.Close();
        }
        /// <summary>
        /// Método utlizado por el delegado para mostrar la carta que ha usado el enemigo y actualiza la interfaz.
        /// </summary>
        private void mostrarCarta(Card carta)
        {
            crearCarta(650, 50, carta, -1);
            try
            {
                progressBarEnemigo.Value = enemigoReal.Vida * 100 / enemigoReal.VidaMaxima;
                progressBarJugador.Value = GameProgress.jugador.Vida * 100 / GameProgress.jugador.VidaMaxima;
                textManaEnemigo.Text = enemigoReal.NumeroMana.ToString();
                lblVidaEnemigo.Text = enemigoReal.Vida + " / " + enemigoReal.VidaMaxima;
                lblVidaJugador.Text = GameProgress.jugador.Vida + " / " + GameProgress.jugador.VidaMaxima;
                textContadorCartas.Text = mazoMezclado.Count().ToString();
                textContadorCartasEnemigo.Text = mazoEnemigo.Count().ToString();
            }
            catch (ArgumentOutOfRangeException) //Excepción que controla que el ProgressBar no tenga un valor negativo.
            {
                progressBarEnemigo.Value = 0;
                progressBarJugador.Value = 0;
            }
        }
        /// <summary>
        /// Método que borra la carta visualmente que utiliza el enemigo.
        /// </summary>
        private void borrarCarta(Card carta)
        {
            this.Controls.Remove(fotosCartas[fotosCartas.Count - 1]);
            fotosCartas.RemoveAt(fotosCartas.Count - 1);
            if (GameProgress.jugador.Vida <= 0) //El jugador ha perdido por que se ha quedado sin vida.
            {
                SelectLevel mapa = new SelectLevel();
                mapa.Show();
                this.Close();
            }
            textContadorCartas.Text = mazoMezclado.Count().ToString();
            textContadorCartasEnemigo.Text = mazoEnemigo.Count().ToString();
        }
        /// <summary>
        /// Método que controla los elementos de la interfaz.
        /// </summary>
        private void controlComponentes(bool estado)
        {
            foreach (DamageCard carta in fotosCartas)
            {
                carta.Enabled = estado;
            }
            btnFinalizarTurno.Enabled = estado;
            if (estado)
            {
                turno++;
            }
        }
        /// <summary>
        /// Método que añade nuevas cartas al mazo al haber superado un nivel.
        /// </summary>
        private void repartirRecompensas()
        {
            switch (GameProgress.jugador.Nivel)
            {
                case 1:
                    break;
                case 2:
                    añadirCarta(6);

                    break;
                case 3:
                    break;
                case 4:
                    añadirCarta(18);
                    break;
                case 5:
                    break;
                case 6:
                    añadirCarta(19);
                    break;
                case 7:
                    break;
                case 8:
                    añadirCarta(12);
                    break;
                case 9:
                    break;
                case 10:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Método utilizado para entregar al jugador una carta según su id.
        /// </summary>
        /// <param name="id">int - id de la carta que será buscada en la base de datos</param>
        private void añadirCarta(int id)
        {
            Card carta = null;
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from carta where idCarta='" + id + "'"); 
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

                carta = new Card(idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                GameProgress.jugador.Mazo.Add(carta); 
                MessageBox.Show("Has obtenido una nueva carta: " + carta.NombreCarta, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            con.closeConnection();
        }
        /// <summary>
        /// Evento que guarda la partida al cerrar la aplicación desde el formulario.
        /// </summary>
        private void Combate_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryController.guardarBinario(GameProgress.jugador); 
        }
    }
}
