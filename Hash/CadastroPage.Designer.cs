namespace Hash
{
    partial class CadastroPage
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
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SenhaLabel = new System.Windows.Forms.Label();
            this.SenhaTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Location = new System.Drawing.Point(40, 106);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(75, 23);
            this.CadastrarButton.TabIndex = 0;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // LoginTxt
            // 
            this.LoginTxt.Location = new System.Drawing.Point(15, 25);
            this.LoginTxt.MaxLength = 4;
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(100, 20);
            this.LoginTxt.TabIndex = 1;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(12, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(33, 13);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Login";
            // 
            // SenhaLabel
            // 
            this.SenhaLabel.AutoSize = true;
            this.SenhaLabel.Location = new System.Drawing.Point(12, 52);
            this.SenhaLabel.Name = "SenhaLabel";
            this.SenhaLabel.Size = new System.Drawing.Size(38, 13);
            this.SenhaLabel.TabIndex = 4;
            this.SenhaLabel.Text = "Senha";
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.Location = new System.Drawing.Point(15, 68);
            this.SenhaTxt.MaxLength = 4;
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.PasswordChar = '?';
            this.SenhaTxt.Size = new System.Drawing.Size(100, 20);
            this.SenhaTxt.TabIndex = 3;
            this.SenhaTxt.UseSystemPasswordChar = true;
            // 
            // CadastroPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(127, 135);
            this.Controls.Add(this.SenhaLabel);
            this.Controls.Add(this.SenhaTxt);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.CadastrarButton);
            this.Name = "CadastroPage";
            this.Text = "CadastroPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label SenhaLabel;
        private System.Windows.Forms.TextBox SenhaTxt;
    }
}