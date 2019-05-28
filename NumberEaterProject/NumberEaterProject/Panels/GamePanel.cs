using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberEaterProject.Panels
{
    public partial class GamePanel : UserControl
    {
        public GamePanel()
        {
            InitializeComponent();
        }

        public static int Level = 1;

        static string turnOver(string str) // Используется в 7 функции
        {
            string ans = null;
            for (int i = str.Length; i >= 0; --i)
                ans += str[i];
            return ans;
        }

        public static int Exercise1(int n)
        {
            int m = n + 3;
            return m;
        }
        public static int Exercise2(int n)
        {
            int m = 2 * n + 6;
            return m;
        }
        public static int Exercise3(int n)
        {
            int m = n / 10;
            return m;
        }
        public static int Exercise4(int n)
        {
            int m = n % 10;
            return m;
        }
        public static int Exercise5(int n)
        {
            int m = 0;
            while (n != 0)
            {
                m += n % 10;
                n /= 10;
            }
            return m;
        }
        public static int Exercise6(int n)
        {
            int m = 0;
            while (n != 0)
            {
                m += 1;
                n /= 10;
            }
            return m;
        }
        public static int Exercise7(int n)
        {
            string l = Convert.ToString(n);
            int m = int.Parse(turnOver(l));
            return m;
        }
        public static int Exercise8(int n)
        {
            int m = (n / 10) + (n % 10);
            return m;
        }
        public static int Exercise9(int n)
        {
            int m;
            if (n > 0 && n <= 50) m = n + 1;
            else m = n - 1;
            return m;
        }
        public static int Exercise10(int n)
        {
            int m;
            if (n % 2 == 0) m = n / 2;
            else m = n * 2;
            return m;
        }
        public static int Exercise11(int n)
        {
            int m;
            if (n >= 0) m = n % 10;
            else m = Math.Abs(n);
            return m;
        }
        public static int Exercise12(int n)
        {
            int m;
            if (n % 3 == 0) m = n / 3;
            else
                m = 0;
            while (n != 0)
            {
                m += n % 10;
                n /= 10;
            }
            return m;
        }

        public static int Exercises(int a)
        {
            int b = 0;
            switch (Level)
            {
                case 1: b = Exercise1(a); break;
                case 2: b = Exercise2(a); break;
                case 3: b = Exercise3(a); break;
                case 4: b = Exercise4(a); break;
                case 5: b = Exercise5(a); break;
                case 6: b = Exercise6(a); break;
                case 7: b = Exercise7(a); break;
                case 8: b = Exercise8(a); break;
                case 9: b = Exercise9(a); break;
                case 10: b = Exercise10(a); break;
                case 11: b = Exercise11(a); break;
                case 12: b = Exercise12(a); break;
            }
            return b;
        }

        public void ReadAndWrit()
        {
            if (textBoxRead.Text != "")
            {
                textBoxWrite.Text = "";
                string[] s = textBoxRead.Text.Split('\n');
                int a = Convert.ToInt32(s[s.Length - 1]);
                if (textBoxWrite.Text != "") textBoxWrite.Text += "\r\n";
                int b = Exercises(a);
                textBoxWrite.Text += Convert.ToString(b);
                textBoxRead.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Level = Convert.ToInt32((sender as Button).Text);
            ReadAndWrit();
        }

        private void textBoxRead_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ReadAndWrit();
            }
        }
    }
}
