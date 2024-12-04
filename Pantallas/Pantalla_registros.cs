using System;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Estructuras
{
    public partial class Pantalla_registros : Form
    {
        public Pantalla_registros()
        {
            InitializeComponent();
        }

        private void Pantalla_registros_Load(object sender, EventArgs e)
        {
        }

        private void Boton_menú_registros_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
