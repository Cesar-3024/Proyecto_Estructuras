using Proyecto_Estructuras.Pantallas;
using Proyecto_Estructuras.Vista;

namespace Proyecto_Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ventana_principal Inicio_juego = new Ventana_principal();
            Inicio_juego.ShowDialog();
        }
    }
}
