using System;

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
            this.Boton_confirmar = new System.Windows.Forms.Button();
            this.Campo_1 = new System.Windows.Forms.Label();
            this.Campo_2 = new System.Windows.Forms.Label();
            this.Campo_3 = new System.Windows.Forms.Label();
            this.Campo_4 = new System.Windows.Forms.Label();
            this.Campo_5 = new System.Windows.Forms.Label();
            this.Campo_6 = new System.Windows.Forms.Label();
            this.Campo_7 = new System.Windows.Forms.Label();
            this.Puntos = new System.Windows.Forms.Label();
            this.Boton_menu = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Campo_9 = new System.Windows.Forms.Label();
            this.Campo_8 = new System.Windows.Forms.Label();
            this.Temporizador_juego = new System.Windows.Forms.Timer(this.components);
            this.Temporizador_muestra = new System.Windows.Forms.Label();
            this.Letra_ingresada = new System.Windows.Forms.TextBox();
            this.LabelVidas = new System.Windows.Forms.Label();
            this.VidasDeJugador = new System.Windows.Forms.TextBox();
            this.PuntosJugador = new System.Windows.Forms.TextBox();
            this.TiempoJuego = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Boton_confirmar
            // 
            this.Boton_confirmar.BackColor = System.Drawing.Color.Snow;
            this.Boton_confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_confirmar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_confirmar.Location = new System.Drawing.Point(591, 384);
            this.Boton_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.Boton_confirmar.Name = "Boton_confirmar";
            this.Boton_confirmar.Size = new System.Drawing.Size(273, 50);
            this.Boton_confirmar.TabIndex = 1;
            this.Boton_confirmar.Text = "Verificar letra";
            this.Boton_confirmar.UseVisualStyleBackColor = false;
            this.Boton_confirmar.Click += new System.EventHandler(this.Boton_confirmar_Click);
            // 
            // Campo_1
            // 
            this.Campo_1.BackColor = System.Drawing.Color.White;
            this.Campo_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_1.ForeColor = System.Drawing.Color.Black;
            this.Campo_1.Location = new System.Drawing.Point(352, 192);
            this.Campo_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_1.Name = "Campo_1";
            this.Campo_1.Size = new System.Drawing.Size(76, 82);
            this.Campo_1.TabIndex = 11;
            this.Campo_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_2
            // 
            this.Campo_2.BackColor = System.Drawing.Color.White;
            this.Campo_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_2.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_2.ForeColor = System.Drawing.Color.Black;
            this.Campo_2.Location = new System.Drawing.Point(448, 192);
            this.Campo_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_2.Name = "Campo_2";
            this.Campo_2.Size = new System.Drawing.Size(76, 82);
            this.Campo_2.TabIndex = 12;
            this.Campo_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_3
            // 
            this.Campo_3.BackColor = System.Drawing.Color.White;
            this.Campo_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_3.ForeColor = System.Drawing.Color.Black;
            this.Campo_3.Location = new System.Drawing.Point(544, 192);
            this.Campo_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_3.Name = "Campo_3";
            this.Campo_3.Size = new System.Drawing.Size(76, 82);
            this.Campo_3.TabIndex = 13;
            this.Campo_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_4
            // 
            this.Campo_4.BackColor = System.Drawing.Color.White;
            this.Campo_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_4.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_4.ForeColor = System.Drawing.Color.Black;
            this.Campo_4.Location = new System.Drawing.Point(640, 192);
            this.Campo_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_4.Name = "Campo_4";
            this.Campo_4.Size = new System.Drawing.Size(76, 82);
            this.Campo_4.TabIndex = 14;
            this.Campo_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_5
            // 
            this.Campo_5.BackColor = System.Drawing.Color.White;
            this.Campo_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_5.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_5.ForeColor = System.Drawing.Color.Black;
            this.Campo_5.Location = new System.Drawing.Point(736, 192);
            this.Campo_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_5.Name = "Campo_5";
            this.Campo_5.Size = new System.Drawing.Size(76, 82);
            this.Campo_5.TabIndex = 15;
            this.Campo_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_6
            // 
            this.Campo_6.BackColor = System.Drawing.Color.White;
            this.Campo_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_6.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_6.ForeColor = System.Drawing.Color.Black;
            this.Campo_6.Location = new System.Drawing.Point(832, 192);
            this.Campo_6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_6.Name = "Campo_6";
            this.Campo_6.Size = new System.Drawing.Size(76, 82);
            this.Campo_6.TabIndex = 16;
            this.Campo_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_7
            // 
            this.Campo_7.BackColor = System.Drawing.Color.White;
            this.Campo_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_7.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_7.ForeColor = System.Drawing.Color.Black;
            this.Campo_7.Location = new System.Drawing.Point(928, 192);
            this.Campo_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_7.Name = "Campo_7";
            this.Campo_7.Size = new System.Drawing.Size(76, 82);
            this.Campo_7.TabIndex = 17;
            this.Campo_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Puntos
            // 
            this.Puntos.BackColor = System.Drawing.Color.Transparent;
            this.Puntos.Cursor = System.Windows.Forms.Cursors.Default;
            this.Puntos.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.ForeColor = System.Drawing.Color.White;
            this.Puntos.Location = new System.Drawing.Point(871, 47);
            this.Puntos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(91, 57);
            this.Puntos.TabIndex = 19;
            this.Puntos.Text = "0";
            this.Puntos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Puntos.Click += new System.EventHandler(this.Puntos_Click);
            // 
            // Boton_menu
            // 
            this.Boton_menu.BackColor = System.Drawing.Color.Snow;
            this.Boton_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Boton_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Boton_menu.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton_menu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Boton_menu.Location = new System.Drawing.Point(1005, 486);
            this.Boton_menu.Margin = new System.Windows.Forms.Padding(4);
            this.Boton_menu.Name = "Boton_menu";
            this.Boton_menu.Size = new System.Drawing.Size(144, 62);
            this.Boton_menu.TabIndex = 20;
            this.Boton_menu.Text = "Volver al menú";
            this.Boton_menu.UseVisualStyleBackColor = false;
            this.Boton_menu.Click += new System.EventHandler(this.Boton_menu_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Campo_9
            // 
            this.Campo_9.BackColor = System.Drawing.Color.White;
            this.Campo_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_9.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_9.ForeColor = System.Drawing.Color.Black;
            this.Campo_9.Location = new System.Drawing.Point(1123, 192);
            this.Campo_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_9.Name = "Campo_9";
            this.Campo_9.Size = new System.Drawing.Size(76, 82);
            this.Campo_9.TabIndex = 23;
            this.Campo_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Campo_8
            // 
            this.Campo_8.BackColor = System.Drawing.Color.White;
            this.Campo_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Campo_8.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Campo_8.ForeColor = System.Drawing.Color.Black;
            this.Campo_8.Location = new System.Drawing.Point(1027, 192);
            this.Campo_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Campo_8.Name = "Campo_8";
            this.Campo_8.Size = new System.Drawing.Size(76, 82);
            this.Campo_8.TabIndex = 22;
            this.Campo_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temporizador_juego
            // 
            this.Temporizador_juego.Interval = 1000;
            // 
            // Temporizador_muestra
            // 
            this.Temporizador_muestra.BackColor = System.Drawing.Color.Transparent;
            this.Temporizador_muestra.Cursor = System.Windows.Forms.Cursors.Default;
            this.Temporizador_muestra.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temporizador_muestra.ForeColor = System.Drawing.Color.White;
            this.Temporizador_muestra.Location = new System.Drawing.Point(1060, 11);
            this.Temporizador_muestra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temporizador_muestra.Name = "Temporizador_muestra";
            this.Temporizador_muestra.Size = new System.Drawing.Size(137, 57);
            this.Temporizador_muestra.TabIndex = 24;
            this.Temporizador_muestra.Text = "0";
            this.Temporizador_muestra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Letra_ingresada
            // 
            this.Letra_ingresada.BackColor = System.Drawing.Color.Snow;
            this.Letra_ingresada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Letra_ingresada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Letra_ingresada.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Letra_ingresada.ForeColor = System.Drawing.Color.Black;
            this.Letra_ingresada.Location = new System.Drawing.Point(457, 378);
            this.Letra_ingresada.Margin = new System.Windows.Forms.Padding(4);
            this.Letra_ingresada.MaxLength = 1;
            this.Letra_ingresada.Name = "Letra_ingresada";
            this.Letra_ingresada.Size = new System.Drawing.Size(76, 58);
            this.Letra_ingresada.TabIndex = 25;
            this.Letra_ingresada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelVidas
            // 
            this.LabelVidas.BackColor = System.Drawing.Color.Transparent;
            this.LabelVidas.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelVidas.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVidas.ForeColor = System.Drawing.Color.White;
            this.LabelVidas.Location = new System.Drawing.Point(529, 47);
            this.LabelVidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelVidas.Name = "LabelVidas";
            this.LabelVidas.Size = new System.Drawing.Size(91, 57);
            this.LabelVidas.TabIndex = 26;
            this.LabelVidas.Text = "0";
            this.LabelVidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelVidas.Click += new System.EventHandler(this.Vidas_Click);
            // 
            // VidasDeJugador
            // 
            this.VidasDeJugador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VidasDeJugador.Location = new System.Drawing.Point(466, 64);
            this.VidasDeJugador.Name = "VidasDeJugador";
            this.VidasDeJugador.Size = new System.Drawing.Size(67, 30);
            this.VidasDeJugador.TabIndex = 27;
            this.VidasDeJugador.Text = "Vidas";
            // 
            // PuntosJugador
            // 
            this.PuntosJugador.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosJugador.Location = new System.Drawing.Point(813, 64);
            this.PuntosJugador.Name = "PuntosJugador";
            this.PuntosJugador.Size = new System.Drawing.Size(67, 30);
            this.PuntosJugador.TabIndex = 28;
            this.PuntosJugador.Text = "Puntos";
            this.PuntosJugador.TextChanged += new System.EventHandler(this.PuntosJugador_TextChanged);
            // 
            // TiempoJuego
            // 
            this.TiempoJuego.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TiempoJuego.Location = new System.Drawing.Point(996, 28);
            this.TiempoJuego.Name = "TiempoJuego";
            this.TiempoJuego.Size = new System.Drawing.Size(73, 30);
            this.TiempoJuego.TabIndex = 29;
            this.TiempoJuego.Text = "Tiempo";
            // 
            // Pantalla_juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Estructuras.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1213, 562);
            this.Controls.Add(this.TiempoJuego);
            this.Controls.Add(this.PuntosJugador);
            this.Controls.Add(this.VidasDeJugador);
            this.Controls.Add(this.LabelVidas);
            this.Controls.Add(this.Letra_ingresada);
            this.Controls.Add(this.Temporizador_muestra);
            this.Controls.Add(this.Campo_9);
            this.Controls.Add(this.Campo_8);
            this.Controls.Add(this.Boton_menu);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.Campo_7);
            this.Controls.Add(this.Campo_6);
            this.Controls.Add(this.Campo_5);
            this.Controls.Add(this.Campo_4);
            this.Controls.Add(this.Campo_3);
            this.Controls.Add(this.Campo_2);
            this.Controls.Add(this.Campo_1);
            this.Controls.Add(this.Boton_confirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Pantalla_juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego del ahorcado";
            this.Load += new System.EventHandler(this.Pantalla_juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Vidas_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }





        #endregion

       
        private System.Windows.Forms.Button Boton_confirmar;
        private System.Windows.Forms.Label Campo_7;
        private System.Windows.Forms.Label Campo_6;
        private System.Windows.Forms.Label Campo_5;
        private System.Windows.Forms.Label Campo_4;
        private System.Windows.Forms.Label Campo_3;
        private System.Windows.Forms.Label Campo_2;
        private System.Windows.Forms.Label Campo_1;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Button Boton_menu;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label Campo_9;
        private System.Windows.Forms.Label Campo_8;
        private System.Windows.Forms.Label Temporizador_muestra;
        private System.Windows.Forms.Timer Temporizador_juego;
        private System.Windows.Forms.TextBox Letra_ingresada;
        private System.Windows.Forms.TextBox VidasDeJugador;
        private System.Windows.Forms.Label LabelVidas;
        private System.Windows.Forms.TextBox TiempoJuego;
        private System.Windows.Forms.TextBox PuntosJugador;
    }
}