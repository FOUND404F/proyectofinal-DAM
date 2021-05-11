namespace Prueba
{
    partial class UserControlCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMana = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDescripcionCarta = new System.Windows.Forms.RichTextBox();
            this.lblNombreCarta = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMana
            // 
            this.lblMana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMana.AutoSize = true;
            this.lblMana.BackColor = System.Drawing.Color.White;
            this.lblMana.Location = new System.Drawing.Point(15, 14);
            this.lblMana.Name = "lblMana";
            this.lblMana.Size = new System.Drawing.Size(13, 13);
            this.lblMana.TabIndex = 3;
            this.lblMana.Text = "1";
            this.lblMana.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseDown);
            this.lblMana.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseMove);
            this.lblMana.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseUp);
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(64, 196);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseDown);
            this.lblTipo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseMove);
            this.lblTipo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseUp);
            // 
            // lblDescripcionCarta
            // 
            this.lblDescripcionCarta.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescripcionCarta.Enabled = false;
            this.lblDescripcionCarta.Location = new System.Drawing.Point(3, 149);
            this.lblDescripcionCarta.Name = "lblDescripcionCarta";
            this.lblDescripcionCarta.ReadOnly = true;
            this.lblDescripcionCarta.Size = new System.Drawing.Size(134, 44);
            this.lblDescripcionCarta.TabIndex = 6;
            this.lblDescripcionCarta.Text = "";
            // 
            // lblNombreCarta
            // 
            this.lblNombreCarta.Enabled = false;
            this.lblNombreCarta.Location = new System.Drawing.Point(40, 7);
            this.lblNombreCarta.Name = "lblNombreCarta";
            this.lblNombreCarta.Size = new System.Drawing.Size(97, 37);
            this.lblNombreCarta.TabIndex = 7;
            this.lblNombreCarta.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(21, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Prueba.Properties.Resources.cartajpg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_MouseUp);
            // 
            // UserControlCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNombreCarta);
            this.Controls.Add(this.lblDescripcionCarta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblMana);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlCard";
            this.Size = new System.Drawing.Size(140, 220);
            this.Load += new System.EventHandler(this.UserControlCarta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMana;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox lblDescripcionCarta;
        private System.Windows.Forms.RichTextBox lblNombreCarta;
    }
}
