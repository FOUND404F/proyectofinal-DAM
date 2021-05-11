using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{

    public class DamageCard : UserControlCard
    {
        public DamageCard(string nombre, string descripcion, int mana, int tipo, int posicionMano) : base(nombre, descripcion, mana, tipo, posicionMano)
        { }
        //Método que realiza la carta cuando es soltada en la interfaz.
        public override void hacerFuncion()
        {
            int x = 100;
            int y = 285;
            this.recibirPosicionOriginal(x * (posicionMano + 1), y);
            Card cartaUsada = Fight.mano[posicionMano];
            if (GameProgress.jugador.NumeroMana >= cartaUsada.NumeroMana)
            {
                if (cartaUsada.Tipo == 3)
                {
                    if (Fight.mano.Count + cartaUsada.Daño <= 6 || Fight.mano.Count + cartaUsada.Curacion <= 6)
                    {
                        Fight.fotosCartas.RemoveAt(posicionMano);
                        Fight.mano.RemoveAt(posicionMano);
                        GameProgress.jugador.NumeroMana -= cartaUsada.NumeroMana;
                        cartaUsada.usarCarta(GameProgress.jugador, Fight.enemigoReal);
                        this.Visible = false;
                        this.Dispose();
                    }
                }
                else
                {
                    try
                    {
                        GameProgress.jugador.NumeroMana -= cartaUsada.NumeroMana;
                        cartaUsada.usarCarta(GameProgress.jugador, Fight.enemigoReal);
                        Fight.fotosCartas.RemoveAt(posicionMano);
                        Fight.mano.RemoveAt(posicionMano);
                        this.Visible = false;
                        this.Dispose();
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        //Fin del combate
                    }
                }
            }
        }
    }
}
