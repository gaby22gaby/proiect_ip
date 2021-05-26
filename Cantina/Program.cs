/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2021 , Nedelcu Alin                                  *
 *  E-mail:      alin.nedelcu@student.tuiasi.ro                           *
 *  Description: The model class for UserInterface                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
#define ENABLE_MYSQL_CHECK_CON //Check if there is a connection to the database(theoretically no need to check for internet)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseConnection;

namespace Cantina
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBase _check = DataBase.Instance;

#if ENABLE_MYSQL_CHECK_CON
            
            if (!_check.CheckDB_Conn())
            {
                //throw to do
                MessageBox.Show("Connection failed", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
