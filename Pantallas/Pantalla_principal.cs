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
            Boton_empezar.Enabled = false;
        }

        private void Boton_empezar_Click(object sender, EventArgs e)
        {
            if (Check_facil.CheckState == CheckState.Checked
                || Check_medio.CheckState == CheckState.Checked
                || Check_dificil.CheckState == CheckState.Checked)
            {
                errorProvider1.SetError(Boton_empezar, "");
            }
            else
            {
                errorProvider1.SetError(Boton_empezar, "Debe seleccionar una dificultad");
            }
        }

        private void Control_dificultad() 
        {
            if (Check_facil.CheckState == CheckState.Checked)
            {
                Check_medio.CheckState = CheckState.Unchecked;
                Check_dificil.CheckState = CheckState.Unchecked;
                Boton_empezar.Enabled = true;
            }
            else if (Check_medio.CheckState == CheckState.Checked)
            {
                Check_facil.CheckState = CheckState.Unchecked;
                Check_dificil.CheckState = CheckState.Unchecked;
                Boton_empezar.Enabled = true;
            }
            else if (Check_dificil.CheckState == CheckState.Checked)
            {
                Check_medio.CheckState = CheckState.Unchecked;
                Check_facil.CheckState = CheckState.Unchecked;
                Boton_empezar.Enabled = true;
            }
        }

        private void Check_facil_CheckedChanged(object sender, EventArgs e)
        {
            Control_dificultad();
        }

        private void Check_medio_CheckedChanged(object sender, EventArgs e)
        {
            Control_dificultad();
        }

        private void Check_dificil_CheckedChanged(object sender, EventArgs e)
        {
            Control_dificultad();
        }
    }
}
