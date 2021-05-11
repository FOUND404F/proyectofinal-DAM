/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using MySql.Data.MySqlClient;
using Prueba.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prueba
{
    /// <summary>
    /// Esta clase tiene como finalidad conectar con la base de datos.
    /// </summary>
    internal class ConnectionBD
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public ConnectionBD(string database)
        {
            string connectionString = Settings.Default.colectionString + database;
            connection = new MySqlConnection(connectionString);
            command = connection.CreateCommand();
        }
        public void prepareCommand(string strCommand)
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandTimeout = 60;
                connection.Open();
                command.CommandText = strCommand;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void executeCommand()
        {
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public MySqlDataReader executeSelect()
        {
            MySqlDataReader mySqlDataReader = null;
            try
            {
                mySqlDataReader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return mySqlDataReader;
        }
        internal MySqlDataReader ddl(int query)
        {
            throw new NotImplementedException();
        }
        public object executeScalar()
        {
            object o = null;
            try
            {
                o = command.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return o;
        }
        public void closeConnection()
        {
            try
            {
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public MySqlCommand getCommand()
        {
            return command;
        }
        public static List<Card> RecuperarCarta()
        {
            List<Card> cartas = new List<Card>();

            ConnectionBD conexion = new ConnectionBD("proyectofinal");

            conexion.prepareCommand("select * from carta");
            MySqlDataReader reader = conexion.executeSelect();

            if (reader.HasRows)
            {
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
                    

                    Card carta = new Card (idCarta, nombreCarta, tipo, descripcionCarta, numeroMana,
                        daño, curacion, precio, cartaTemporal);
                    cartas.Add(carta);
                }
            }
            conexion.closeConnection();
            return cartas;
        }
        public int dml(string query)
        {
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);
            int n = commandDatabase.ExecuteNonQuery();
            return n;
        }
    }
}
