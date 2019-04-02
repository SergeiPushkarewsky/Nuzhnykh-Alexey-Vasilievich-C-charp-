using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Queue q1 = RandomQueue(20,-50,50);
            Write(ref q1, richTextBox1);

            Queue q2 = new Queue();
            int n = 0;
            while (!q1.isEmpty())
            {
                int tmp = q1.pop();
                if (tmp < 0)
                    n++;
                q2.push(tmp);
            }
            int n1 = 0;
            while (!q2.isEmpty())
            {
                int tmp = q2.pop();
                if (tmp < 0)
                    n1++;
                if ((n != n1) || (tmp >= 0))
                    q1.push(tmp);
            }

            Write(ref q1, richTextBox2);
        }

        private Queue RandomQueue(int n, int l, int r)
        {
            Queue q = new Queue();
            Random rand = new Random();
            for (int i = 0; i < n; i++)
                q.push(rand.Next(l,r));
            return q;
        }
        private void Write(ref Queue q, RichTextBox tb)
        {
            Queue q1 = new Queue();
            tb.Text = string.Empty;
            while (!q.isEmpty())
            {
                int tmp = q.pop();
                tb.Text = tb.Text + tmp.ToString() + " ";
                q1.push(tmp);
            }
            q = q1;
        }

    }
}
