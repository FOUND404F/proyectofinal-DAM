namespace Prueba
{
    partial class MainMenu
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
            this.btnNuevaPartida = new System.Windows.Forms.Button();
            this.btnCargarPartida = new System.Windows.Forms.Button();
            this.btnCerrarJuego = new System.Windows.Forms.Button();
            this.btnCreditos = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnNuevaPartida
            // 
            this.btnNuevaPartida.Location = new System.Drawing.Point(154, 72);
            this.btnNuevaPartida.Name = "btnNuevaPartida";
            this.btnNuevaPartida.Size = new System.Drawing.Size(270, 41);
            this.btnNuevaPartida.TabIndex = 0;
            this.btnNuevaPartida.Text = "Nueva partida";
            this.btnNuevaPartida.UseVisualStyleBackColor = true;
            this.btnNuevaPartida.Click += new System.EventHandler(this.btnNuevaPartida_Click);
            // 
            // btnCargarPartida
            // 
            this.btnCargarPartida.Location = new System.Drawing.Point(154, 195);
            this.btnCargarPartida.Name = "btnCargarPartida";
            this.btnCargarPartida.Size = new System.Drawing.Size(270, 41);
            this.btnCargarPartida.TabIndex = 1;
            this.btnCargarPartida.Text = "Cargar partida";
            this.btnCargarPartida.UseVisualStyleBackColor = true;
            this.btnCargarPartida.Click += new System.EventHandler(this.cargar_Click);
            // 
            // btnCerrarJuego
            // 
            this.btnCerrarJuego.Location = new System.Drawing.Point(154, 315);
            this.btnCerrarJuego.Name = "btnCerrarJuego";
            this.btnCerrarJuego.Size = new System.Drawing.Size(270, 41);
            this.btnCerrarJuego.TabIndex = 2;
            this.btnCerrarJuego.Text = "Cerrar juego";
            this.btnCerrarJuego.UseVisualStyleBackColor = true;
            this.btnCerrarJuego.Click += new System.EventHandler(this.btnCerrarJuego_Click);
            // 
            // btnCreditos
            // 
            this.btnCreditos.Location = new System.Drawing.Point(480, 455);
            this.btnCreditos.Name = "btnCreditos";
            this.btnCreditos.Size = new System.Drawing.Size(110, 23);
            this.btnCreditos.TabIndex = 3;
            this.btnCreditos.Text = "Créditos";
            this.btnCreditos.UseVisualStyleBackColor = true;
            this.btnCreditos.Click += new System.EventHandler(this.btnCreditos_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 490);
            this.Controls.Add(this.btnCreditos);
            this.Controls.Add(this.btnCerrarJuego);
            this.Controls.Add(this.btnCargarPartida);
            this.Controls.Add(this.btnNuevaPartida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaPartida;
        private System.Windows.Forms.Button btnCargarPartida;
        private System.Windows.Forms.Button btnCerrarJuego;
        private System.Windows.Forms.Button btnCreditos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}