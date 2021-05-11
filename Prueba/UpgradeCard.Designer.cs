namespace Prueba
{
    partial class UpgradeCard
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
            this.cajaTexto = new System.Windows.Forms.RichTextBox();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.btnMejorar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblDinero = new System.Windows.Forms.Label();
            this.textDinero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaTexto
            // 
            this.cajaTexto.Location = new System.Drawing.Point(12, 381);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(756, 81);
            this.cajaTexto.TabIndex = 0;
            this.cajaTexto.Text = "";
            // 
            // imagen1
            // 
            this.imagen1.Location = new System.Drawing.Point(291, 101);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(225, 214);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen1.TabIndex = 2;
            this.imagen1.TabStop = false;
            // 
            // btnMejorar
            // 
            this.btnMejorar.Location = new System.Drawing.Point(612, 352);
            this.btnMejorar.Name = "btnMejorar";
            this.btnMejorar.Size = new System.Drawing.Size(75, 23);
            this.btnMejorar.TabIndex = 3;
            this.btnMejorar.Text = "Mejorar";
            this.btnMejorar.UseVisualStyleBackColor = true;
            this.btnMejorar.Click += new System.EventHandler(this.btnMejorar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(693, 352);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(688, 9);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(56, 18);
            this.lblDinero.TabIndex = 5;
            this.lblDinero.Text = "Dinero:";
            // 
            // textDinero
            // 
            this.textDinero.AutoSize = true;
            this.textDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDinero.Location = new System.Drawing.Point(750, 9);
            this.textDinero.Name = "textDinero";
            this.textDinero.Size = new System.Drawing.Size(18, 18);
            this.textDinero.TabIndex = 6;
            this.textDinero.Text = "X";
            // 
            // UpgradeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoMejorar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.textDinero);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMejorar);
            this.Controls.Add(this.imagen1);
            this.Controls.Add(this.cajaTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UpgradeCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mejorar carta inicial";
            this.Load += new System.EventHandler(this.MejorarCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox cajaTexto;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.Button btnMejorar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.Label textDinero;
    }
}