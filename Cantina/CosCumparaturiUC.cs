/**************************************************************************
 *                                                                        *
 *  File:        CosCumparaturi.cs                                        *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: shopping cart                                            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using DataBaseConnection;
using DataBaseInfo;
using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Cantina
{
    public partial class ShoppingCartUC : UserControl
    {
        #region Private Members and Variables
        private DataBase _db = DataBase.Instance;
        private MySqlDataAdapter _adapter = new MySqlDataAdapter();
        #endregion

        #region Shopping Cart Interface
        public ShoppingCartUC()
        {
            InitializeComponent();
        }

        private void shoppingCart_Load(object sender, EventArgs e)
        {
            //daca-i null , apare eroare in Form1 , insa nu-mi afecteaza programul pentru ca nu se poate accesa cosul daca nu sunt logat
            //iar dupa ce ma loghez , id-ul nu mai e null
            if (UserDetails.Id != null)
                try
                {
                
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `denumire` FROM ip_proiect.cos_cumparaturi WHERE `id_comanda`=" + UserDetails.Id, _db.getConnection());
                _db.openConnection();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "cos_cumparaturi");
                dataGridView1.DataSource = ds.Tables["cos_cumparaturi"];

                _db.closeConnection();
            }
            catch (CheckInformationsException ex)
            { MessageBox.Show(ex.Message); }
        }

        private void buttonVeziCos_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();
            //Add in shopping cart
            if (e.ColumnIndex == 0)
            {
                try
                {
                    DataTable table = new DataTable();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `cos_cumparaturi` WHERE `denumire` = @denumire and `id_comanda`="+ UserDetails.Id , _db.getConnection());

                    string food_name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    command.Parameters.Add("@denumire", MySqlDbType.VarChar).Value = food_name;


                    _adapter.SelectCommand = command;
                    _adapter.Fill(table);
                    dataGridView1.Refresh();

                    MessageBox.Show("The produs was deleted.");
                }
                catch (MySqlException exception)
                {
                    //??
                }
            }
            //The others collums are already locked btw.
            else
            {
                return;
            }
            dataGridView1.Refresh();
        }
        #endregion
    }
}
