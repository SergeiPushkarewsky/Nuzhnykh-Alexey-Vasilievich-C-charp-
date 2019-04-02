namespace graph
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.tb13 = new System.Windows.Forms.TextBox();
            this.tb17 = new System.Windows.Forms.TextBox();
            this.tb16 = new System.Windows.Forms.TextBox();
            this.tb15 = new System.Windows.Forms.TextBox();
            this.tb14 = new System.Windows.Forms.TextBox();
            this.tb18 = new System.Windows.Forms.TextBox();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb04 = new System.Windows.Forms.TextBox();
            this.tb03 = new System.Windows.Forms.TextBox();
            this.tb08 = new System.Windows.Forms.TextBox();
            this.tb07 = new System.Windows.Forms.TextBox();
            this.tb06 = new System.Windows.Forms.TextBox();
            this.tb05 = new System.Windows.Forms.TextBox();
            this.tb09 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(141, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(903, 212);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма путей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Город";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 325);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 353);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Location = new System.Drawing.Point(137, 17);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(51, 20);
            this.domainUpDown1.TabIndex = 7;
            this.domainUpDown1.Text = "5";
            this.domainUpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество городов";
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(10, 91);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(119, 20);
            this.tb10.TabIndex = 9;
            this.tb10.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(10, 113);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(119, 20);
            this.tb11.TabIndex = 10;
            this.tb11.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(10, 135);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(119, 20);
            this.tb12.TabIndex = 11;
            this.tb12.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb13
            // 
            this.tb13.Location = new System.Drawing.Point(10, 157);
            this.tb13.Name = "tb13";
            this.tb13.Size = new System.Drawing.Size(119, 20);
            this.tb13.TabIndex = 12;
            this.tb13.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb17
            // 
            this.tb17.Location = new System.Drawing.Point(10, 245);
            this.tb17.Name = "tb17";
            this.tb17.Size = new System.Drawing.Size(119, 20);
            this.tb17.TabIndex = 16;
            this.tb17.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb16
            // 
            this.tb16.Location = new System.Drawing.Point(10, 223);
            this.tb16.Name = "tb16";
            this.tb16.Size = new System.Drawing.Size(119, 20);
            this.tb16.TabIndex = 15;
            this.tb16.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb15
            // 
            this.tb15.Location = new System.Drawing.Point(10, 201);
            this.tb15.Name = "tb15";
            this.tb15.Size = new System.Drawing.Size(119, 20);
            this.tb15.TabIndex = 14;
            this.tb15.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb14
            // 
            this.tb14.Location = new System.Drawing.Point(10, 179);
            this.tb14.Name = "tb14";
            this.tb14.Size = new System.Drawing.Size(119, 20);
            this.tb14.TabIndex = 13;
            this.tb14.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb18
            // 
            this.tb18.Location = new System.Drawing.Point(10, 267);
            this.tb18.Name = "tb18";
            this.tb18.Size = new System.Drawing.Size(119, 20);
            this.tb18.TabIndex = 17;
            this.tb18.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb01
            // 
            this.tb01.Location = new System.Drawing.Point(142, 65);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(98, 20);
            this.tb01.TabIndex = 18;
            this.tb01.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb02
            // 
            this.tb02.Location = new System.Drawing.Point(242, 65);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(98, 20);
            this.tb02.TabIndex = 19;
            this.tb02.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb04
            // 
            this.tb04.Location = new System.Drawing.Point(442, 65);
            this.tb04.Name = "tb04";
            this.tb04.Size = new System.Drawing.Size(98, 20);
            this.tb04.TabIndex = 21;
            this.tb04.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb03
            // 
            this.tb03.Location = new System.Drawing.Point(342, 65);
            this.tb03.Name = "tb03";
            this.tb03.Size = new System.Drawing.Size(98, 20);
            this.tb03.TabIndex = 20;
            this.tb03.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb08
            // 
            this.tb08.Location = new System.Drawing.Point(842, 65);
            this.tb08.Name = "tb08";
            this.tb08.Size = new System.Drawing.Size(98, 20);
            this.tb08.TabIndex = 25;
            this.tb08.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb07
            // 
            this.tb07.Location = new System.Drawing.Point(742, 65);
            this.tb07.Name = "tb07";
            this.tb07.Size = new System.Drawing.Size(98, 20);
            this.tb07.TabIndex = 24;
            this.tb07.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb06
            // 
            this.tb06.Location = new System.Drawing.Point(642, 65);
            this.tb06.Name = "tb06";
            this.tb06.Size = new System.Drawing.Size(98, 20);
            this.tb06.TabIndex = 23;
            this.tb06.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb05
            // 
            this.tb05.Location = new System.Drawing.Point(542, 65);
            this.tb05.Name = "tb05";
            this.tb05.Size = new System.Drawing.Size(98, 20);
            this.tb05.TabIndex = 22;
            this.tb05.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // tb09
            // 
            this.tb09.Location = new System.Drawing.Point(942, 65);
            this.tb09.Name = "tb09";
            this.tb09.Size = new System.Drawing.Size(98, 20);
            this.tb09.TabIndex = 26;
            this.tb09.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 392);
            this.Controls.Add(this.tb09);
            this.Controls.Add(this.tb08);
            this.Controls.Add(this.tb07);
            this.Controls.Add(this.tb06);
            this.Controls.Add(this.tb05);
            this.Controls.Add(this.tb04);
            this.Controls.Add(this.tb03);
            this.Controls.Add(this.tb02);
            this.Controls.Add(this.tb01);
            this.Controls.Add(this.tb18);
            this.Controls.Add(this.tb17);
            this.Controls.Add(this.tb16);
            this.Controls.Add(this.tb15);
            this.Controls.Add(this.tb14);
            this.Controls.Add(this.tb13);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox tb13;
        private System.Windows.Forms.TextBox tb17;
        private System.Windows.Forms.TextBox tb16;
        private System.Windows.Forms.TextBox tb15;
        private System.Windows.Forms.TextBox tb14;
        private System.Windows.Forms.TextBox tb18;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb04;
        private System.Windows.Forms.TextBox tb03;
        private System.Windows.Forms.TextBox tb08;
        private System.Windows.Forms.TextBox tb07;
        private System.Windows.Forms.TextBox tb06;
        private System.Windows.Forms.TextBox tb05;
        private System.Windows.Forms.TextBox tb09;
    }
}

