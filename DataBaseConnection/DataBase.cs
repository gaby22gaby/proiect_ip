/**************************************************************************
 *                                                                        *
 *  File:        DataBase.cs                                              *
 *  Copyright:   (c) 2021 , Balta Gabriel-Constantin                      *
 *  E-mail:      gabriel-constantin.balta@student.tuiasi.ro               *
 *  Description: Here are made the conection at DB and new object for     * 
 *               saving login data.                                       *
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


namespace DataBaseConnection
{
    public class DataBase
    {
        #region Private Member Variables and Constants
        private static string _host = "server=localhost;port=3306;username=root;password=;database=ip_proiect";
        // creare noua conexiune
        private MySqlConnection _connection;

        private static DataBase instance = new DataBase();
        private DataBase() {
            _connection = new MySqlConnection(_host);
        }
        #endregion

        #region Constructors
        public static DataBase Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataBase();
                return instance;
            }
        }
        /// <summary>
        /// new function to open conection
        /// </summary>
        public void openConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        /// <summary>
        /// new function to close the conection
        /// </summary>
        public void closeConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }


        #endregion

        #region Public Methods
        /// <summary>
        /// Create a function which return the connection
        /// </summary>
        /// <returns> Connection </returns>
        public MySqlConnection getConnection()
        {
            return _connection;
        }
        /// <summary>
        /// Check the conection
        /// </summary>
        /// <returns> conected or not </returns>
        public bool CheckDB_Conn()
        {
//            var conn_info1 = _host;
            bool isConn = false;
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(_host);
                conn.Open();
                isConn = true;
            }
            catch (ArgumentException a_ex)
            {
                //Console.WriteLine("Check the Connection String.");
            }
            catch (MySqlException ex)
            {

                isConn = false;
                switch (ex.Number)
                {
                    case 1042: // Unable to connect to any of the specified MySQL hosts (Check Server,Port)
                        break;
                    case 0: // Access denied (Check DB name,username,password)
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return isConn;
        }
        #endregion
    }
    /// <summary>
    /// new class to get and set the userid and email.
    /// </summary>
    public class UserDetails
    {
        private static string _username;
        private static string _id;

        public static string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public static string Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
    }
}
