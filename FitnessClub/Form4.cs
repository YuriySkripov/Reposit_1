using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FitnessClub
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim()==""||
               textBox2.Text.Trim()==""||
               maskedTextBox1.Text.Trim()==""||
               textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заплненны!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.st_connect);
                conn.Open();
                string s1 = "Select * from Users where FIO='" + textBox1.Text.Trim() + "'";
                SqlCommand comm1 = new SqlCommand(s1, conn);
                SqlDataReader read1 = comm1.ExecuteReader();
                if (read1.HasRows)
                {
                    MessageBox.Show("Логин занят!");
                }
                else
                {
                    read1.Close();
                    string s = "insert into Users" +
                        "(FIO,Email,Phone,Address,type) Values" +
                        "('" + textBox1.Text.Trim() + "'," +
                        "' " + textBox2.Text.Trim() + "'," +
                        "' " + maskedTextBox1.Text.Trim() + "'," +
                        "' " + textBox4.Text.Trim() + "', 0)";

                    SqlCommand comm = new SqlCommand(s, conn);
                    comm.ExecuteScalar();

                    this.Close();
                }
                conn.Close();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
