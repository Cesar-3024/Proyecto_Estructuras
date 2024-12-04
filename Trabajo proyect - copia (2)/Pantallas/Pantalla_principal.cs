using Proyecto_Estructuras.Pantallas;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_Estructuras.Vista
{
    public partial class Ventana_principal : Form
    {
        public Ventana_principal()
        {
            InitializeComponent();
        }

        string[] Niveles_disponibles = { "Fácil", "Medio", "Difícil" };

        private void Pantalla_principal_Load(object sender, EventArgs e)
        {
            Boton_empezar.Enabled = false;
            Control_dificultad();
        }

        //Código para setear la dificultad en el combo box

        private void Control_dificultad()
        {
            for (int i = 0; i < Niveles_disponibles.Length; i++)
            {
                Selector_dificultad.Items.Add(Niveles_disponibles[i]);
            }
            Selector_dificultad.SelectedIndex = 0;
        }

        //Código para iniciar pantallas de juego y registros

        private void Boton_empezar_Click(object sender, EventArgs e)
        {
            Pantalla_juego Pantalla_Juego_actual = new Pantalla_juego(Selector_dificultad.SelectedIndex, Nombre.Text);
            Pantalla_Juego_actual.ShowDialog();
        }

        private void Boton_records_Click(object sender, EventArgs e)
        {
         
        }
        //Código para validar que el nombre ingresado sea correcto

        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            ValidarEntradas();
        }

        private void ValidarEntradas()
        {
            string patron = @"^[a-zA-Z\s]+$";
            bool nombreValido = !string.IsNullOrWhiteSpace(Nombre.Text) && Regex.IsMatch(Nombre.Text, patron);

            if (nombreValido)
            {
                errorProvider1.SetError(Nombre, "");
            }
            else
            {
                errorProvider1.SetError(Nombre, "El nombre solo debe contener letras y espacios");
            }

            Boton_empezar.Enabled = nombreValido;
        }

        //Código para quitar el texto por defecto cuando se selecciona la casilla nombre

        private void Nombre_Click(object sender, EventArgs e)
        {
            Nombre.Text = string.Empty;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BoxJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}