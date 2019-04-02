using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Check(out int[] a, out int[] b)  // проверка на отсутствие посторнних символов и на убываение
        {
            string[] data_a = textBox1.Text.Trim(new char[] { ' ' }).Split(new char[] { ' ' });
            string[] data_b = textBox2.Text.Trim(new char[] { ' ' }).Split(new char[] { ' ' });
            int n_a = 0, n_b = 0;
            for (int i = 0; i < data_a.Length; i++)
                if (data_a[i] != string.Empty)
                    n_a++;
            for (int i = 0; i < data_b.Length; i++)
                if (data_b[i] != string.Empty)
                    n_b++;
            a = new int[n_a];
            b = new int[n_b];
            int i_a = 0, i_b = 0;
            int tmp = 0;
            for (int i = 0; i < data_a.Length; i++)
                if (data_a[i] != string.Empty)
                {
                    if (!int.TryParse(data_a[i], out tmp))
                        return false;
                    else
                    {
                        a[i_a] = tmp;
                        i_a++;
                    }
                }
            for (int i = 0; i < data_b.Length; i++)
                if (data_b[i] != string.Empty)
                {
                    if (!int.TryParse(data_b[i], out tmp))
                        return false;
                    else
                    {
                        b[i_b] = tmp;
                        i_b++;
                    }
                }
            for (int i = 0; i < a.Length - 1; i++)
                if (a[i] < a[i + 1])
                    return false;
            for (int i = 0; i < b.Length - 1; i++)
                if (b[i] < b[i + 1])
                    return false;
            return true;
        }

        private void merger(int[] a, int[] b, out int[]c, out int[] d, out int n_c, out int n_d) // слияние массивов
        {
            c = new int[a.Length + b.Length];
            d = new int[a.Length + b.Length];

            int i_a = 0, i_b = 0, i_c = 0, i_d = 0;
            while (i_a < a.Length && i_b < b.Length)
            {
                if (a[i_a] > b[i_b])
                {
                    c[i_c] = a[i_a];
                    i_a++;
                }
                else
                {
                    c[i_c] = b[i_b];
                    i_b++;
                }
                i_c++;
            }
            int i;
            for ( i = i_a; i < a.Length; i++)
            {
                c[i_c] = a[i];
                i_c++;
            }
            for ( i = i_b; i < b.Length; i++)
            {
                c[i_c] = b[i];
                i_c++;
            }
            i = 0;
            while (i < i_c - 1)
                if (c[i] == c[i + 1])
                {
                    d[i_d] = c[i];
                    i_d++;
                    for (int j = i; j < i_c - 1; j++)
                        c[j] = c[j + 1];
                    i_c--;
                }
                else
                    i++;
            n_c = i_c;
            n_d = i_d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] A, B, C, D;
            if (!Check(out A, out B))
            {
                MessageBox.Show("Элементы массивов должны быть целами числами и следовать по невозрастанию");
                return;
            }
            int n_c, n_d;
            merger(A, B, out C, out D, out n_c, out n_d);
            textBoxC.Text = string.Empty;
            textBoxD.Text = string.Empty;
            /*
            for (int i = 0; i < n_c; i++)
                textBoxC.Text = textBoxC.Text + C[i] + " ";
            for (int i = 0; i < n_d; i++)
                textBoxD.Text = textBoxD.Text + D[i] + " ";
                */
            textBoxC.Text = n_c.ToString();
            textBoxD.Text = n_d.ToString();
        }
    }
}
