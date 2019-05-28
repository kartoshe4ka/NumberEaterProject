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
    public partial class CheckPanel : UserControl
    {
        public static int proverka = 0;

        public void GetRandom()
        {
            Random rand = new Random();
            int n = rand.Next(-200, 200);
            textBoxChN.Text = n.ToString();
        }

        public CheckPanel()
        {
            InitializeComponent();
            GetRandom();
        }

        public void Check()
        {
            int m = Convert.ToInt32(textBoxChN.Text);
            if (GamePanel.Exercises(m) == Convert.ToInt32(textBoxRead.Text))
            {
                proverka++;
                if (proverka == 5)
                {
                    /*GamePanel.Level++;
                     * gamePanel.BrightToFront();
                     */
                }
                GetRandom();
            }
            else
            {
                textBoxChT.Text = Convert.ToString("Подумай");
                textBoxChN.Text = Convert.ToString("ещё!");
            }
        }

        private void textBoxRead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Check();
                textBoxRead.Text = null;
            }
        }
    }
}
