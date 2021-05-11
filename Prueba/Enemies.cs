/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prueba
{
    /// <summary>
    /// En esta clase se cargan los datos de los enemigos y de sus mazos.
    /// </summary>
    class Enemies
    {
        /// <summary>
        /// Método donde se cargan los datos de los enemigos según su id en la base de datos.
        /// </summary>
        public static Character crearEnemigo(int idEnemigo)
        {
            int idMazoEnemigo = 0;
            Character enemigo = new Character();
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select * from enemigo where idEnemigo = " + idEnemigo + ""); 
            MySqlDataReader reader = con.executeSelect();
            if (reader.HasRows)
            {
                reader.Read();
                enemigo.Nombre = reader.GetString(1);
                enemigo.Vida = reader.GetInt32(2);
                enemigo.VidaMaxima = enemigo.Vida;
                enemigo.NumeroMana = reader.GetInt32(3);
                idMazoEnemigo = reader.GetInt32(4);
            }
            enemigo.Mazo = crearMazo(idMazoEnemigo);
            con.closeConnection();
            return enemigo;
        }
        /// <summary>
        /// Método donde se cargan los datos de los mazos enemigos consultando la base de datos.
        /// </summary>
        /// <param name="idMazo"> int - Se refiere al id que lleva el mazo</param>
        public static List<Card> crearMazo(int idMazo)
        {
            int idCarta;
            string nombreCarta;
            string descripcionCarta;
            int numeroMana;
            int tipo;
            int daño;
            int curacion;
            bool cartaTemporal;
            int precio;
            int cantidad;
            List<Card> mazoEnemigo = new List<Card>();
            ConnectionBD con = new ConnectionBD("proyectofinal");
            con.prepareCommand("select c.idCarta, c.nombreCarta, c.descripcionCarta, c.numeroMana," +
                " c.tipo, c.daño, c.curacion, c.cartaTemporal, c.precio, m.cantidadCarta from carta as c, mazos as m " +
                "where m.idMazo = "+idMazo+" and m.idCarta = c.idCarta");
            MySqlDataReader reader = con.executeSelect();

            while (reader.Read())
            {
                idCarta = reader.GetInt32(0);
                nombreCarta = reader.GetString(1);
                descripcionCarta = reader.GetString(2);
                numeroMana = reader.GetInt32(3);
                tipo = reader.GetInt32(4);
                daño = reader.GetInt16(5);
                curacion = reader.GetInt16(6);
                cartaTemporal = reader.GetBoolean(7);
                precio = reader.GetInt16(8);
                cantidad = reader.GetInt32(9);
                Card carta = new Card(idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                    daño, curacion, precio, cartaTemporal);
                for(int i = 0; i < cantidad; i++)
                {
                    mazoEnemigo.Add(carta);
                }
            }
            con.closeConnection();
            return mazoEnemigo;
        }
    }
}
