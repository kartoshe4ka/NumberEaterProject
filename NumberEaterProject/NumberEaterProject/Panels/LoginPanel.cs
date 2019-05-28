using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberEaterProject.Panels;

namespace NumberEaterProject.Panels
{
    public partial class LoginPanel : UserControl
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        public void CheckText()
        {
            if (textBoxLogin.Text != "")
            {
                //GP.BringToFront();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            CheckText();
        }

        private void textBoxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) CheckText();
        }
    }
}
