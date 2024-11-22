using Proyecto_Estructuras.Pantallas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Estructuras.Vista
{
    public partial class Ventana_principal : Form
    {
        public Ventana_principal()
        {
            InitializeComponent();
        }

        string[] Niveles_disponibles = {"Fácil", "Medio", "Difícil"};

        private void Pantalla_principal_Load(object sender, EventArgs e)
        {
            Boton_empezar.Enabled = false;
        }

        private void Boton_empezar_Click(object sender, EventArgs e)
        {
            using (Pantalla_juego nueva_ventana_juego = new Pantalla_juego(Nombre.Text))
                nueva_ventana_juego.ShowDialog();
        }

        private void Control_dificultad() 
        {
            
        }

        private void Boton_records_Click(object sender, EventArgs e)
        {
            using (Pantalla_registros nueva_ventana_registros = new Pantalla_registros())
                nueva_ventana_registros.ShowDialog();
        }
    }
}
