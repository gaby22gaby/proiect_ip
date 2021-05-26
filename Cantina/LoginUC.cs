/**************************************************************************
 *                                                                        *
 *  File:        LoginUC.cs                                               *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: Login control                                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Windows.Forms;
using DataBaseInfo;

namespace Cantina
{
    
    public partial class LoginUC : UserControl
    {
        #region Private Members , Variables and Constantns
        private CheckInformations _ver = new CheckInformations();
        private String _email;
        private String _parola;
        #endregion

        #region Buttons
        public InregistrareUC _inreg { get; set; }     
        public MeniuUC Meniu { get; set; }
        public Button ButonLogin { get; set; }
        public Button ButonLogout { get; set; }
        #endregion

        #region Login Interface
        public LoginUC()
        {
            InitializeComponent();
        }

        private void buttonInregistrareLogin_Click(object sender, EventArgs e)
        {
            _inreg.Enabled = true;
            _inreg.Show();
            _inreg.Dock = DockStyle.Fill;
            _inreg.BringToFront();
            
        }

        private void buttonAutentificare_Click(object sender, EventArgs e)
        {
            _email = textBoxEmail.Text;
            _parola = textBoxParola.Text;
            try
            {
                _ver.checkLogin(_email, _parola);
                this.Hide();

                Meniu.Enabled = true;
                Meniu.Show();
                Meniu.Dock = DockStyle.Fill;
                Meniu.BringToFront();
                Meniu.RefreshMeniu();
                ButonLogin.Enabled = false;
                ButonLogin.Hide();

                ButonLogout.Enabled = true;
                ButonLogout.Show();

            }
            catch (CheckInformationsException ex)
            { MessageBox.Show(ex.Message); }

        }

        private void meniuUC1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxParola_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
