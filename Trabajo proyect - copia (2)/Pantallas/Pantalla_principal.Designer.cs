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
            this.Selector_dificultad = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
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
            this.Boton_empezar.Location = new System.Drawing.Point(267, 207);
            this.Boton_empezar.Margin = new System.Windows.Forms.Padding(4);
            this.Boton_empezar.Name = "Boton_empezar";
            this.Boton_empezar.Size = new System.Drawing.Size(212, 75);
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
            this.Boton_records.ForeColor = System.Drawing.Color.Black;
            this.Boton_records.Location = new System.Drawing.Point(40, 195);
            this.Boton_records.Margin = new System.Windows.Forms.Padding(4);
            this.Boton_records.Name = "Boton_records";
            this.Boton_records.Size = new System.Drawing.Size(128, 48);
            this.Boton_records.TabIndex = 1;
            this.Boton_records.Text = "Registros";
            this.Boton_records.UseVisualStyleBackColor = false;
            this.Boton_records.Click += new System.EventHandler(this.Boton_records_Click);
            // 
            // Titulo_principal
            // 
            this.Titulo_principal.AutoSize = true;
            this.Titulo_principal.BackColor = System.Drawing.Color.Snow;
            this.Titulo_principal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Titulo_principal.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_principal.ForeColor = System.Drawing.Color.Black;
            this.Titulo_principal.Location = new System.Drawing.Point(59, 27);
            this.Titulo_principal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo_principal.Name = "Titulo_principal";
            this.Titulo_principal.Size = new System.Drawing.Size(619, 43);
            this.Titulo_principal.TabIndex = 2;
            this.Titulo_principal.Text = "Juego del Ahorcado del Grupo #4";
            this.Titulo_principal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Selector_dificultad
            // 
            this.Selector_dificultad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selector_dificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selector_dificultad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Selector_dificultad.FormattingEnabled = true;
            this.Selector_dificultad.Location = new System.Drawing.Point(156, 139);
            this.Selector_dificultad.Margin = new System.Windows.Forms.Padding(4);
            this.Selector_dificultad.Name = "Selector_dificultad";
            this.Selector_dificultad.Size = new System.Drawing.Size(141, 24);
            this.Selector_dificultad.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Snow;
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.Black;
            this.Nombre.Location = new System.Drawing.Point(388, 128);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(297, 33);
            this.Nombre.TabIndex = 9;
            this.Nombre.Text = "Coloque su nombre";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dificultad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(646, 394);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 33);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Ventana_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 439);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Selector_dificultad);
            this.Controls.Add(this.Titulo_principal);
            this.Controls.Add(this.Boton_records);
            this.Controls.Add(this.Boton_empezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox Selector_dificultad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClose;
    }
}