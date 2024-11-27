using Proyecto_Estructuras.Vista;
using System;
using System.Windows.Forms;

namespace Proyecto_Estructuras.Pantallas
{
    public partial class Pantalla_juego : Form
    {
        int intentos;
        int tiempo_restante;
        int Dificultad;

        public Pantalla_juego(int Dificultad_seleccionada)
        {
            InitializeComponent();
            Dificultad = Dificultad_seleccionada;
        }


        private void Pantalla_juego_Load(object sender, EventArgs e)
        {
            switch (Dificultad)
            {
                case 0:
                    tiempo_restante = 7 * 60;
                    break;
                case 1:
                    tiempo_restante = 5 * 60;
                    break;
                case 2:
                    tiempo_restante = 3 * 60;
                    break;
            }

            // Muestra el tiempo inicial en el Label
            ActualizarTemporizadorLabel();

            // Inicia el temporizador
            Temporizador_juego.Tick += TemporizadorJuego_Tick;
            Temporizador_juego.Start();
        }

        //Código que actualiza el temporizador de la pantalla de juego

        private void TemporizadorJuego_Tick(object sender, EventArgs e)
        {
            if (tiempo_restante > 0)
            {
                tiempo_restante--; // Resta un segundo
                ActualizarTemporizadorLabel();
            }
            else
            {
                Temporizador_juego.Stop(); // Detiene el temporizador
                MessageBox.Show("¡Tiempo terminado!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra la pantalla actual (opcional)
            }
        }

        private void ActualizarTemporizadorLabel()
        {
            int minutos = tiempo_restante / 60;
            int segundos = tiempo_restante % 60;
            Temporizador_muestra.Text = $"{minutos:D2}:{segundos:D2}"; // Formato MM:SS
        }

        //Código que cierra la pantalla de juego

        private void Boton_menu_Click(object sender, EventArgs e)
        {
            if (intentos == 0 && Puntos.Text == "0")
            {
                this.Close();
            }
            else
            {
                //Aquí se debe implementar una función para almacenar la partida en regitro y cerrar la ventana
            }
        }

    }
}