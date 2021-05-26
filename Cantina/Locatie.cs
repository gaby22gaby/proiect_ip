/**************************************************************************
 *                                                                        *
 *  File:        Locatie.cs                                               *
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
using System.Diagnostics;
using System.Windows.Forms;

namespace Cantina
{
    public partial class Locatie : UserControl
    {
        public Locatie()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.google.com/maps?ll=47.15457,27.609533&z=18&t=m&hl=en-US&gl=RO&mapclient=embed&cid=120207251413678879");
        }
    }
}
