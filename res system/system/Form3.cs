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
    public partial class Form3 : Form
    {
 int img1index = -99, img1count = 0;
        int img1index1= -99, img1count1 = 0;
        int img1index2 = -99, img1count2= 0;
        int ct=1;
        int ct2 = 0;
       
        Double value = 0;
        Thread th;
        DataTable table = new DataTable();
        DataGridViewRow row;
        float SUM;
        float tax;
        float tot;
        public static string text_input;
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            table.Columns.Add(Name, typeof(string));
            dataGridView1.DataSource = table;
           

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("price", typeof(float));
            table.Columns.Add("Qty", typeof(float));
            table.Columns.Add("comment", typeof(string));
            dataGridView1.DataSource = table;
           
            
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
            Application.Run(new Form2());
        }
        private void opennewform2(object obj)
        {
            Application.Run(new Form1());
        }
        private void opennewform4(object obj)
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
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {

            dataGridView1.SelectAll();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int row = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(row);
            }

            dataGridView1.Refresh();
            img1index = -99; img1count = 0;
            img1index1 = -99; img1count1 = 0;
            img1index2 = -99; img1count2 = 0;
        }

       
        
        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
           
                value = double.Parse(SUM.ToString());
            label15.Text = (value - double.Parse(textBox2.Text)).ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.Text== "Delivery")
            {
                groupBox3.Show();
            }
            else
            {
                groupBox3.Hide();
            }
        }

        private void div_Click(object sender, EventArgs e)
        {

            if (textBox3.Text == "0")
            {
                textBox3.Clear();
            }
            Button button = (Button)sender;
            textBox3.Text += button.Text;
            if (double.Parse(textBox3.Text) > tot)
            {
                textBox4.Text = (double.Parse(textBox3.Text) - tot).ToString();
                textBox5.Text = "0";
            }
            if (tot > double.Parse(textBox3.Text))
            {
                textBox5.Text = (tot - double.Parse(textBox3.Text)).ToString();
                textBox4.Text = "0";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length - 1 == 0)
            {

                textBox3.Text = "0";
                value = 0;


            }

            if (textBox3.Text.Length - 1 != 0)
            {
                textBox3.Text = textBox3.Text.Substring(0, textBox3.Text.Length - 1);
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            ct2++;
            if (ct2 % 2 != 0)
            {
                groupBox4.Show();
            }
            if (ct2 % 2 == 0)
            {
                groupBox4.Hide();
            }

        }

     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label32_Click(object sender, EventArgs e)
        {
            
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label45.Text = label33.Text;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label45.Text = label34.Text;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label45.Text = label35.Text;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            label45.Text = label36.Text;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            label45.Text = label37.Text;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            label45.Text = label38.Text;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label45.Text = label39.Text;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            label45.Text = label40.Text;

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            label45.Text = label41.Text;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            label45.Text = label42.Text;
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            label45.Text = label43.Text;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            label45.Text = label44.Text;
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            int price = 40;
            img1count++;
            if (img1count == 1)
            {
                table.Rows.Add("burger", price, img1count, ".......");

            }
            if (img1index == -99)
            {
                img1index = dataGridView1.Rows.Count - 2;
            }
            DataGridViewRow selectedrow = dataGridView1.Rows[img1index];
            if (img1count > 1)
            {

                selectedrow.Cells[1].Value = img1count * price;
                selectedrow.Cells[2].Value = img1count;
            }
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            int price = 35;
            img1count1++;
            if (img1count1 == 1)
            {
                table.Rows.Add("pasta", price, img1count1, ".......");
                ct++;
                ct2 = ct;
            }
            if (img1index1 == -99)
            {
                img1index1 = dataGridView1.Rows.Count - 2;
            }
            DataGridViewRow selectedrow = dataGridView1.Rows[img1index1];
            if (img1count1 > 1)
            {

                selectedrow.Cells[1].Value = img1count1 * price;
                selectedrow.Cells[2].Value = img1count1;
            }
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            int price = 20;
            img1count2++;
            if (img1count2 == 1)
            {
                table.Rows.Add("frise", price, img1count2, ".......");

            }
            if (img1index2 == -99)
            {
                img1index2 = dataGridView1.Rows.Count - 2;
            }
            DataGridViewRow selectedrow = dataGridView1.Rows[img1index2];
            if (img1count2 > 1)
            {

                selectedrow.Cells[1].Value = img1count2 * price;
                selectedrow.Cells[2].Value = img1count2;
            }
        }

        private void Button37_Click(object sender, EventArgs e)
        {
           
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("welcome to speak", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(50, 50));

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] columnData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[2].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[1].FormattedValue)).ToArray();
            SUM = columnData.Sum();
            label13.Text = SUM.ToString();
            tax = (SUM * 14) / 100;
            tot = tax + SUM;
            label20.Text = tax.ToString();
            label10.Text = tot.ToString();
            label13.Text += " LE";
            label20.Text += " LE";
            label10.Text += " LE";
            label23.Text= tot.ToString();
            timer1.Start();
            int x = dataGridView1.Rows.Count - 1;
            label12.Text = x.ToString();
            label32.Text = DateTime.Now.ToLongDateString();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
        }
       

       
    }
}
