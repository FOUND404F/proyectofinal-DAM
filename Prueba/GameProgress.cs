/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Prueba
{
    /// <summary>
    /// Esta clase contiene los datos del jugador.
    /// </summary>
    class GameProgress
    {
        //Se utiliza una variable estática para acceder a el desde cualquier zona.
        public static Character jugador = new Character(); 

        public Character Jugador { get => jugador; set => jugador = value; }

        public GameProgress(Character jugador)
        {
            Jugador = jugador;
        }
    }
}
