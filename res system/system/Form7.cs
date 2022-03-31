using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace system
{
    public partial class Form7 : Form
    {
        Thread th;
        int ct = 0;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.textBox1;
            this.Location = new Point(Properties.Settings.Default.py, Properties.Settings.Default.px);
            
        }
        
        private void opennewform(object obj)
        {
            Application.Run(new Form1());
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form2());
        }
        private void opennewform3(object obj)
        {
            Application.Run(new Form3());
        }

       

       

        private void button4_Click(object sender, EventArgs e)
        {
            ct++;
            int y = 30;
            for (int i=0;i< ct;i ++)
            {
                Button b = new Button();
                b.Location = new Point(300, y);
                b.Text = textBox2.Text;
                b.Size = new Size(200, 100);
                b.Font = new Font("Microsoft Sans Serif", 12);
                b.Padding = new Padding(0);
                this.Controls.Add(b);
                y += 300;
            }

        }
        

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.textBox1 = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
