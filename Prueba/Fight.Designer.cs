namespace Prueba
{
    partial class Fight
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBarEnemigo = new System.Windows.Forms.ProgressBar();
            this.progressBarJugador = new System.Windows.Forms.ProgressBar();
            this.textNombreEnemigo = new System.Windows.Forms.Label();
            this.textManaEnemigo = new System.Windows.Forms.Label();
            this.textManaJugador = new System.Windows.Forms.Label();
            this.textContadorCartas = new System.Windows.Forms.Label();
            this.btnFinalizarTurno = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textContadorCartasEnemigo = new System.Windows.Forms.Label();
            this.lblVidaEnemigo = new System.Windows.Forms.Label();
            this.lblVidaJugador = new System.Windows.Forms.Label();
            this.imagenDorso = new System.Windows.Forms.PictureBox();
            this.fotoEnemigo = new System.Windows.Forms.PictureBox();
            this.fotoFondo = new System.Windows.Forms.PictureBox();
            this.lblMana = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblManaEnemigo = new System.Windows.Forms.Label();
            this.lblContadorEnemigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDorso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarEnemigo
            // 
            this.progressBarEnemigo.ForeColor = System.Drawing.Color.White;
            this.progressBarEnemigo.Location = new System.Drawing.Point(346, 32);
            this.progressBarEnemigo.Name = "progressBarEnemigo";
            this.progressBarEnemigo.Size = new System.Drawing.Size(255, 23);
            this.progressBarEnemigo.TabIndex = 2;
            this.progressBarEnemigo.Value = 100;
            // 
            // progressBarJugador
            // 
            this.progressBarJugador.Location = new System.Drawing.Point(346, 529);
            this.progressBarJugador.Name = "progressBarJugador";
            this.progressBarJugador.Size = new System.Drawing.Size(255, 23);
            this.progressBarJugador.TabIndex = 3;
            this.progressBarJugador.Value = 100;
            // 
            // textNombreEnemigo
            // 
            this.textNombreEnemigo.AutoSize = true;
            this.textNombreEnemigo.BackColor = System.Drawing.Color.White;
            this.textNombreEnemigo.Location = new System.Drawing.Point(433, 16);
            this.textNombreEnemigo.Name = "textNombreEnemigo";
            this.textNombreEnemigo.Size = new System.Drawing.Size(104, 13);
            this.textNombreEnemigo.TabIndex = 7;
            this.textNombreEnemigo.Text = "Nombre del enemigo";
            // 
            // textManaEnemigo
            // 
            this.textManaEnemigo.AutoSize = true;
            this.textManaEnemigo.BackColor = System.Drawing.Color.White;
            this.textManaEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textManaEnemigo.Location = new System.Drawing.Point(693, 12);
            this.textManaEnemigo.Name = "textManaEnemigo";
            this.textManaEnemigo.Size = new System.Drawing.Size(16, 16);
            this.textManaEnemigo.TabIndex = 8;
            this.textManaEnemigo.Text = "X";
            // 
            // textManaJugador
            // 
            this.textManaJugador.AutoSize = true;
            this.textManaJugador.BackColor = System.Drawing.Color.White;
            this.textManaJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textManaJugador.Location = new System.Drawing.Point(650, 532);
            this.textManaJugador.Name = "textManaJugador";
            this.textManaJugador.Size = new System.Drawing.Size(16, 16);
            this.textManaJugador.TabIndex = 9;
            this.textManaJugador.Text = "X";
            // 
            // textContadorCartas
            // 
            this.textContadorCartas.AutoSize = true;
            this.textContadorCartas.BackColor = System.Drawing.Color.White;
            this.textContadorCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContadorCartas.Location = new System.Drawing.Point(959, 269);
            this.textContadorCartas.Name = "textContadorCartas";
            this.textContadorCartas.Size = new System.Drawing.Size(20, 20);
            this.textContadorCartas.TabIndex = 11;
            this.textContadorCartas.Text = "X";
            // 
            // btnFinalizarTurno
            // 
            this.btnFinalizarTurno.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinalizarTurno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalizarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinalizarTurno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizarTurno.Location = new System.Drawing.Point(816, 207);
            this.btnFinalizarTurno.Name = "btnFinalizarTurno";
            this.btnFinalizarTurno.Size = new System.Drawing.Size(178, 38);
            this.btnFinalizarTurno.TabIndex = 6;
            this.btnFinalizarTurno.Text = "FINALIZAR TURNO";
            this.btnFinalizarTurno.UseVisualStyleBackColor = false;
            this.btnFinalizarTurno.Click += new System.EventHandler(this.btnFinalizarTurno_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textContadorCartasEnemigo
            // 
            this.textContadorCartasEnemigo.AutoSize = true;
            this.textContadorCartasEnemigo.BackColor = System.Drawing.Color.White;
            this.textContadorCartasEnemigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textContadorCartasEnemigo.Location = new System.Drawing.Point(959, 9);
            this.textContadorCartasEnemigo.Name = "textContadorCartasEnemigo";
            this.textContadorCartasEnemigo.Size = new System.Drawing.Size(20, 20);
            this.textContadorCartasEnemigo.TabIndex = 13;
            this.textContadorCartasEnemigo.Text = "X";
            // 
            // lblVidaEnemigo
            // 
            this.lblVidaEnemigo.AutoSize = true;
            this.lblVidaEnemigo.BackColor = System.Drawing.Color.LightGreen;
            this.lblVidaEnemigo.Location = new System.Drawing.Point(550, 36);
            this.lblVidaEnemigo.Name = "lblVidaEnemigo";
            this.lblVidaEnemigo.Size = new System.Drawing.Size(35, 13);
            this.lblVidaEnemigo.TabIndex = 15;
            this.lblVidaEnemigo.Text = "label1";
            // 
            // lblVidaJugador
            // 
            this.lblVidaJugador.AutoSize = true;
            this.lblVidaJugador.BackColor = System.Drawing.Color.LightGreen;
            this.lblVidaJugador.Location = new System.Drawing.Point(550, 534);
            this.lblVidaJugador.Name = "lblVidaJugador";
            this.lblVidaJugador.Size = new System.Drawing.Size(35, 13);
            this.lblVidaJugador.TabIndex = 16;
            this.lblVidaJugador.Text = "label2";
            // 
            // imagenDorso
            // 
            this.imagenDorso.Image = global::Prueba.Properties.Resources.DorsoCarta;
            this.imagenDorso.Location = new System.Drawing.Point(871, 307);
            this.imagenDorso.Name = "imagenDorso";
            this.imagenDorso.Size = new System.Drawing.Size(123, 184);
            this.imagenDorso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenDorso.TabIndex = 17;
            this.imagenDorso.TabStop = false;
            // 
            // fotoEnemigo
            // 
            this.fotoEnemigo.BackColor = System.Drawing.Color.Gainsboro;
            this.fotoEnemigo.Location = new System.Drawing.Point(370, 76);
            this.fotoEnemigo.Name = "fotoEnemigo";
            this.fotoEnemigo.Size = new System.Drawing.Size(215, 230);
            this.fotoEnemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoEnemigo.TabIndex = 1;
            this.fotoEnemigo.TabStop = false;
            // 
            // fotoFondo
            // 
            this.fotoFondo.BackColor = System.Drawing.Color.Gainsboro;
            this.fotoFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fotoFondo.Location = new System.Drawing.Point(0, 0);
            this.fotoFondo.Name = "fotoFondo";
            this.fotoFondo.Size = new System.Drawing.Size(1006, 564);
            this.fotoFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoFondo.TabIndex = 0;
            this.fotoFondo.TabStop = false;
            // 
            // lblMana
            // 
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.White;
            this.lblMana.Location = new System.Drawing.Point(607, 534);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(37, 13);
            this.lblMana.TabIndex = 18;
            this.lblMana.Text = "Maná:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.BackColor = System.Drawing.Color.White;
            this.lblContador.Location = new System.Drawing.Point(868, 274);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(85, 13);
            this.lblContador.TabIndex = 19;
            this.lblContador.Text = "Cartas del mazo:";
            // 
            // lblManaEnemigo
            // 
            this.lblManaEnemigo.AutoSize = true;
            this.lblManaEnemigo.BackColor = System.Drawing.Color.White;
            this.lblManaEnemigo.Location = new System.Drawing.Point(607, 14);
            this.lblManaEnemigo.Name = "lblManaEnemigo";
            this.lblManaEnemigo.Size = new System.Drawing.Size(80, 13);
            this.lblManaEnemigo.TabIndex = 20;
            this.lblManaEnemigo.Text = "Maná enemigo:";
            // 
            // lblContadorEnemigo
            // 
            this.lblContadorEnemigo.AutoSize = true;
            this.lblContadorEnemigo.BackColor = System.Drawing.Color.White;
            this.lblContadorEnemigo.Location = new System.Drawing.Point(825, 16);
            this.lblContadorEnemigo.Name = "lblContadorEnemigo";
            this.lblContadorEnemigo.Size = new System.Drawing.Size(128, 13);
            this.lblContadorEnemigo.TabIndex = 21;
            this.lblContadorEnemigo.Text = "Cartas del mazo enemigo:";
            // 
            // Combate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 564);
            this.Controls.Add(this.lblContadorEnemigo);
            this.Controls.Add(this.lblManaEnemigo);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.imagenDorso);
            this.Controls.Add(this.lblVidaJugador);
            this.Controls.Add(this.lblVidaEnemigo);
            this.Controls.Add(this.textContadorCartasEnemigo);
            this.Controls.Add(this.textContadorCartas);
            this.Controls.Add(this.textManaJugador);
            this.Controls.Add(this.textManaEnemigo);
            this.Controls.Add(this.textNombreEnemigo);
            this.Controls.Add(this.btnFinalizarTurno);
            this.Controls.Add(this.progressBarJugador);
            this.Controls.Add(this.progressBarEnemigo);
            this.Controls.Add(this.fotoEnemigo);
            this.Controls.Add(this.fotoFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Combate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Combate_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.Combate_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.imagenDorso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox fotoEnemigo;
        private System.Windows.Forms.ProgressBar progressBarEnemigo;
        private System.Windows.Forms.ProgressBar progressBarJugador;
        private System.Windows.Forms.Button btnFinalizarTurno;
        private System.Windows.Forms.Label textNombreEnemigo;
        private System.Windows.Forms.Label textManaEnemigo;
        private System.Windows.Forms.Label textManaJugador;
        private System.Windows.Forms.Label textContadorCartas;
        private System.Windows.Forms.PictureBox fotoFondo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label textContadorCartasEnemigo;
        private System.Windows.Forms.Label lblVidaEnemigo;
        private System.Windows.Forms.Label lblVidaJugador;
        private System.Windows.Forms.PictureBox imagenDorso;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblManaEnemigo;
        private System.Windows.Forms.Label lblContadorEnemigo;
    }
}

