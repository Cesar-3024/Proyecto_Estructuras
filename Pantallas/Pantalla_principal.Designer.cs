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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_principal));
            this.Boton_empezar = new System.Windows.Forms.Button();
            this.Boton_records = new System.Windows.Forms.Button();
            this.Titulo_principal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nombre = new System.Windows.Forms.Label();
            this.Selector_dificultad = new System.Windows.Forms.ComboBox();
            this.Dificultad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_empezar
            // 
            this.Boton_empezar.BackColor = System.Drawing.Color.Snow;
            this.Boton_empezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Boton_empezar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_empezar.Enabled = false;
            this.Boton_empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_empezar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_empezar.ForeColor = System.Drawing.Color.Black;
            this.Boton_empezar.Location = new System.Drawing.Point(200, 168);
            this.Boton_empezar.Name = "Boton_empezar";
            this.Boton_empezar.Size = new System.Drawing.Size(159, 61);
            this.Boton_empezar.TabIndex = 0;
            this.Boton_empezar.Text = "Empezar";
            this.Boton_empezar.UseVisualStyleBackColor = false;
            this.Boton_empezar.Click += new System.EventHandler(this.Boton_empezar_Click);
            // 
            // Boton_records
            // 
            this.Boton_records.BackColor = System.Drawing.Color.Snow;
            this.Boton_records.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Boton_records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_records.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_records.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_records.Location = new System.Drawing.Point(233, 269);
            this.Boton_records.Name = "Boton_records";
            this.Boton_records.Size = new System.Drawing.Size(96, 39);
            this.Boton_records.TabIndex = 1;
            this.Boton_records.Text = "Registros";
            this.Boton_records.UseVisualStyleBackColor = false;
            this.Boton_records.Click += new System.EventHandler(this.Boton_records_Click);
            // 
            // Titulo_principal
            // 
            this.Titulo_principal.AutoSize = true;
            this.Titulo_principal.BackColor = System.Drawing.Color.Transparent;
            this.Titulo_principal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Titulo_principal.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_principal.ForeColor = System.Drawing.Color.Snow;
            this.Titulo_principal.Location = new System.Drawing.Point(44, 22);
            this.Titulo_principal.Name = "Titulo_principal";
            this.Titulo_principal.Size = new System.Drawing.Size(490, 33);
            this.Titulo_principal.TabIndex = 2;
            this.Titulo_principal.Text = "Juego del Ahorcado del Grupo #4";
            this.Titulo_principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Snow;
            this.Nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nombre.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(303, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(186, 46);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Su nombre";
            this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Selector_dificultad
            // 
            this.Selector_dificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selector_dificultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selector_dificultad.FormattingEnabled = true;
            this.Selector_dificultad.Location = new System.Drawing.Point(117, 113);
            this.Selector_dificultad.Name = "Selector_dificultad";
            this.Selector_dificultad.Size = new System.Drawing.Size(107, 21);
            this.Selector_dificultad.TabIndex = 7;
            // 
            // Dificultad
            // 
            this.Dificultad.BackColor = System.Drawing.Color.Transparent;
            this.Dificultad.Cursor = System.Windows.Forms.Cursors.Default;
            this.Dificultad.Enabled = false;
            this.Dificultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dificultad.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dificultad.ForeColor = System.Drawing.Color.Snow;
            this.Dificultad.Location = new System.Drawing.Point(114, 74);
            this.Dificultad.Name = "Dificultad";
            this.Dificultad.Size = new System.Drawing.Size(110, 36);
            this.Dificultad.TabIndex = 8;
            this.Dificultad.Text = "Dificultad";
            this.Dificultad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 357);
            this.Controls.Add(this.Dificultad);
            this.Controls.Add(this.Selector_dificultad);
            this.Controls.Add(this.Nombre);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_empezar;
        private System.Windows.Forms.Button Boton_records;
        private System.Windows.Forms.Label Titulo_principal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ComboBox Selector_dificultad;
        private System.Windows.Forms.Label Dificultad;
    }
}