/**************************************************************************
 *                                                                        *
 *  File:        CheckInformations.cs                                     *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: Checks for user data and database.                       *
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
using DataBaseConnection;

namespace DataBaseInfo
{
    public class CheckInformations
    {
        #region Private Members and Variables

        private DataBase _db = DataBase.Instance;
        private MySqlDataAdapter _adapter = new MySqlDataAdapter();

        #endregion


        #region Public Boolean Checks
        /// <summary>
        /// Check if the email exists or not in Univeristy Data Base
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Boolean checkExistingEmail(string email)
        {

            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @email", _db.getConnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            _adapter.SelectCommand = cmd;

            _adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                throw new CheckInformationsException("The email is not in the Universitatii Gheorghe Asachi \n database.");
            }
        }

        /// <summary>
        /// Check if the pin it's the same with the one from DataBase
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        public Boolean checkPin(string pin)
        {

            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `pin` = @pin", _db.getConnection());

            cmd.Parameters.Add("@pin", MySqlDbType.VarChar).Value = pin;

            _adapter.SelectCommand = cmd;

            _adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //if the pin it's corect
                return true;
            }
            else
            {
                //if the pin it is not corect
                throw new CheckInformationsException("Wrong PIN !");
                //return false;
            }
        }

        /// <summary>
        /// Check if the account was already created.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="check"></param>
        /// <returns></returns>
        public Boolean checkAccountAlreadyRegistred(string email)
        {
            int check = 0;
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `validare` = @validare and `email` = @email", _db.getConnection());

            cmd.Parameters.Add("@validare", MySqlDbType.VarChar).Value = check;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            _adapter.SelectCommand = cmd;

            _adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //0 if the account wasn't created
                return true;
            }
            else
            {
                //1 if the account was created
                throw new CheckInformationsException("The account has already been validated.");
                //return false;
            }
        }

        /// <summary>
        /// Check if the user exists or not in data base.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Boolean checkLogin(string email, string pass)
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `users` WHERE `email` = @email and `parola` = @parola", _db.getConnection());

            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@parola", MySqlDbType.VarChar).Value = pass;

            _adapter.SelectCommand = cmd;

            _adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                //if exists , then same id (index) and email which i need in other functions
                UserDetails.Id = table.Rows[0][0].ToString();
                UserDetails.Username = table.Rows[0][1].ToString();

                return true;
            }
            else
            {
                //check if the field "email" it's empty
                if (email.Trim().Equals(""))
                {
                    throw new CheckInformationsException("Type the email!");

                }
                //check if the field "password" it's empty
                else if (pass.Trim().Equals(""))
                {
                    throw new CheckInformationsException("Type the password!");
                }
                //
                else
                {
                    throw new CheckInformationsException("Wrong data !");
                }
                //return false;
            }

        }

        /// <summary>
        /// Check Loghin Status , if the user it's logged or not.
        /// </summary>
        /// <returns></returns>
        public Boolean getLoginStatus()
        {
            if (string.IsNullOrEmpty(UserDetails.Username) || string.IsNullOrEmpty(UserDetails.Id))
            {
                throw new CheckInformationsException("You are not Logged !");
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Check if the shopping cart it's empty or not.
        /// </summary>
        /// <returns></returns>
        public Boolean checkCartStatus()
        {
            DataTable table = new DataTable();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM ip_proiect.cos_cumparaturi WHERE id_comanda= @id_comanda", _db.getConnection());
            cmd.Parameters.Add("@id_comanda", MySqlDbType.VarChar).Value = UserDetails.Id;

            _adapter.SelectCommand = cmd;

            _adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                throw new CheckInformationsException("The shopping cart it's empty!");
            }
        }
        #endregion
    }
}

