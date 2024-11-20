namespace Proyecto_Estructuras.Vista
{
    partial class Ventana_principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_principal));
            this.Boton_empezar = new System.Windows.Forms.Button();
            this.Boton_records = new System.Windows.Forms.Button();
            this.Titulo_principal = new System.Windows.Forms.Label();
            this.Check_facil = new System.Windows.Forms.CheckBox();
            this.Check_medio = new System.Windows.Forms.CheckBox();
            this.Check_dificil = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Boton_empezar
            // 
            this.Boton_empezar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Boton_empezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Boton_empezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_empezar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_empezar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Boton_empezar.Location = new System.Drawing.Point(323, 174);
            this.Boton_empezar.Name = "Boton_empezar";
            this.Boton_empezar.Size = new System.Drawing.Size(159, 61);
            this.Boton_empezar.TabIndex = 0;
            this.Boton_empezar.Text = "Empezar";
            this.Boton_empezar.UseVisualStyleBackColor = false;
            this.Boton_empezar.Click += new System.EventHandler(this.Boton_empezar_Click);
            // 
            // Boton_records
            // 
            this.Boton_records.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Boton_records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_records.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_records.Location = new System.Drawing.Point(356, 311);
            this.Boton_records.Name = "Boton_records";
            this.Boton_records.Size = new System.Drawing.Size(96, 39);
            this.Boton_records.TabIndex = 1;
            this.Boton_records.Text = "Records";
            this.Boton_records.UseVisualStyleBackColor = false;
            // 
            // Titulo_principal
            // 
            this.Titulo_principal.AutoSize = true;
            this.Titulo_principal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Titulo_principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo_principal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Titulo_principal.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_principal.Location = new System.Drawing.Point(140, 36);
            this.Titulo_principal.Name = "Titulo_principal";
            this.Titulo_principal.Size = new System.Drawing.Size(492, 35);
            this.Titulo_principal.TabIndex = 2;
            this.Titulo_principal.Text = "Juego del Ahorcado del Grupo #4";
            this.Titulo_principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Check_facil
            // 
            this.Check_facil.Appearance = System.Windows.Forms.Appearance.Button;
            this.Check_facil.AutoSize = true;
            this.Check_facil.BackColor = System.Drawing.Color.Transparent;
            this.Check_facil.Checked = true;
            this.Check_facil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_facil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_facil.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_facil.Location = new System.Drawing.Point(75, 170);
            this.Check_facil.Name = "Check_facil";
            this.Check_facil.Size = new System.Drawing.Size(53, 27);
            this.Check_facil.TabIndex = 3;
            this.Check_facil.Text = "Fácil";
            this.Check_facil.UseVisualStyleBackColor = false;
            // 
            // Check_medio
            // 
            this.Check_medio.Appearance = System.Windows.Forms.Appearance.Button;
            this.Check_medio.AutoSize = true;
            this.Check_medio.BackColor = System.Drawing.Color.Transparent;
            this.Check_medio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_medio.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_medio.Location = new System.Drawing.Point(75, 208);
            this.Check_medio.Name = "Check_medio";
            this.Check_medio.Size = new System.Drawing.Size(61, 27);
            this.Check_medio.TabIndex = 4;
            this.Check_medio.Text = "Medio";
            this.Check_medio.UseVisualStyleBackColor = false;
            // 
            // Check_dificil
            // 
            this.Check_dificil.Appearance = System.Windows.Forms.Appearance.Button;
            this.Check_dificil.AutoSize = true;
            this.Check_dificil.BackColor = System.Drawing.Color.Transparent;
            this.Check_dificil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Check_dificil.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_dificil.Location = new System.Drawing.Point(75, 245);
            this.Check_dificil.Name = "Check_dificil";
            this.Check_dificil.Size = new System.Drawing.Size(65, 27);
            this.Check_dificil.TabIndex = 5;
            this.Check_dificil.Text = "Dificil";
            this.Check_dificil.UseVisualStyleBackColor = false;
            // 
            // Ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.Check_dificil);
            this.Controls.Add(this.Check_medio);
            this.Controls.Add(this.Check_facil);
            this.Controls.Add(this.Titulo_principal);
            this.Controls.Add(this.Boton_records);
            this.Controls.Add(this.Boton_empezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ventana_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego del ahorcado";
            this.Load += new System.EventHandler(this.Pantalla_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_empezar;
        private System.Windows.Forms.Button Boton_records;
        private System.Windows.Forms.Label Titulo_principal;
        private System.Windows.Forms.CheckBox Check_facil;
        private System.Windows.Forms.CheckBox Check_medio;
        private System.Windows.Forms.CheckBox Check_dificil;
    }
}