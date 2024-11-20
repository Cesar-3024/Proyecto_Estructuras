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

        private void Pantalla_principal_Load(object sender, EventArgs e)
        {
            Control_dificultad();
        }

        private void Boton_empezar_Click(object sender, EventArgs e)
        {

        }

        private void Control_dificultad() 
        {
            if (Check_facil.CheckState == CheckState.Checked)
            {
                Check_medio.CheckState = CheckState.Unchecked;
                Check_dificil.CheckState = CheckState.Unchecked;
            }
            else if (Check_medio.CheckState == CheckState.Checked)
            {
                Check_facil.CheckState = CheckState.Unchecked;
                Check_dificil.CheckState = CheckState.Unchecked;
            }
            else {
                Check_medio.CheckState = CheckState.Unchecked;
                Check_facil.CheckState = CheckState.Unchecked;
                Check_dificil.CheckState = CheckState.Checked;
            }
        }
    }
}
