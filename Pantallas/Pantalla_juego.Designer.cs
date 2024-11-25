namespace Proyecto_Estructuras.Pantallas
{
    partial class Pantalla_juego
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla_juego));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Boton_confirmar = new System.Windows.Forms.Button();
            this.Letra_escrita = new System.Windows.Forms.Label();
            this.Vida_1 = new System.Windows.Forms.PictureBox();
            this.Vida_2 = new System.Windows.Forms.PictureBox();
            this.Vida_3 = new System.Windows.Forms.PictureBox();
            this.Vida_4 = new System.Windows.Forms.PictureBox();
            this.Vida_5 = new System.Windows.Forms.PictureBox();
            this.Vida_6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Letras_usadas = new System.Windows.Forms.ListBox();
            this.Puntos = new System.Windows.Forms.Label();
            this.Boton_menu = new System.Windows.Forms.Button();
            this.Palabras_utilizadas = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Boton_confirmar
            // 
            this.Boton_confirmar.BackColor = System.Drawing.Color.Snow;
            this.Boton_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_confirmar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_confirmar.Location = new System.Drawing.Point(367, 321);
            this.Boton_confirmar.Name = "Boton_confirmar";
            this.Boton_confirmar.Size = new System.Drawing.Size(205, 41);
            this.Boton_confirmar.TabIndex = 1;
            this.Boton_confirmar.Text = "Verificar letra";
            this.Boton_confirmar.UseVisualStyleBackColor = false;
            // 
            // Letra_escrita
            // 
            this.Letra_escrita.BackColor = System.Drawing.Color.White;
            this.Letra_escrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Letra_escrita.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letra_escrita.ForeColor = System.Drawing.Color.Black;
            this.Letra_escrita.Location = new System.Drawing.Point(264, 312);
            this.Letra_escrita.Name = "Letra_escrita";
            this.Letra_escrita.Size = new System.Drawing.Size(57, 67);
            this.Letra_escrita.TabIndex = 3;
            this.Letra_escrita.Text = "A";
            this.Letra_escrita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Letra_escrita.Click += new System.EventHandler(this.label1_Click);
            // 
            // Vida_1
            // 
            this.Vida_1.BackColor = System.Drawing.Color.Transparent;
            this.Vida_1.Image = global::Proyecto_Estructuras.Properties.Resources.esqueleto;
            this.Vida_1.Location = new System.Drawing.Point(317, 30);
            this.Vida_1.Name = "Vida_1";
            this.Vida_1.Size = new System.Drawing.Size(44, 46);
            this.Vida_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_1.TabIndex = 5;
            this.Vida_1.TabStop = false;
            // 
            // Vida_2
            // 
            this.Vida_2.BackColor = System.Drawing.Color.Transparent;
            this.Vida_2.Image = global::Proyecto_Estructuras.Properties.Resources.esqueleto;
            this.Vida_2.Location = new System.Drawing.Point(367, 30);
            this.Vida_2.Name = "Vida_2";
            this.Vida_2.Size = new System.Drawing.Size(44, 46);
            this.Vida_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_2.TabIndex = 6;
            this.Vida_2.TabStop = false;
            // 
            // Vida_3
            // 
            this.Vida_3.BackColor = System.Drawing.Color.Transparent;
            this.Vida_3.Image = global::Proyecto_Estructuras.Properties.Resources.Vida;
            this.Vida_3.Location = new System.Drawing.Point(417, 30);
            this.Vida_3.Name = "Vida_3";
            this.Vida_3.Size = new System.Drawing.Size(44, 46);
            this.Vida_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_3.TabIndex = 7;
            this.Vida_3.TabStop = false;
            // 
            // Vida_4
            // 
            this.Vida_4.BackColor = System.Drawing.Color.Transparent;
            this.Vida_4.Image = global::Proyecto_Estructuras.Properties.Resources.Vida;
            this.Vida_4.Location = new System.Drawing.Point(467, 30);
            this.Vida_4.Name = "Vida_4";
            this.Vida_4.Size = new System.Drawing.Size(44, 46);
            this.Vida_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_4.TabIndex = 8;
            this.Vida_4.TabStop = false;
            // 
            // Vida_5
            // 
            this.Vida_5.BackColor = System.Drawing.Color.Transparent;
            this.Vida_5.Image = global::Proyecto_Estructuras.Properties.Resources.Vida;
            this.Vida_5.Location = new System.Drawing.Point(517, 30);
            this.Vida_5.Name = "Vida_5";
            this.Vida_5.Size = new System.Drawing.Size(44, 46);
            this.Vida_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_5.TabIndex = 9;
            this.Vida_5.TabStop = false;
            this.Vida_5.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Vida_6
            // 
            this.Vida_6.BackColor = System.Drawing.Color.Transparent;
            this.Vida_6.Image = global::Proyecto_Estructuras.Properties.Resources.Vida;
            this.Vida_6.Location = new System.Drawing.Point(567, 30);
            this.Vida_6.Name = "Vida_6";
            this.Vida_6.Size = new System.Drawing.Size(44, 46);
            this.Vida_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Vida_6.TabIndex = 10;
            this.Vida_6.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(264, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 67);
            this.label1.TabIndex = 11;
            this.label1.Text = "A";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(336, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 67);
            this.label2.TabIndex = 12;
            this.label2.Text = "A";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(408, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 67);
            this.label3.TabIndex = 13;
            this.label3.Text = "A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 67);
            this.label4.TabIndex = 14;
            this.label4.Text = "A";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(552, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 67);
            this.label5.TabIndex = 15;
            this.label5.Text = "A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(624, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 67);
            this.label6.TabIndex = 16;
            this.label6.Text = "A";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(696, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 67);
            this.label7.TabIndex = 17;
            this.label7.Text = "A";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Letras_usadas
            // 
            this.Letras_usadas.BackColor = System.Drawing.Color.White;
            this.Letras_usadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Letras_usadas.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letras_usadas.ForeColor = System.Drawing.Color.Black;
            this.Letras_usadas.FormattingEnabled = true;
            this.Letras_usadas.ItemHeight = 14;
            this.Letras_usadas.Items.AddRange(new object[] {
            "Letra 1",
            "Letra 2",
            "Letra 3",
            "Letra 4",
            "Letra 5",
            "Letra 6",
            "Letra 7",
            "Letra 8",
            "Letra 9",
            "Letra 10",
            "Letra 11",
            "Letra 12",
            "Letra 13"});
            this.Letras_usadas.Location = new System.Drawing.Point(28, 261);
            this.Letras_usadas.Name = "Letras_usadas";
            this.Letras_usadas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Letras_usadas.Size = new System.Drawing.Size(102, 182);
            this.Letras_usadas.TabIndex = 13;
            // 
            // Puntos
            // 
            this.Puntos.BackColor = System.Drawing.Color.Transparent;
            this.Puntos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Puntos.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.ForeColor = System.Drawing.Color.White;
            this.Puntos.Location = new System.Drawing.Point(655, 30);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(68, 46);
            this.Puntos.TabIndex = 19;
            this.Puntos.Text = "0";
            this.Puntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Boton_menu
            // 
            this.Boton_menu.BackColor = System.Drawing.Color.Snow;
            this.Boton_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_menu.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Boton_menu.Location = new System.Drawing.Point(660, 395);
            this.Boton_menu.Name = "Boton_menu";
            this.Boton_menu.Size = new System.Drawing.Size(108, 50);
            this.Boton_menu.TabIndex = 20;
            this.Boton_menu.Text = "Volver al menú";
            this.Boton_menu.UseVisualStyleBackColor = false;
            // 
            // Palabras_utilizadas
            // 
            this.Palabras_utilizadas.AutoSize = true;
            this.Palabras_utilizadas.BackColor = System.Drawing.Color.Transparent;
            this.Palabras_utilizadas.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palabras_utilizadas.ForeColor = System.Drawing.Color.White;
            this.Palabras_utilizadas.Location = new System.Drawing.Point(12, 241);
            this.Palabras_utilizadas.Name = "Palabras_utilizadas";
            this.Palabras_utilizadas.Size = new System.Drawing.Size(135, 17);
            this.Palabras_utilizadas.TabIndex = 21;
            this.Palabras_utilizadas.Text = "Letras utilizadas";
            this.Palabras_utilizadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Pantalla_juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.Palabras_utilizadas);
            this.Controls.Add(this.Boton_menu);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.Letras_usadas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vida_6);
            this.Controls.Add(this.Vida_5);
            this.Controls.Add(this.Vida_4);
            this.Controls.Add(this.Vida_3);
            this.Controls.Add(this.Vida_2);
            this.Controls.Add(this.Vida_1);
            this.Controls.Add(this.Letra_escrita);
            this.Controls.Add(this.Boton_confirmar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pantalla_juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego del ahorcado";
            this.Load += new System.EventHandler(this.Pantalla_juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vida_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Boton_confirmar;
        private System.Windows.Forms.Label Letra_escrita;
        private System.Windows.Forms.PictureBox Vida_6;
        private System.Windows.Forms.PictureBox Vida_5;
        private System.Windows.Forms.PictureBox Vida_4;
        private System.Windows.Forms.PictureBox Vida_3;
        private System.Windows.Forms.PictureBox Vida_2;
        private System.Windows.Forms.PictureBox Vida_1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.ListBox Letras_usadas;
        private System.Windows.Forms.Button Boton_menu;
        private System.Windows.Forms.Label Palabras_utilizadas;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}