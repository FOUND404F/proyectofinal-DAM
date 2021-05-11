namespace Prueba
{
    partial class Encyclopedia
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
            this.imagenPrincipal = new System.Windows.Forms.PictureBox();
            this.paneDecorativo = new System.Windows.Forms.Panel();
            this.textBoxNombre = new System.Windows.Forms.RichTextBox();
            this.textBoxEtimologia = new System.Windows.Forms.RichTextBox();
            this.textBoxComportamiento = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrincipal)).BeginInit();
            this.paneDecorativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenPrincipal
            // 
            this.imagenPrincipal.Location = new System.Drawing.Point(12, 12);
            this.imagenPrincipal.Name = "imagenPrincipal";
            this.imagenPrincipal.Size = new System.Drawing.Size(397, 358);
            this.imagenPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPrincipal.TabIndex = 0;
            this.imagenPrincipal.TabStop = false;
            // 
            // paneDecorativo
            // 
            this.paneDecorativo.BackColor = System.Drawing.SystemColors.Control;
            this.paneDecorativo.Controls.Add(this.textBoxNombre);
            this.paneDecorativo.Controls.Add(this.textBoxEtimologia);
            this.paneDecorativo.Controls.Add(this.textBoxComportamiento);
            this.paneDecorativo.Controls.Add(this.label5);
            this.paneDecorativo.Controls.Add(this.label3);
            this.paneDecorativo.Controls.Add(this.label1);
            this.paneDecorativo.Location = new System.Drawing.Point(459, 12);
            this.paneDecorativo.Name = "paneDecorativo";
            this.paneDecorativo.Size = new System.Drawing.Size(329, 292);
            this.paneDecorativo.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(15, 27);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(299, 37);
            this.textBoxNombre.TabIndex = 7;
            this.textBoxNombre.Text = "";
            // 
            // textBoxEtimologia
            // 
            this.textBoxEtimologia.Enabled = false;
            this.textBoxEtimologia.Location = new System.Drawing.Point(15, 85);
            this.textBoxEtimologia.Name = "textBoxEtimologia";
            this.textBoxEtimologia.Size = new System.Drawing.Size(299, 82);
            this.textBoxEtimologia.TabIndex = 6;
            this.textBoxEtimologia.Text = "";
            // 
            // textBoxComportamiento
            // 
            this.textBoxComportamiento.Enabled = false;
            this.textBoxComportamiento.Location = new System.Drawing.Point(15, 186);
            this.textBoxComportamiento.Name = "textBoxComportamiento";
            this.textBoxComportamiento.Size = new System.Drawing.Size(299, 94);
            this.textBoxComportamiento.TabIndex = 5;
            this.textBoxComportamiento.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Etimología:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comportamiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(12, 376);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(75, 23);
            this.btnRetroceder.TabIndex = 2;
            this.btnRetroceder.Text = "<<";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(334, 376);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(75, 23);
            this.btnAvanzar.TabIndex = 3;
            this.btnAvanzar.Text = ">>";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(682, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(106, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Encyclopedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoEnciclopedia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.paneDecorativo);
            this.Controls.Add(this.imagenPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Encyclopedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enciclopedia";
            ((System.ComponentModel.ISupportInitialize)(this.imagenPrincipal)).EndInit();
            this.paneDecorativo.ResumeLayout(false);
            this.paneDecorativo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagenPrincipal;
        private System.Windows.Forms.Panel paneDecorativo;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox textBoxNombre;
        private System.Windows.Forms.RichTextBox textBoxEtimologia;
        private System.Windows.Forms.RichTextBox textBoxComportamiento;
    }
}