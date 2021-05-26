/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Form1 : Form
    {
        private MeniuUC _men = new MeniuUC();

        public static Stack<UserControl> StackUC = new Stack<UserControl>();
        UserControl Temp;

        public Form1()
        {
            InitializeComponent();

            //logare
            loginUC1.Enabled = false;
            loginUC1.Hide();
            
            //inregistrare
            integistrareUC1.Enabled = false;
            inregistrareUC1.Hide();

            //meniu
            meniuUC1.Enabled = false;
            meniuUC1.Hide();

            //delogare
            buttonDelogare.Enabled = false;
            buttonDelogare.Hide();

            //orar
            orarUC1.Enabled = false;
            orarUC1.Hide();

            //locatie
            locatie1.Enabled = false;
            locatie1.Hide();

            //cos cumparaturi
            
            cosCumparaturiUC1.Enabled = false;
            cosCumparaturiUC1.Hide();

            meniuUC1.Cumparaturi = cosCumparaturiUC1;

            //contact
            richTextBoxContact.Hide();
            richTextBoxContact.Enabled = false;


            
            loginUC1._inreg = inregistrareUC1;
            loginUC1.Meniu = meniuUC1;
            


     
            loginUC1.ButonLogin = buttonLogin ;
            loginUC1.ButonLogout = buttonDelogare;
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (StackUC.Count == 0)
            {
                loginUC1.Show();
                loginUC1.Enabled = true;
                loginUC1.Dock = DockStyle.Fill;
                loginUC1.BringToFront();

                StackUC.Push(loginUC1);
            }
            else
            {
                Temp = StackUC.Pop();
                Temp.Enabled=false;
                Temp.Hide();

                loginUC1.Show();
                loginUC1.Enabled = true;
                loginUC1.Dock = DockStyle.Fill;
                loginUC1.BringToFront();
            }
            
        }

        private void buttonMeniu_Click(object sender, EventArgs e)
        {
            if (StackUC.Count == 0)
            {
                meniuUC1.Show();
                meniuUC1.Enabled = true;
                meniuUC1.Dock = DockStyle.Fill;
                meniuUC1.BringToFront();

                StackUC.Push(meniuUC1);

            }
            else
            {
                Temp = StackUC.Pop();
                Temp.Enabled = false;
                Temp.Hide();

                meniuUC1.Show();
                meniuUC1.Enabled = true;
                meniuUC1.Dock = DockStyle.Fill;
                meniuUC1.BringToFront();
            }     
        
        }

        private void buttonOrar_Click(object sender, EventArgs e)
        {
            if (StackUC.Count == 0)
            {
                orarUC1.Show();
                orarUC1.Enabled = true;
                orarUC1.Dock = DockStyle.Fill;
                orarUC1.BringToFront();

                StackUC.Push(orarUC1);

            }
            else
            {
                Temp = StackUC.Pop();
                Temp.Enabled = false;
                Temp.Hide();

                orarUC1.Show();
                orarUC1.Enabled = true;
                orarUC1.Dock = DockStyle.Fill;
                orarUC1.BringToFront();
            }
        }

        private void buttonLocatie_Click(object sender, EventArgs e)
        {
            if (StackUC.Count == 0)
            {
                locatie1.Show();
                locatie1.Enabled = true;
                locatie1.Dock = DockStyle.Fill;
                locatie1.BringToFront();

                StackUC.Push(locatie1);

            }
            else
            {
                Temp = StackUC.Pop();
                Temp.Enabled = false;
                Temp.Hide();

                locatie1.Show();
                locatie1.Enabled = true;
                locatie1.Dock = DockStyle.Fill;
                locatie1.BringToFront();
            }
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            if (richTextBoxContact.Enabled == false)
            {
                richTextBoxContact.Enabled = true;
                richTextBoxContact.Show();
            }
            else
            {
                richTextBoxContact.Enabled = false;
                richTextBoxContact.Hide();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelogare_Click(object sender, EventArgs e)
        {
            //UserDetails.Id = "";
            //UserDetails.Username = "";
            Application.Exit();
        }
    }
}
