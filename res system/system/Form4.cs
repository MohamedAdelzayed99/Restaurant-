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
    
    public partial class Form4 : Form
    {
        Thread th;
        DataTable table = new DataTable();
        DataGridViewRow row;
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", typeof(string));
            table.Columns.Add("Date", typeof(float));
            table.Columns.Add("Total Bill", typeof(float));
            table.Columns.Add("Proudact", typeof(Button));
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            dataGridView1.DataSource = table;
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
