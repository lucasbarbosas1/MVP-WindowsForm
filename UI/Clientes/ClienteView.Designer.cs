namespace MVP.UI.Clientes
{
    partial class ClienteView
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
            this.texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(12, 12);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(100, 20);
            this.texto.TabIndex = 0;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 249);
            this.Controls.Add(this.texto);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto;
    }
}