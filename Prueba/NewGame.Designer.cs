namespace Prueba
{
    partial class NewGame
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCartaZorro = new System.Windows.Forms.Button();
            this.btnCartaBuho = new System.Windows.Forms.Button();
            this.btnCartaConejo = new System.Windows.Forms.Button();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.imagen2 = new System.Windows.Forms.PictureBox();
            this.imagen3 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.paneColorido1 = new System.Windows.Forms.Panel();
            this.paneColorido2 = new System.Windows.Forms.Panel();
            this.paneColorido3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen3)).BeginInit();
            this.paneColorido1.SuspendLayout();
            this.paneColorido2.SuspendLayout();
            this.paneColorido3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 380);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(722, 58);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Selecciona una carta inicial e introduce el nombre de tu personaje...";
            // 
            // btnCartaZorro
            // 
            this.btnCartaZorro.Location = new System.Drawing.Point(60, 250);
            this.btnCartaZorro.Name = "btnCartaZorro";
            this.btnCartaZorro.Size = new System.Drawing.Size(75, 23);
            this.btnCartaZorro.TabIndex = 4;
            this.btnCartaZorro.Text = "OK";
            this.btnCartaZorro.UseVisualStyleBackColor = true;
            this.btnCartaZorro.Click += new System.EventHandler(this.btnCartaZorro_Click);
            // 
            // btnCartaBuho
            // 
            this.btnCartaBuho.Location = new System.Drawing.Point(338, 250);
            this.btnCartaBuho.Name = "btnCartaBuho";
            this.btnCartaBuho.Size = new System.Drawing.Size(75, 23);
            this.btnCartaBuho.TabIndex = 5;
            this.btnCartaBuho.Text = "OK";
            this.btnCartaBuho.UseVisualStyleBackColor = true;
            this.btnCartaBuho.Click += new System.EventHandler(this.btnCartaBuho_Click);
            // 
            // btnCartaConejo
            // 
            this.btnCartaConejo.Location = new System.Drawing.Point(631, 250);
            this.btnCartaConejo.Name = "btnCartaConejo";
            this.btnCartaConejo.Size = new System.Drawing.Size(75, 23);
            this.btnCartaConejo.TabIndex = 6;
            this.btnCartaConejo.Text = "OK";
            this.btnCartaConejo.UseVisualStyleBackColor = true;
            this.btnCartaConejo.Click += new System.EventHandler(this.btnCartaConejo_Click);
            // 
            // imagen1
            // 
            this.imagen1.Image = global::Prueba.Properties.Resources.zorro1;
            this.imagen1.Location = new System.Drawing.Point(4, 3);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(145, 216);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen1.TabIndex = 7;
            this.imagen1.TabStop = false;
            // 
            // imagen2
            // 
            this.imagen2.Image = global::Prueba.Properties.Resources.buho1;
            this.imagen2.Location = new System.Drawing.Point(6, 6);
            this.imagen2.Name = "imagen2";
            this.imagen2.Size = new System.Drawing.Size(145, 213);
            this.imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen2.TabIndex = 8;
            this.imagen2.TabStop = false;
            // 
            // imagen3
            // 
            this.imagen3.Image = global::Prueba.Properties.Resources.conejo1;
            this.imagen3.Location = new System.Drawing.Point(6, 5);
            this.imagen3.Name = "imagen3";
            this.imagen3.Size = new System.Drawing.Size(145, 213);
            this.imagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen3.TabIndex = 9;
            this.imagen3.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(19, 337);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 15);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Tu nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(116, 335);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(227, 20);
            this.textBoxNombre.TabIndex = 11;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(358, 334);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 12;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(647, 351);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(87, 23);
            this.btnAtras.TabIndex = 13;
            this.btnAtras.Text = "Átras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // paneColorido1
            // 
            this.paneColorido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneColorido1.Controls.Add(this.imagen1);
            this.paneColorido1.Location = new System.Drawing.Point(22, 16);
            this.paneColorido1.Name = "paneColorido1";
            this.paneColorido1.Size = new System.Drawing.Size(154, 224);
            this.paneColorido1.TabIndex = 14;
            // 
            // paneColorido2
            // 
            this.paneColorido2.Controls.Add(this.imagen2);
            this.paneColorido2.Location = new System.Drawing.Point(293, 20);
            this.paneColorido2.Name = "paneColorido2";
            this.paneColorido2.Size = new System.Drawing.Size(154, 224);
            this.paneColorido2.TabIndex = 15;
            // 
            // paneColorido3
            // 
            this.paneColorido3.Controls.Add(this.imagen3);
            this.paneColorido3.Location = new System.Drawing.Point(580, 20);
            this.paneColorido3.Name = "paneColorido3";
            this.paneColorido3.Size = new System.Drawing.Size(154, 224);
            this.paneColorido3.TabIndex = 16;
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoNuevo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.paneColorido3);
            this.Controls.Add(this.paneColorido2);
            this.Controls.Add(this.paneColorido1);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnCartaConejo);
            this.Controls.Add(this.btnCartaBuho);
            this.Controls.Add(this.btnCartaZorro);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva partida";
            this.Load += new System.EventHandler(this.NuevaPartida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen3)).EndInit();
            this.paneColorido1.ResumeLayout(false);
            this.paneColorido2.ResumeLayout(false);
            this.paneColorido3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCartaZorro;
        private System.Windows.Forms.Button btnCartaBuho;
        private System.Windows.Forms.Button btnCartaConejo;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.PictureBox imagen2;
        private System.Windows.Forms.PictureBox imagen3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Panel paneColorido1;
        private System.Windows.Forms.Panel paneColorido2;
        private System.Windows.Forms.Panel paneColorido3;
    }
}