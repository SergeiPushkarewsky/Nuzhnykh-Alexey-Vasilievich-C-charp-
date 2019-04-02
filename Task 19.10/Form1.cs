using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbs0 = new TextBox[] { tb01, tb02, tb03, tb04, tb05, tb06, tb07, tb08, tb09 };
            tbs1 = new TextBox[] { tb10, tb11, tb12, tb13, tb14, tb15, tb16, tb17, tb18 };
            domainUpDown1.Text = 5.ToString();
            domainUpDown1_SelectedItemChanged(domainUpDown1, new EventArgs());
        }
        TextBox[] tbs0, tbs1;
        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(domainUpDown1.Text);
            int[,] matr = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (dataGridView1[i, j].Value == null || i == j)
                    {
                        dataGridView1[i, j].Value = (-1).ToString();
                        matr[i, j] = -1;
                    }
                    else
                    if (!int.TryParse(dataGridView1[i, j].Value.ToString(), out matr[i, j]))
                    {
                        MessageBox.Show("Неверные входные данные");
                        return;
                    }
            Graph g = new Graph(matr);
            int sum;
            textBox1.Text = tbs0[g.FindGood(out sum)].Text;
            textBox2.Text = sum.ToString();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)  // обработка изменения количества городов
        {
            int n = int.Parse(domainUpDown1.Text);
            dataGridView1.ColumnCount = n;
            dataGridView1.RowCount = n;
            for (int i = 0; i < n; i++)
            {
                tbs0[i].Visible = true;
                tbs1[i].Visible = true;
            }
            for (int i = n; i < 9; i++)
            {
                tbs0[i].Visible = false;
                tbs0[i].Text = string.Empty;
                tbs1[i].Visible = false;
                tbs1[i].Text = string.Empty;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1[e.RowIndex, e.ColumnIndex].Value = dataGridView1[e.ColumnIndex, e.RowIndex].Value;
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sender == tbs0[i])
                {
                    tbs1[i].Text = tbs0[i].Text;
                    return;
                }
                if (sender == tbs1[i])
                {
                    tbs0[i].Text = tbs1[i].Text;
                    return;
                }
            }
        }
    }
}
