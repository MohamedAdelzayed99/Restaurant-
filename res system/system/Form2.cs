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
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToLongTimeString();
            
            label3.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new Form3());
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form4());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform3(object obj)
        {
            Application.Run(new Form1());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform5(object obj)
        {
            Application.Run(new Form5());
        }
        private void opennewform7(object obj)
        {
            Application.Run(new Form7());
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
