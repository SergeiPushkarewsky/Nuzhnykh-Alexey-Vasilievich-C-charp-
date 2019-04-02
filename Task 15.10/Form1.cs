using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stack st1 = new Stack();
            Stack st2 = new Stack();
            if (!(GetData(textBox1, out st1) && GetData(textBox2, out st2)))
            {
                MessageBox.Show("Элементами могут быть только целые числа");
                return;
            }
            int n1 = 0;
            while (!st1.isEmpty())
            {
                st2.push(st1.pop());
                n1++;
            }
            int n = 0;
            while (!st2.isEmpty())
            {
                st1.push(st2.pop());
                n++;
            }
            int n2 = n - n1;
            for (int i = 0; i < n2; i++)
                st2.push(st1.pop());

            tbResult.Text = n.ToString();
        }

        private bool GetData(TextBox tb, out Stack st)
        {
            st = new Stack();
            string[] data = tb.Text.Trim(new char[] { ' ' }).Split(new char[] { ' ' });
            int a = 0;
            for (int i = 0; i < data.Length; i++)
                if (data[i] != string.Empty)
                {
                    if (!int.TryParse(data[i], out a))
                        return false;
                    else
                        st.push(a);
                }
            return true;
        }

    }
}
