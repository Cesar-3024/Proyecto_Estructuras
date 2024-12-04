using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace Proyecto_Estructuras.Pantallas
{
    public partial class Pantalla_juego : Form
    {
        public int intentos;
        public int tiempo_restante;
        public int Dificultad;
        public int corazones = 6;
        public string Nombre;
        public string Letra_seleccionada;
        public int Puntuacion;

        private Jugador jugador;
        private string palabraActual;
        private Lista_palabras_juego listaPalabras;
        private Nodo_palabras_juego nodoActual;
        private PictureBox pbVidas;  // PictureBox para mostrar las vidas

        public class Nodo_palabras_juego
        {
            public string Valor;
            public Nodo_palabras_juego Siguiente;
            public Nodo_palabras_juego Anterior;

            public Nodo_palabras_juego(string valor)
            {
                Valor = valor;
                Siguiente = null;
                Anterior = null;
            }
        }

        public class Lista_palabras_juego
        {
            public Nodo_palabras_juego Cabeza;
            public Nodo_palabras_juego Cola;

            public void Agregar(string valor)
            {
                Nodo_palabras_juego nuevoNodo = new Nodo_palabras_juego(valor);

                if (Cabeza == null)
                {
                    Cabeza = nuevoNodo;
                    Cola = nuevoNodo;
                }
                else
                {
                    Cola.Siguiente = nuevoNodo;
                    nuevoNodo.Anterior = Cola;
                    Cola = nuevoNodo;
                }
            }
        }

        public class NodoJugador
        {
            public Jugador Valor;
            public NodoJugador Siguiente;

            public NodoJugador(Jugador valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        public Pantalla_juego(int Dificultad_seleccionada, string nombre_jugador)
        {
            InitializeComponent();
            Dificultad = Dificultad_seleccionada;
            Nombre = nombre_jugador;
            jugador = new Jugador(nombre_jugador, 0);
            InicializarPictureBox();
        }
        //Picture Box donde se muestra el personaje, solo es visible durante partida
        internal void InicializarPictureBox()
        {
            pbVidas = new PictureBox
            {
                Location = new Point(15, 7),
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            this.Controls.Add(pbVidas);
            ActualizarPictureBox();
        }
        //Actualiza la imagen del muñeco durante la partida
        internal void ActualizarPictureBox()
        {
            switch (corazones)
            {
                case 6:
                    pbVidas.Image = Properties.Resources.Segunda_pierna;
                    break;
                case 5:
                    pbVidas.Image = Properties.Resources.Primera_pierna;
                    break;
                case 4:
                    pbVidas.Image = Properties.Resources.Segundo_brazo;
                    break;
                case 3:
                    pbVidas.Image = Properties.Resources.Primer_brazo;
                    break;
                case 2:
                    pbVidas.Image = Properties.Resources.Cuerpo;
                    break;
                case 1:
                    pbVidas.Image = Properties.Resources.Cabeza;
                    break;
                case 0:
                    pbVidas.Image = Properties.Resources.Base;
                    break;
                default:
                    pbVidas.Image = null;
                    break;
            }
        }
        internal void Pantalla_juego_Load(object sender, EventArgs e)
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

            ActualizarTemporizadorLabel();
            Temporizador_juego.Tick += TemporizadorJuego_Tick;
            Temporizador_juego.Start();

            Cantidad_campos();
            Lector_asignar_palabras();
            ActualizarLabelVidas(); // Actualiza las vidas
            MostrarPista(); // Mostrar pista al inicio del juego
        }

        internal void Cantidad_campos()
        {
            switch (Dificultad)
            {
                case 0:
                    Campo_6.Visible = false;
                    Campo_7.Visible = false;
                    Campo_8.Visible = false;
                    Campo_9.Visible = false;
                    break;
                case 1:
                    Campo_6.Visible = true;
                    Campo_7.Visible = true;
                    Campo_8.Visible = false;
                    Campo_9.Visible = false;
                    break;
                case 2:
                    Campo_6.Visible = true;
                    Campo_7.Visible = true;
                    Campo_8.Visible = true;
                    Campo_9.Visible = true;
                    break;
            }
        }

        internal void Lector_asignar_palabras()
        {
            string Set_palabras = "";
            listaPalabras = new Lista_palabras_juego();
            string palabra = "";
            switch (Dificultad)
            {
                case 0:
                    Set_palabras = Properties.Resources.Palabras_faciles;
                    break;
                case 1:
                    Set_palabras = Properties.Resources.Palabras_medias;
                    break;
                case 2:
                    Set_palabras = Properties.Resources.Palabras_dificiles;
                    break;
            }

            using (StringReader reader = new StringReader(Set_palabras))
            {
                while ((palabra = reader.ReadLine()) != null)
                {
                    listaPalabras.Agregar(palabra);
                }
            }

            nodoActual = listaPalabras.Cabeza;
            palabraActual = nodoActual.Valor;

            MostrarPalabraActual();
        }
        internal void MostrarPalabraActual()
        {
            for (int i = 0; i < palabraActual.Length; i++)
            {
                Label label = this.Controls.Find($"Campo_{i + 1}", true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = "_";
                }
            }
        }

        internal void TemporizadorJuego_Tick(object sender, EventArgs e)
        {
            if (tiempo_restante > 0)
            {
                tiempo_restante--;
                ActualizarTemporizadorLabel();
            }
            else
            {
                Temporizador_juego.Stop();
                MessageBox.Show("¡Tiempo terminado!", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        internal void ActualizarTemporizadorLabel()
        {
            int minutos = tiempo_restante / 60;
            int segundos = tiempo_restante % 60;
            Temporizador_muestra.Text = $"{minutos:D2}:{segundos:D2}";
        }

        internal void Boton_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void Boton_confirmar_Click(object sender, EventArgs e)
        {
            Letra_seleccionada = Letra_ingresada.Text;
            ValidarLetra(Letra_seleccionada);
            Letra_ingresada.Text = string.Empty;
        }

        internal void ValidarLetra(string letra)
        {
            bool letraEncontrada = false;
            for (int i = 0; i < palabraActual.Length; i++)
            {
                if (palabraActual[i].ToString().Equals(letra, StringComparison.OrdinalIgnoreCase))
                {
                    letraEncontrada = true;
                    Puntuacion++;
                    Label label = this.Controls.Find($"Campo_{i + 1}", true).FirstOrDefault() as Label;
                    if (label != null)
                    {
                        label.Text = letra;
                        label.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }

            if (!letraEncontrada)
            {
                intentos++;
                corazones--;
                MessageBox.Show("Letra incorrecta. Intenta de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActualizarLabelVidas(); // Actualiza las vidas cada vez que se comete un error
                ActualizarPictureBox(); // Actualiza la imagen del PictureBox

                if (corazones <= 0)
                {
                    MessageBox.Show("¡Has perdido todos tus corazones! Fin del juego.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else if (Puntuacion == palabraActual.Length)
            {
                MessageBox.Show("¡Palabra completada!", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AsignarNuevaPalabra();
            }

            Puntos.Text = Puntuacion.ToString();
        }
        internal void AsignarNuevaPalabra()
        {
            if (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                palabraActual = nodoActual.Valor;
                corazones = 6; // Restablece las vidas
                intentos = 0; // Restablece los intentos
                MostrarPalabraActual();
                ActualizarLabelVidas();
                ActualizarPictureBox(); // Actualiza la imagen del PictureBox al restablecer las vidas
                MostrarPista(); // Mostrar pista para la nueva palabra, solo muestra cuantas letras contiene xd
            }
            else
            {
                MessageBox.Show("¡Felicitaciones! Has completado todas las palabras.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        internal void MostrarPista()
        {
            string pista = ObtenerPista(palabraActual);
            MessageBox.Show($"Pista: {pista}", "Pista de Palabra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal string ObtenerPista(string palabra)
        {
            // Pueden modificarla para mostrar una mejor palabra
            return $"La palabra tiene {palabra.Length} letras.";
        }

        internal void ActualizarLabelVidas()
        {
            LabelVidas.Text = $" {corazones}";
        }
        //Estas llamadas no realizan ninguna accion, sin embargo no las eliminen
        internal void Puntos_Click(object sender, EventArgs e) { }

        internal void PuntosJugador_TextChanged(object sender, EventArgs e) { }
    }
}








