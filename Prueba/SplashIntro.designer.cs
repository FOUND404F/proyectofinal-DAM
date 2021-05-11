/*
 * NOMBRE Y APELLIDOS..... Raquel Heredia Díaz 
 * CURSO..... 2º Desarrollo de aplicaciones multiplataforma
 * MODALIDAD..... Trabajo de fin de grado
*/
namespace Prueba
{
    partial class SplashIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashIntro));
            this.timerBarraCarga = new System.Windows.Forms.Timer(this.components);
            this.barraCarga = new System.Windows.Forms.ProgressBar();
            this.labelLoading = new System.Windows.Forms.Label();
            this.timerMensajeCarga = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barraCarga
            // 
            this.barraCarga.Location = new System.Drawing.Point(9, 424);
            this.barraCarga.Margin = new System.Windows.Forms.Padding(2);
            this.barraCarga.Name = "barraCarga";
            this.barraCarga.Size = new System.Drawing.Size(360, 24);
            this.barraCarga.TabIndex = 2;
            // 
            // labelLoading
            // 
            this.labelLoading.BackColor = System.Drawing.SystemColors.Window;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(9, 390);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(360, 23);
            this.labelLoading.TabIndex = 3;
            this.labelLoading.Text = "Cargando . . .";
            // 
            // timerMensajeCarga
            // 
            this.timerMensajeCarga.Tick += new System.EventHandler(this.timerMensajeCarga_Tick);
            // 
            // SplashIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 457);
            this.ControlBox = false;
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.barraCarga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de carga";
            this.Load += new System.EventHandler(this.SplashIntro_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerBarraCarga;
        private System.Windows.Forms.ProgressBar barraCarga;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Timer timerMensajeCarga;
       // private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}