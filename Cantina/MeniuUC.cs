/**************************************************************************
 *                                                                        *
 *  File:        MeniuUC.cs                                               *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: The interface control for MeniuUC                        *
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
using System.Data;
using System.Windows.Forms;
using DataBaseInfo;
using DataBaseConnection;

namespace Cantina
{
    public partial class MeniuUC : UserControl
    {
        #region Private Members and Variables
        private DataBase _db = DataBase.Instance;
        private MySqlDataAdapter _adapter = new MySqlDataAdapter();
        private CheckInformations _ver = new CheckInformations();
        public ShoppingCartUC Cumparaturi { get; set; }
        public Button deschideCos { get; set; }

        #endregion

        #region Meniu Interface
        public MeniuUC()
        {
            InitializeComponent();
        }

        private void dataGridViewMeniu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string RefreshMeniu()
        {
            if (string.IsNullOrEmpty(UserDetails.Username))
            {
                return this.textBoxStatus.SelectedText = "Neautentificat";
            }
            else
            {
                textBoxStatus.Text = "";
                return this.textBoxStatus.SelectedText = "Autentificat ca: " + UserDetails.Username;
            }
        }

        public void MeniuUC_Load(object sender, EventArgs e)
        {
           try
           {
               MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM ip_proiect.food", _db.getConnection());
               _db.openConnection();
               DataSet ds = new DataSet();
               adapter.Fill(ds, "food");
                //display all collumns from ip_proiect.food
               dataGridView1.DataSource = ds.Tables["food"];
               _db.closeConnection();
                //refresh meniu after login for a correct "textBoxStatus" print
                RefreshMeniu();

            }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add in shopping cart
            if ( e.ColumnIndex == 0)
            {
                try
                {
                    DataTable table = new DataTable();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `cos_cumparaturi`(`id_comanda`, `email`, `food_id`, `denumire`) VALUES (@id_comanda, @email, @food_id, @denumire)", _db.getConnection());

                    command.Parameters.Add("@food_id", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    command.Parameters.Add("@denumire", MySqlDbType.VarChar).Value = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    command.Parameters.Add("@id_comanda", MySqlDbType.VarChar).Value = UserDetails.Id;
                    if (string.IsNullOrEmpty(UserDetails.Username))
                        MessageBox.Show("You have to Log in !");
                    else                   
                        command.Parameters.Add("@email", MySqlDbType.VarChar).Value = UserDetails.Username;


                    _adapter.SelectCommand = command;
                    _adapter.Fill(table);

                    MessageBox.Show("The product has been added to cart !");
                } catch(MySqlException exception)
                {
                    //??
                }
            }
            else
            {
                return;
            }
        }


        private void textBoxStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVeziCos_Click(object sender, EventArgs e)
        {
            try
            {    //check if it's logged and if the shopping cart it's empty or not         
                _ver.getLoginStatus();
                _ver.checkCartStatus();
                this.Hide();
                Cumparaturi.Enabled = true;
                Cumparaturi.Show();
                Cumparaturi.Dock = DockStyle.Fill;
                Cumparaturi.BringToFront();
            }
            catch (CheckInformationsException ex)
            { MessageBox.Show(ex.Message); }

        }

        #endregion
    }
}
