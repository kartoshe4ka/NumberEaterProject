using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberEaterProject.Panels;

namespace NumberEaterProject
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            checkPanel.BringToFront();
        }

        private void RaitingButton_Click(object sender, EventArgs e)
        {

        }

        private void SupportButton_Click(object sender, EventArgs e)
        {

        }
    }
}
