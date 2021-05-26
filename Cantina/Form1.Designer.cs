
namespace Cantina
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDelogare = new System.Windows.Forms.Button();
            this.richTextBoxContact = new System.Windows.Forms.RichTextBox();
            this.buttonContact = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMeniu = new System.Windows.Forms.Button();
            this.buttonLocatie = new System.Windows.Forms.Button();
            this.buttonOrar = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.cosCumparaturiUC1 = new Cantina.ShoppingCartUC();
            this.locatie1 = new Cantina.Locatie();
            this.orarUC1 = new Cantina.OrarUC();
            this.meniuUC1 = new Cantina.MeniuUC();
            this.inregistrareUC1 = new Cantina.InregistrareUC();
            this.loginUC1 = new Cantina.LoginUC();
            this.integistrareUC1 = new Cantina.InregistrareUC();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelMenu.Controls.Add(this.buttonDelogare);
            this.panelMenu.Controls.Add(this.richTextBoxContact);
            this.panelMenu.Controls.Add(this.buttonContact);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.buttonMeniu);
            this.panelMenu.Controls.Add(this.buttonLocatie);
            this.panelMenu.Controls.Add(this.buttonOrar);
            this.panelMenu.Controls.Add(this.buttonLogin);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1058, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(228, 811);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Tag = "97,527";
            // 
            // buttonDelogare
            // 
            this.buttonDelogare.BackColor = System.Drawing.Color.Maroon;
            this.buttonDelogare.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonDelogare.ForeColor = System.Drawing.Color.Yellow;
            this.buttonDelogare.Location = new System.Drawing.Point(37, 324);
            this.buttonDelogare.Name = "buttonDelogare";
            this.buttonDelogare.Size = new System.Drawing.Size(159, 51);
            this.buttonDelogare.TabIndex = 8;
            this.buttonDelogare.Text = "Delogare";
            this.buttonDelogare.UseVisualStyleBackColor = false;
            this.buttonDelogare.Click += new System.EventHandler(this.buttonDelogare_Click);
            // 
            // richTextBoxContact
            // 
            this.richTextBoxContact.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxContact.Location = new System.Drawing.Point(37, 619);
            this.richTextBoxContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxContact.Name = "richTextBoxContact";
            this.richTextBoxContact.Size = new System.Drawing.Size(148, 119);
            this.richTextBoxContact.TabIndex = 3;
            this.richTextBoxContact.Text = "Telefon/Fax: 0232.271.288\nE-mail: dss@tuiasi.ro\nProgramul de lucru este \nde luni " +
    "până vineri, între\n orele 07.30-15.30.";
            // 
            // buttonContact
            // 
            this.buttonContact.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonContact.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContact.ForeColor = System.Drawing.Color.Gold;
            this.buttonContact.Location = new System.Drawing.Point(37, 560);
            this.buttonContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonContact.Name = "buttonContact";
            this.buttonContact.Size = new System.Drawing.Size(159, 49);
            this.buttonContact.TabIndex = 2;
            this.buttonContact.Text = "Contact";
            this.buttonContact.UseVisualStyleBackColor = false;
            this.buttonContact.Click += new System.EventHandler(this.buttonContact_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gold;
            this.buttonExit.Location = new System.Drawing.Point(37, 757);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(159, 49);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMeniu
            // 
            this.buttonMeniu.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonMeniu.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeniu.ForeColor = System.Drawing.Color.Gold;
            this.buttonMeniu.Location = new System.Drawing.Point(37, 501);
            this.buttonMeniu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonMeniu.Name = "buttonMeniu";
            this.buttonMeniu.Size = new System.Drawing.Size(159, 49);
            this.buttonMeniu.TabIndex = 1;
            this.buttonMeniu.Text = "Meniu";
            this.buttonMeniu.UseVisualStyleBackColor = false;
            this.buttonMeniu.Click += new System.EventHandler(this.buttonMeniu_Click);
            // 
            // buttonLocatie
            // 
            this.buttonLocatie.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLocatie.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLocatie.ForeColor = System.Drawing.Color.Gold;
            this.buttonLocatie.Location = new System.Drawing.Point(37, 442);
            this.buttonLocatie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLocatie.Name = "buttonLocatie";
            this.buttonLocatie.Size = new System.Drawing.Size(159, 49);
            this.buttonLocatie.TabIndex = 1;
            this.buttonLocatie.Text = "Locatie";
            this.buttonLocatie.UseVisualStyleBackColor = false;
            this.buttonLocatie.Click += new System.EventHandler(this.buttonLocatie_Click);
            // 
            // buttonOrar
            // 
            this.buttonOrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonOrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrar.ForeColor = System.Drawing.Color.Gold;
            this.buttonOrar.Location = new System.Drawing.Point(37, 383);
            this.buttonOrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOrar.Name = "buttonOrar";
            this.buttonOrar.Size = new System.Drawing.Size(159, 49);
            this.buttonOrar.TabIndex = 1;
            this.buttonOrar.Text = "Orar";
            this.buttonOrar.UseVisualStyleBackColor = false;
            this.buttonOrar.Click += new System.EventHandler(this.buttonOrar_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Gold;
            this.buttonLogin.Location = new System.Drawing.Point(37, 324);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(159, 49);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cantina.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cosCumparaturiUC1);
            this.panel.Controls.Add(this.locatie1);
            this.panel.Controls.Add(this.orarUC1);
            this.panel.Controls.Add(this.meniuUC1);
            this.panel.Controls.Add(this.inregistrareUC1);
            this.panel.Controls.Add(this.loginUC1);
            this.panel.Controls.Add(this.integistrareUC1);
            this.panel.Controls.Add(this.pictureBoxLogo);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1058, 811);
            this.panel.TabIndex = 1;
            // 
            // cosCumparaturiUC1
            // 
            this.cosCumparaturiUC1.Location = new System.Drawing.Point(900, 604);
            this.cosCumparaturiUC1.Name = "cosCumparaturiUC1";
            this.cosCumparaturiUC1.Size = new System.Drawing.Size(1254, 972);
            this.cosCumparaturiUC1.TabIndex = 8;
            // 
            // locatie1
            // 
            this.locatie1.Location = new System.Drawing.Point(-9, 769);
            this.locatie1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.locatie1.Name = "locatie1";
            this.locatie1.Size = new System.Drawing.Size(1113, 809);
            this.locatie1.TabIndex = 7;
            // 
            // orarUC1
            // 
            this.orarUC1.Location = new System.Drawing.Point(-9, 568);
            this.orarUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.orarUC1.Name = "orarUC1";
            this.orarUC1.Size = new System.Drawing.Size(1113, 809);
            this.orarUC1.TabIndex = 6;
            // 
            // meniuUC1
            // 
            this.meniuUC1.BackColor = System.Drawing.Color.Snow;
            this.meniuUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("meniuUC1.BackgroundImage")));
            this.meniuUC1.Cumparaturi = null;
            this.meniuUC1.deschideCos = null;
            this.meniuUC1.Location = new System.Drawing.Point(-9, 397);
            this.meniuUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.meniuUC1.Name = "meniuUC1";
            this.meniuUC1.Size = new System.Drawing.Size(1113, 809);
            this.meniuUC1.TabIndex = 5;
            // 
            // inregistrareUC1
            // 
            this.inregistrareUC1.Location = new System.Drawing.Point(0, 278);
            this.inregistrareUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.inregistrareUC1.Name = "inregistrareUC1";
            this.inregistrareUC1.Size = new System.Drawing.Size(1113, 809);
            this.inregistrareUC1.TabIndex = 4;
            // 
            // loginUC1
            // 
            this.loginUC1._inreg = null;
            this.loginUC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginUC1.BackgroundImage")));
            this.loginUC1.ButonLogin = null;
            this.loginUC1.ButonLogout = null;
            this.loginUC1.Location = new System.Drawing.Point(0, 483);
            this.loginUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.loginUC1.Meniu = null;
            this.loginUC1.Name = "loginUC1";
            this.loginUC1.Size = new System.Drawing.Size(1113, 809);
            this.loginUC1.TabIndex = 3;
            // 
            // integistrareUC1
            // 
            this.integistrareUC1.Location = new System.Drawing.Point(879, 138);
            this.integistrareUC1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.integistrareUC1.Name = "integistrareUC1";
            this.integistrareUC1.Size = new System.Drawing.Size(12, 12);
            this.integistrareUC1.TabIndex = 2;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Cantina.Properties.Resources.tudor_logo_c2_min;
            this.pictureBoxLogo.Location = new System.Drawing.Point(101, 216);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(915, 365);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 811);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMeniu;
        private System.Windows.Forms.Button buttonLocatie;
        private System.Windows.Forms.Button buttonOrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonContact;
        private InregistrareUC integistrareUC1;
        private LoginUC loginUC1;
        private InregistrareUC inregistrareUC1;
        private MeniuUC meniuUC1;
        private OrarUC orarUC1;
        private Locatie locatie1;
        private ShoppingCartUC cosCumparaturi;
        private System.Windows.Forms.RichTextBox richTextBoxContact;
        public System.Windows.Forms.Button buttonLogin;
        public System.Windows.Forms.Button buttonVeziCos;
        private System.Windows.Forms.Button buttonDelogare;
        private ShoppingCartUC cosCumparaturiUC1;
    }
}

