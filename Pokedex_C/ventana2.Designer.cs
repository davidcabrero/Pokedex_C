
namespace Pokedex_C
{
    partial class ventana2
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
            this.cajaDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cajaDescripcion
            // 
            this.cajaDescripcion.Location = new System.Drawing.Point(126, 52);
            this.cajaDescripcion.Name = "cajaDescripcion";
            this.cajaDescripcion.Size = new System.Drawing.Size(497, 280);
            this.cajaDescripcion.TabIndex = 0;
            this.cajaDescripcion.Text = "label1";
            // 
            // ventana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cajaDescripcion);
            this.Name = "ventana2";
            this.Text = "ventana2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label cajaDescripcion;
    }
}