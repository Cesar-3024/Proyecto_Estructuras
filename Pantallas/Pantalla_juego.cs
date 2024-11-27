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
                    // La lista está vacía, el nuevo nodo es el primero
                    Cabeza = nuevoNodo;
                    Cola = nuevoNodo;
                }
                else
                {
                    // Añadir al final de la lista
                    Cola.Siguiente = nuevoNodo;
                    nuevoNodo.Anterior = Cola;
                    Cola = nuevoNodo;
                }
            }
        }

        public Pantalla_juego(int Dificultad_seleccionada, string nombre_jugador)
        {
            InitializeComponent();
            Dificultad = Dificultad_seleccionada;
            Nombre = nombre_jugador;
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

            Cantidad_campos();
            Lector_asignar_palabras();
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

        private void Lector_asignar_palabras() 
        {
            String Set_palabras = "";
            Lista_palabras_juego Lista_palabras = new Lista_palabras_juego();
            String palabra = "";
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
                    Lista_palabras.Agregar(palabra);
                }
            }

            Nodo_palabras_juego pivote = Lista_palabras.Cabeza;
            
            for (int i = 0; i < pivote.Valor.Length; i++)
            {
                Label label = this.Controls.Find($"Campo_{i + 1}", true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = pivote.Valor[i].ToString(); // Asignar la letra correspondiente
                }
            }
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

        private void Boton_confirmar_Click(object sender, EventArgs e)
        {
            Letra_seleccionada = Letra_ingresada.Text;
            Letra_ingresada.Text = string.Empty;
        }
    }
}