namespace Prueba
{
    partial class SecondaryMenu
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
            this.btnSeleccionarNivel = new System.Windows.Forms.Button();
            this.btnTienda = new System.Windows.Forms.Button();
            this.btnMejorarCarta = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEnciclopedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeleccionarNivel
            // 
            this.btnSeleccionarNivel.Location = new System.Drawing.Point(157, 47);
            this.btnSeleccionarNivel.Name = "btnSeleccionarNivel";
            this.btnSeleccionarNivel.Size = new System.Drawing.Size(270, 41);
            this.btnSeleccionarNivel.TabIndex = 0;
            this.btnSeleccionarNivel.Text = "Seleccionar nivel";
            this.btnSeleccionarNivel.UseVisualStyleBackColor = true;
            this.btnSeleccionarNivel.Click += new System.EventHandler(this.btnSeleccionarNivel_Click);
            // 
            // btnTienda
            // 
            this.btnTienda.Location = new System.Drawing.Point(157, 134);
            this.btnTienda.Name = "btnTienda";
            this.btnTienda.Size = new System.Drawing.Size(270, 41);
            this.btnTienda.TabIndex = 1;
            this.btnTienda.Text = "Tienda";
            this.btnTienda.UseVisualStyleBackColor = true;
            this.btnTienda.Click += new System.EventHandler(this.btnTienda_Click);
            // 
            // btnMejorarCarta
            // 
            this.btnMejorarCarta.Location = new System.Drawing.Point(157, 219);
            this.btnMejorarCarta.Name = "btnMejorarCarta";
            this.btnMejorarCarta.Size = new System.Drawing.Size(270, 41);
            this.btnMejorarCarta.TabIndex = 2;
            this.btnMejorarCarta.Text = "Mejorar carta inicial";
            this.btnMejorarCarta.UseVisualStyleBackColor = true;
            this.btnMejorarCarta.Click += new System.EventHandler(this.btnMejorarCarta_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(157, 392);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(270, 41);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEnciclopedia
            // 
            this.btnEnciclopedia.Location = new System.Drawing.Point(157, 306);
            this.btnEnciclopedia.Name = "btnEnciclopedia";
            this.btnEnciclopedia.Size = new System.Drawing.Size(270, 41);
            this.btnEnciclopedia.TabIndex = 5;
            this.btnEnciclopedia.Text = "Enciclopedia";
            this.btnEnciclopedia.UseVisualStyleBackColor = true;
            this.btnEnciclopedia.Click += new System.EventHandler(this.btnEnciclopedia_Click);
            // 
            // SecondaryMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoSecundario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(602, 490);
            this.Controls.Add(this.btnEnciclopedia);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMejorarCarta);
            this.Controls.Add(this.btnTienda);
            this.Controls.Add(this.btnSeleccionarNivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SecondaryMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu secundario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarNivel;
        private System.Windows.Forms.Button btnTienda;
        private System.Windows.Forms.Button btnMejorarCarta;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEnciclopedia;
    }
}