/**************************************************************************
 *                                                                        *
 *  File:        InregistrareUC.cs                                        *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: Registration.                                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using MySqlConnector;
using System;
using System.Windows.Forms;
using DataBaseConnection;
using DataBaseInfo;

namespace Cantina
{
    public partial class InregistrareUC : UserControl
    {
        #region Private Members and Variables
        private CheckInformations _ver = new CheckInformations();
        private DataBase _db = DataBase.Instance;
        #endregion

        #region Inregistrare Interface
        public InregistrareUC()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            this.SendToBack();

        }

        private void InregistrareUC_Load(object sender, EventArgs e)
        {

        }


        // verific daca emailul introdus se afla sau nu in baza de date a universitatii

        public void freeBox()
        {
            textBoxEmail.Text = "";
            textBoxParola.Text = "";
            textBoxParolaRepeta.Text = "";
            textBoxPin.Text = "";
        }

        private void buttonInregistrare_Click(object sender, EventArgs e)
        {
            if (textBoxParola.Text.Equals(textBoxParolaRepeta.Text))
            {
                try
                {
                    _ver.checkExistingEmail(textBoxEmail.Text);
                    MySqlCommand cmd = new MySqlCommand("UPDATE users SET parola=@parola WHERE email=@email", _db.getConnection());
                    MySqlCommand verificare = new MySqlCommand("UPDATE users SET validare=@validare WHERE email=@email", _db.getConnection());

                    cmd.Parameters.Add("@parola", MySqlDbType.VarChar).Value = textBoxParola.Text;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                    verificare.Parameters.Add("@validare", MySqlDbType.VarChar).Value = 1;
                    verificare.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBoxEmail.Text;

                    _ver.checkPin(textBoxPin.Text);
                    _ver.checkAccountAlreadyRegistred(textBoxEmail.Text);
                    _db.openConnection();
                    // execut query-ul
                    if (verificare.ExecuteNonQuery() == 1 && cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Contul a fost validat cu succes!", "Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                    _db.closeConnection();
                    freeBox();
                }
                catch (CheckInformationsException ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
