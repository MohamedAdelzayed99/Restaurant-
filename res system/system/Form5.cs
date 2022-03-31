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
    public partial class Form5 : Form
    {
        Thread th;
        public Form5()
        {
            InitializeComponent();
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
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                this.Close();
                th = new Thread(opennewform2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
