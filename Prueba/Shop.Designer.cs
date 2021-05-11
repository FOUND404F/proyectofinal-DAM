namespace Prueba
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.producto1 = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.producto2 = new System.Windows.Forms.Button();
            this.producto3 = new System.Windows.Forms.Button();
            this.producto4 = new System.Windows.Forms.Button();
            this.textDinero = new System.Windows.Forms.Label();
            this.imagen1 = new System.Windows.Forms.PictureBox();
            this.imagen2 = new System.Windows.Forms.PictureBox();
            this.imagen3 = new System.Windows.Forms.PictureBox();
            this.imagen4 = new System.Windows.Forms.PictureBox();
            this.lblDinero = new System.Windows.Forms.Label();
            this.cajaTexto = new System.Windows.Forms.RichTextBox();
            this.imagenDueñoTienda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDueñoTienda)).BeginInit();
            this.SuspendLayout();
            // 
            // producto1
            // 
            this.producto1.Location = new System.Drawing.Point(56, 224);
            this.producto1.Name = "producto1";
            this.producto1.Size = new System.Drawing.Size(75, 23);
            this.producto1.TabIndex = 9;
            this.producto1.Text = "Comprar";
            this.producto1.UseVisualStyleBackColor = true;
            this.producto1.Click += new System.EventHandler(this.comprar);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(713, 340);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // producto2
            // 
            this.producto2.Location = new System.Drawing.Point(223, 224);
            this.producto2.Name = "producto2";
            this.producto2.Size = new System.Drawing.Size(75, 23);
            this.producto2.TabIndex = 11;
            this.producto2.Text = "Comprar";
            this.producto2.UseVisualStyleBackColor = true;
            this.producto2.Click += new System.EventHandler(this.comprar);
            // 
            // producto3
            // 
            this.producto3.Location = new System.Drawing.Point(386, 224);
            this.producto3.Name = "producto3";
            this.producto3.Size = new System.Drawing.Size(75, 23);
            this.producto3.TabIndex = 12;
            this.producto3.Text = "Comprar";
            this.producto3.UseVisualStyleBackColor = true;
            this.producto3.Click += new System.EventHandler(this.comprar);
            // 
            // producto4
            // 
            this.producto4.Location = new System.Drawing.Point(552, 224);
            this.producto4.Name = "producto4";
            this.producto4.Size = new System.Drawing.Size(75, 23);
            this.producto4.TabIndex = 13;
            this.producto4.Text = "Comprar";
            this.producto4.UseVisualStyleBackColor = true;
            this.producto4.Click += new System.EventHandler(this.comprar);
            // 
            // textDinero
            // 
            this.textDinero.AutoSize = true;
            this.textDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDinero.Location = new System.Drawing.Point(759, 9);
            this.textDinero.Name = "textDinero";
            this.textDinero.Size = new System.Drawing.Size(18, 18);
            this.textDinero.TabIndex = 14;
            this.textDinero.Text = "X";
            // 
            // imagen1
            // 
            this.imagen1.Image = global::Prueba.Properties.Resources.Estallido;
            this.imagen1.Location = new System.Drawing.Point(28, 83);
            this.imagen1.Name = "imagen1";
            this.imagen1.Size = new System.Drawing.Size(130, 135);
            this.imagen1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen1.TabIndex = 15;
            this.imagen1.TabStop = false;
            this.imagen1.Click += new System.EventHandler(this.imagen1_Click);
            // 
            // imagen2
            // 
            this.imagen2.Image = global::Prueba.Properties.Resources.Curar_3;
            this.imagen2.Location = new System.Drawing.Point(192, 83);
            this.imagen2.Name = "imagen2";
            this.imagen2.Size = new System.Drawing.Size(130, 135);
            this.imagen2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen2.TabIndex = 16;
            this.imagen2.TabStop = false;
            this.imagen2.Click += new System.EventHandler(this.imagen2_Click);
            // 
            // imagen3
            // 
            this.imagen3.Image = global::Prueba.Properties.Resources.Asalto;
            this.imagen3.Location = new System.Drawing.Point(357, 83);
            this.imagen3.Name = "imagen3";
            this.imagen3.Size = new System.Drawing.Size(130, 135);
            this.imagen3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen3.TabIndex = 17;
            this.imagen3.TabStop = false;
            this.imagen3.Click += new System.EventHandler(this.imagen3_Click);
            // 
            // imagen4
            // 
            this.imagen4.Image = global::Prueba.Properties.Resources.Infeccion;
            this.imagen4.Location = new System.Drawing.Point(520, 83);
            this.imagen4.Name = "imagen4";
            this.imagen4.Size = new System.Drawing.Size(130, 135);
            this.imagen4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen4.TabIndex = 18;
            this.imagen4.TabStop = false;
            this.imagen4.Click += new System.EventHandler(this.imagen4_Click);
            // 
            // lblDinero
            // 
            this.lblDinero.AutoSize = true;
            this.lblDinero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinero.Location = new System.Drawing.Point(697, 9);
            this.lblDinero.Name = "lblDinero";
            this.lblDinero.Size = new System.Drawing.Size(56, 18);
            this.lblDinero.TabIndex = 19;
            this.lblDinero.Text = "Dinero:";
            // 
            // cajaTexto
            // 
            this.cajaTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaTexto.Location = new System.Drawing.Point(12, 369);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.Size = new System.Drawing.Size(776, 60);
            this.cajaTexto.TabIndex = 20;
            this.cajaTexto.Text = "";
            // 
            // imagenDueñoTienda
            // 
            this.imagenDueñoTienda.BackColor = System.Drawing.Color.Transparent;
            this.imagenDueñoTienda.Image = ((System.Drawing.Image)(resources.GetObject("imagenDueñoTienda.Image")));
            this.imagenDueñoTienda.Location = new System.Drawing.Point(47, 253);
            this.imagenDueñoTienda.Name = "imagenDueñoTienda";
            this.imagenDueñoTienda.Size = new System.Drawing.Size(129, 101);
            this.imagenDueñoTienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenDueñoTienda.TabIndex = 21;
            this.imagenDueñoTienda.TabStop = false;
            // 
            // Tienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Prueba.Properties.Resources.fondoTienda;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.imagenDueñoTienda);
            this.Controls.Add(this.cajaTexto);
            this.Controls.Add(this.lblDinero);
            this.Controls.Add(this.imagen4);
            this.Controls.Add(this.imagen3);
            this.Controls.Add(this.imagen2);
            this.Controls.Add(this.imagen1);
            this.Controls.Add(this.textDinero);
            this.Controls.Add(this.producto4);
            this.Controls.Add(this.producto3);
            this.Controls.Add(this.producto2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.producto1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda";
            ((System.ComponentModel.ISupportInitialize)(this.imagen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenDueñoTienda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button producto1;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button producto2;
        private System.Windows.Forms.Button producto3;
        private System.Windows.Forms.Button producto4;
        private System.Windows.Forms.Label textDinero;
        private System.Windows.Forms.PictureBox imagen1;
        private System.Windows.Forms.PictureBox imagen2;
        private System.Windows.Forms.PictureBox imagen3;
        private System.Windows.Forms.PictureBox imagen4;
        private System.Windows.Forms.Label lblDinero;
        private System.Windows.Forms.RichTextBox cajaTexto;
        private System.Windows.Forms.PictureBox imagenDueñoTienda;
    }
}