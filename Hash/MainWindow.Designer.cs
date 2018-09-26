namespace Hash
{
    partial class MainWindow
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BruteForceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BruteForceButton
            // 
            this.BruteForceButton.Location = new System.Drawing.Point(12, 12);
            this.BruteForceButton.Name = "BruteForceButton";
            this.BruteForceButton.Size = new System.Drawing.Size(75, 23);
            this.BruteForceButton.TabIndex = 0;
            this.BruteForceButton.Text = "Brute Force";
            this.BruteForceButton.UseVisualStyleBackColor = true;
            this.BruteForceButton.Click += new System.EventHandler(this.BruteForceButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BruteForceButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BruteForceButton;
    }
}

