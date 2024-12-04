using Proyecto_Estructuras.Vista;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Estructuras.Pantallas
{
    public partial class Pantalla_juego : Form
    {
        int intentos;
        int tiempo_restante;
        int Dificultad;
        String Nombre;
        string Letra_seleccionada;
        public int corazones = 6;
        private Lista_palabras_juego listaPalabras;
        private string palabraActual;
        private Nodo_palabras_juego nodoActual;
        public int Puntuacion;
        private Pantalla_registros pantallaRegistros;
        private Pila_letras_usadas letras_ingresadas = new Pila_letras_usadas();

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

        public class Nodo_letras_usadas
        {
            public string Valor;
            public Nodo_letras_usadas Siguiente;

            public Nodo_letras_usadas(string valor)
            {
                Valor = valor;
                Siguiente = null;
            }
        }

        public class Pila_letras_usadas
        {
            public Nodo_letras_usadas Tope;

            public void Apilar(string letra)
            {
                Nodo_letras_usadas nuevoNodo = new Nodo_letras_usadas(letra);
                nuevoNodo.Siguiente = Tope;
                Tope = nuevoNodo;
            }
        }

        public Pantalla_juego(int Dificultad_seleccionada, string nombre_jugador, Pantalla_registros pantallaRegistros)
        {
            InitializeComponent();
            Dificultad = Dificultad_seleccionada;
            Nombre = nombre_jugador;
            Actualizarimagenahorcado();
            this.pantallaRegistros = pantallaRegistros;
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

            ActualizarTemporizadorLabel();
            Temporizador_juego.Tick += TemporizadorJuego_Tick;
            Temporizador_juego.Start();

            Cantidad_campos();
            Lector_asignar_palabras();
            ActualizarVidas();
        }

        //código para actualizar la imagen del ahorcado

        internal void Actualizarimagenahorcado()
        {
            switch (corazones)
            {
                case 6:
                    Imagen_ahorcado.Image = Properties.Resources.Base;
                    break;
                case 5:
                    Imagen_ahorcado.Image = Properties.Resources.Cabeza;
                    break;
                case 4:
                    Imagen_ahorcado.Image = Properties.Resources.Cuerpo;
                    break;
                case 3:
                    Imagen_ahorcado.Image = Properties.Resources.Primer_brazo;
                    break;
                case 2:
                    Imagen_ahorcado.Image = Properties.Resources.Segundo_brazo;
                    break;
                case 1:
                    Imagen_ahorcado.Image = Properties.Resources.Primera_pierna;
                    break;
                case 0:
                    Imagen_ahorcado.Image = Properties.Resources.Segunda_pierna;
                    break;
            }
        }

        //Código para asignar la cantidad de campos necesarios según la dificultad del juego

        private void Cantidad_campos()
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

        //Código para asignar las palabras del juego a una lista doble

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

        //Código que actualiza el temporizador de la pantalla de juego

        private void TemporizadorJuego_Tick(object sender, EventArgs e)
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

        private void ActualizarTemporizadorLabel()
        {
            int minutos = tiempo_restante / 60;
            int segundos = tiempo_restante % 60;
            Temporizador_muestra.Text = $"{minutos:D2}:{segundos:D2}";
        }

        //código que actualiza las vidas

        internal void ActualizarVidas()
        {
            switch (corazones)
            {
                case 5:
                    Vida_1.Image = Properties.Resources.esqueleto;
                    break;
                case 4:
                    Vida_2.Image = Properties.Resources.esqueleto;
                    break;
                case 3:
                    Vida_3.Image = Properties.Resources.esqueleto;
                    break;
                case 2:
                    Vida_4.Image = Properties.Resources.esqueleto;
                    break;
                case 1:
                    Vida_5.Image = Properties.Resources.esqueleto;
                    break;
                case 0:
                    Vida_6.Image = Properties.Resources.esqueleto;
                    break;
                default:
                    Vida_1.Image = Properties.Resources.Vida;
                    Vida_2.Image = Properties.Resources.Vida;
                    Vida_3.Image = Properties.Resources.Vida;
                    Vida_4.Image = Properties.Resources.Vida;
                    Vida_5.Image = Properties.Resources.Vida;
                    Vida_6.Image = Properties.Resources.Vida;
                    break;
            }
        }

        //Código que cierra la pantalla de juego

        private void Boton_menu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                GuardarRegistro(Nombre, Puntuacion, Dificultad);
                this.Close();
            }
        }

        private void Boton_confirmar_Click(object sender, EventArgs e)
        {
            Letra_seleccionada = Letra_ingresada.Text;
            if (LetrasYaIngresada(Letra_seleccionada))
            {
                MessageBox.Show("¡Ya ingresaste esta letra!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                letras_ingresadas.Apilar(Letra_seleccionada);

                ActualizarLetrasIngresadas();

                ValidarLetra(Letra_seleccionada);
            }

            Letra_ingresada.Text = string.Empty;
        }

        //Código que valida las letras en el juego

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
                ActualizarVidas();
                Actualizarimagenahorcado();

                if (corazones <= 0)
                {
                    MessageBox.Show("¡Has perdido todos tus corazones! Fin del juego.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GuardarRegistro(Nombre, Puntuacion, Dificultad);
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

        //código para actualizar las letras ya usadas

        private void ActualizarLetrasIngresadas()
        {
            Letras_usadas.Items.Clear();

            Nodo_letras_usadas nodoActual = letras_ingresadas.Tope;
            while (nodoActual != null)
            {
                Letras_usadas.Items.Add(nodoActual.Valor);
                nodoActual = nodoActual.Siguiente;
            }
        }

        private bool LetrasYaIngresada(string letra)
        {
            Nodo_letras_usadas nodoActual = letras_ingresadas.Tope;
            while (nodoActual != null)
            {
                if (nodoActual.Valor.Equals(letra, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                nodoActual = nodoActual.Siguiente;
            }

            return false;
        }

        //código que asigna una nueva palabra a adivinar

        internal void AsignarNuevaPalabra()
        {
            if (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
                palabraActual = nodoActual.Valor;
                corazones = 6;
                intentos = 0;
                Letras_usadas.Items.Clear();
                letras_ingresadas.Tope = null;
                MostrarPalabraActual();
                ActualizarVidas();
                Actualizarimagenahorcado();
            }
            else
            {
                MessageBox.Show("¡Felicitaciones! Has completado todas las palabras.", "Fin del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GuardarRegistro(Nombre, Puntuacion, Dificultad);
                this.Close();
            }
        }

        public void GuardarRegistro(string nombreJugador, int puntuacion, int dificultad)
        {
            if (pantallaRegistros != null)
            {
                switch (dificultad)
                {
                    case 0:
                        pantallaRegistros.Lista_faciles.Items.Add($"{nombreJugador} - Puntuación: {puntuacion}");
                        break;
                    case 1:
                        pantallaRegistros.Lista_medios.Items.Add($"{nombreJugador} - Puntuación: {puntuacion}");
                        break;
                    case 2:
                        pantallaRegistros.Lista_dificiles.Items.Add($"{nombreJugador} - Puntuación: {puntuacion}");
                        break;
                }
            }
        }
    }
}