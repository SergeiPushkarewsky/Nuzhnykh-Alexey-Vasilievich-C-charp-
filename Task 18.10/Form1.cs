using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k;
            float x;
            if (tbk.Text == string.Empty || tbx.Text == string.Empty || !int.TryParse(tbk.Text.Trim(new char[] { ' ' }), out k) || !float.TryParse(tbx.Text.Trim(new char[] { ' ' }), out x))
            {
                MessageBox.Show("Ошибка ввода");
                return;
            }
            string[] data = tbTree.Text.Trim(new char[] { ' ' }).Split(new char[] { ' ' });
            Tree tree = new Tree();
            int a;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] != string.Empty)
                    if (int.TryParse(data[i], out a))
                       tree.Add(a);
            }
            tbResult.Text = tree.f(k,x).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbTree.Text = string.Empty;
            tbk.Text = string.Empty;
            tbx.Text = string.Empty;
            tbResult.Text = string.Empty;
        }
    }
}
