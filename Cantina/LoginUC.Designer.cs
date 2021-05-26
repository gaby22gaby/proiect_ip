
namespace Cantina
{
    partial class LoginUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAutentificare = new System.Windows.Forms.Button();
            this.buttonInregistrareLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAutentificare
            // 
            this.buttonAutentificare.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAutentificare.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonAutentificare.Location = new System.Drawing.Point(318, 515);
            this.buttonAutentificare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAutentificare.Name = "buttonAutentificare";
            this.buttonAutentificare.Size = new System.Drawing.Size(330, 49);
            this.buttonAutentificare.TabIndex = 2;
            this.buttonAutentificare.Text = "Autentificare";
            this.buttonAutentificare.UseVisualStyleBackColor = true;
            this.buttonAutentificare.Click += new System.EventHandler(this.buttonAutentificare_Click);
            // 
            // buttonInregistrareLogin
            // 
            this.buttonInregistrareLogin.Font = new System.Drawing.Font("Cambria", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInregistrareLogin.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonInregistrareLogin.Location = new System.Drawing.Point(318, 574);
            this.buttonInregistrareLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInregistrareLogin.Name = "buttonInregistrareLogin";
            this.buttonInregistrareLogin.Size = new System.Drawing.Size(330, 49);
            this.buttonInregistrareLogin.TabIndex = 2;
            this.buttonInregistrareLogin.Text = "Inregistrare";
            this.buttonInregistrareLogin.UseVisualStyleBackColor = true;
            this.buttonInregistrareLogin.Click += new System.EventHandler(this.buttonInregistrareLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(310, 277);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(310, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Parola:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEmail.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(318, 328);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(330, 31);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxParola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxParola.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxParola.Location = new System.Drawing.Point(318, 451);
            this.textBoxParola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(330, 32);
            this.textBoxParola.TabIndex = 6;
            this.textBoxParola.UseSystemPasswordChar = true;
            this.textBoxParola.TextChanged += new System.EventHandler(this.textBoxParola_TextChanged);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cantina.Properties.Resources.CaminImg2;
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInregistrareLogin);
            this.Controls.Add(this.buttonAutentificare);
            this.Controls.Add(this.textBoxEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(1113, 809);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAutentificare;
        private System.Windows.Forms.Button buttonInregistrareLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxParola;
    }
}
