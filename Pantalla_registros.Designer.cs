namespace Proyecto_Estructuras
{
    partial class Pantalla_registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_registros));
            this.Boton_menú_registros = new System.Windows.Forms.Button();
            this.Registro_Faciles = new System.Windows.Forms.ListBox();
            this.Registro_medio = new System.Windows.Forms.ListBox();
            this.Registro_dificiles = new System.Windows.Forms.ListBox();
            this.Etiqueta_faciles = new System.Windows.Forms.Label();
            this.Etiqueta_medios = new System.Windows.Forms.Label();
            this.Etiqueta_dificiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Boton_menú_registros
            // 
            this.Boton_menú_registros.BackColor = System.Drawing.Color.Snow;
            this.Boton_menú_registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_menú_registros.FlatAppearance.BorderSize = 0;
            this.Boton_menú_registros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_menú_registros.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_menú_registros.ForeColor = System.Drawing.Color.Black;
            this.Boton_menú_registros.Location = new System.Drawing.Point(186, 345);
            this.Boton_menú_registros.Name = "Boton_menú_registros";
            this.Boton_menú_registros.Size = new System.Drawing.Size(154, 70);
            this.Boton_menú_registros.TabIndex = 0;
            this.Boton_menú_registros.Text = "Regresar al menú";
            this.Boton_menú_registros.UseVisualStyleBackColor = false;
            // 
            // Registro_Faciles
            // 
            this.Registro_Faciles.BackColor = System.Drawing.Color.White;
            this.Registro_Faciles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registro_Faciles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registro_Faciles.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro_Faciles.ForeColor = System.Drawing.Color.Black;
            this.Registro_Faciles.FormattingEnabled = true;
            this.Registro_Faciles.ItemHeight = 19;
            this.Registro_Faciles.Location = new System.Drawing.Point(12, 46);
            this.Registro_Faciles.Name = "Registro_Faciles";
            this.Registro_Faciles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Registro_Faciles.Size = new System.Drawing.Size(154, 285);
            this.Registro_Faciles.TabIndex = 1;
            this.Registro_Faciles.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Registro_medio
            // 
            this.Registro_medio.BackColor = System.Drawing.Color.White;
            this.Registro_medio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registro_medio.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registro_medio.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro_medio.ForeColor = System.Drawing.Color.Black;
            this.Registro_medio.FormattingEnabled = true;
            this.Registro_medio.ItemHeight = 19;
            this.Registro_medio.Location = new System.Drawing.Point(186, 46);
            this.Registro_medio.Name = "Registro_medio";
            this.Registro_medio.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Registro_medio.Size = new System.Drawing.Size(154, 285);
            this.Registro_medio.TabIndex = 2;
            // 
            // Registro_dificiles
            // 
            this.Registro_dificiles.BackColor = System.Drawing.Color.White;
            this.Registro_dificiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Registro_dificiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Registro_dificiles.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro_dificiles.ForeColor = System.Drawing.Color.Black;
            this.Registro_dificiles.FormattingEnabled = true;
            this.Registro_dificiles.ItemHeight = 19;
            this.Registro_dificiles.Location = new System.Drawing.Point(359, 46);
            this.Registro_dificiles.Name = "Registro_dificiles";
            this.Registro_dificiles.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Registro_dificiles.Size = new System.Drawing.Size(154, 285);
            this.Registro_dificiles.TabIndex = 3;
            // 
            // Etiqueta_faciles
            // 
            this.Etiqueta_faciles.BackColor = System.Drawing.Color.Transparent;
            this.Etiqueta_faciles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Etiqueta_faciles.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_faciles.ForeColor = System.Drawing.Color.White;
            this.Etiqueta_faciles.Location = new System.Drawing.Point(12, 10);
            this.Etiqueta_faciles.Name = "Etiqueta_faciles";
            this.Etiqueta_faciles.Size = new System.Drawing.Size(154, 33);
            this.Etiqueta_faciles.TabIndex = 7;
            this.Etiqueta_faciles.Text = "Fáciles";
            this.Etiqueta_faciles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Etiqueta_medios
            // 
            this.Etiqueta_medios.BackColor = System.Drawing.Color.Transparent;
            this.Etiqueta_medios.Cursor = System.Windows.Forms.Cursors.Default;
            this.Etiqueta_medios.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_medios.ForeColor = System.Drawing.Color.White;
            this.Etiqueta_medios.Location = new System.Drawing.Point(186, 10);
            this.Etiqueta_medios.Name = "Etiqueta_medios";
            this.Etiqueta_medios.Size = new System.Drawing.Size(154, 33);
            this.Etiqueta_medios.TabIndex = 8;
            this.Etiqueta_medios.Text = "Medios";
            this.Etiqueta_medios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Etiqueta_dificiles
            // 
            this.Etiqueta_dificiles.BackColor = System.Drawing.Color.Transparent;
            this.Etiqueta_dificiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.Etiqueta_dificiles.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_dificiles.ForeColor = System.Drawing.Color.White;
            this.Etiqueta_dificiles.Location = new System.Drawing.Point(359, 10);
            this.Etiqueta_dificiles.Name = "Etiqueta_dificiles";
            this.Etiqueta_dificiles.Size = new System.Drawing.Size(154, 33);
            this.Etiqueta_dificiles.TabIndex = 9;
            this.Etiqueta_dificiles.Text = "Difíciles";
            this.Etiqueta_dificiles.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Etiqueta_dificiles.Click += new System.EventHandler(this.Etiqueta_dificiles_Click);
            // 
            // Pantalla_registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(525, 427);
            this.Controls.Add(this.Etiqueta_dificiles);
            this.Controls.Add(this.Etiqueta_medios);
            this.Controls.Add(this.Etiqueta_faciles);
            this.Controls.Add(this.Registro_dificiles);
            this.Controls.Add(this.Registro_medio);
            this.Controls.Add(this.Registro_Faciles);
            this.Controls.Add(this.Boton_menú_registros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pantalla_registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_menú_registros;
        private System.Windows.Forms.ListBox Registro_Faciles;
        private System.Windows.Forms.ListBox Registro_medio;
        private System.Windows.Forms.ListBox Registro_dificiles;
        private System.Windows.Forms.Label Etiqueta_faciles;
        private System.Windows.Forms.Label Etiqueta_medios;
        private System.Windows.Forms.Label Etiqueta_dificiles;
    }
}