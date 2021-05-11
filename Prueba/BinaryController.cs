/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    /// <summary>
    /// Esta clase tiene como finalidad guardar y cargar los archivos binarios.
    /// </summary>
    class BinaryController
    {
        /// <summary>
        /// Método que guarda el progreso y los datos del jugador.
        /// </summary>
        public static void guardarBinario(Character jugador)
        {
            string DireccionArchivo = Environment.CurrentDirectory + @"\"+jugador.Nombre+".cfg"; 
            BinaryFormatter BF = new BinaryFormatter();
            FileStream archivo = File.OpenWrite(DireccionArchivo);
            BF.Serialize(archivo, jugador);
            archivo.Close();
        }
        /// <summary>
        /// Método que carga las partidas del jugador.
        /// </summary>
        public static bool cargarBinario(string direccion)
        {
            bool cargado = false;
            Character datosCargados;
            BinaryFormatter BF = new BinaryFormatter();
            FileStream Archivo = File.Open(direccion, FileMode.Open);
            try
            {
                datosCargados = (Character)BF.Deserialize(Archivo);
                GameProgress.jugador = datosCargados;
                cargado = true;
            }
            catch (Exception)
            {

            }
            Archivo.Close();
            return cargado;
        }
    }
}
