﻿namespace Proyecto_Estructuras
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
            this.Lista_registros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Boton_menú_registros
            // 
            this.Boton_menú_registros.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Boton_menú_registros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_menú_registros.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_menú_registros.ForeColor = System.Drawing.Color.Black;
            this.Boton_menú_registros.Location = new System.Drawing.Point(147, 345);
            this.Boton_menú_registros.Name = "Boton_menú_registros";
            this.Boton_menú_registros.Size = new System.Drawing.Size(167, 70);
            this.Boton_menú_registros.TabIndex = 0;
            this.Boton_menú_registros.Text = "Regresar al menú";
            this.Boton_menú_registros.UseVisualStyleBackColor = false;
            // 
            // Lista_registros
            // 
            this.Lista_registros.BackColor = System.Drawing.Color.White;
            this.Lista_registros.Cursor = System.Windows.Forms.Cursors.Default;
            this.Lista_registros.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista_registros.ForeColor = System.Drawing.Color.Black;
            this.Lista_registros.FormattingEnabled = true;
            this.Lista_registros.ItemHeight = 19;
            this.Lista_registros.Location = new System.Drawing.Point(56, 12);
            this.Lista_registros.Name = "Lista_registros";
            this.Lista_registros.ScrollAlwaysVisible = true;
            this.Lista_registros.Size = new System.Drawing.Size(344, 327);
            this.Lista_registros.TabIndex = 1;
            this.Lista_registros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Pantalla_registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(460, 427);
            this.Controls.Add(this.Lista_registros);
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
        private System.Windows.Forms.ListBox Lista_registros;
    }
}