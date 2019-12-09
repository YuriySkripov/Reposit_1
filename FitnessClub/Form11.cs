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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "" ||
               textBox2.Text.Trim() == "" ||
               textBox3.Text.Trim() == "" ||
               textBox4.Text.Trim() == "" ||
               maskedTextBox1.Text.Trim() == "" ||
               maskedTextBox2.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заплненны!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(Program.st_connect);
                conn.Open();
                string s1 = "Select * from Service where ID_Service='" + textBox1.Text.Trim() + "'";
                SqlCommand comm1 = new SqlCommand(s1, conn);
                SqlDataReader read1 = comm1.ExecuteReader();
                if (read1.HasRows)
                {
                    MessageBox.Show("Логин занят!");
                }
                else
                {
                    read1.Close();
                    string s = "insert into Service (ID_Uslugi,ID_Users,ID_Instructor,Price,Start_Time,End_Time) Values" +
                        "('" + textBox1.Text.Trim() + "'," +
                        "' " + textBox2.Text.Trim() + "'," +
                        "' " + textBox3.Text.Trim() + "'," +
                        "' " + textBox4.Text.Trim() + "'," +
                        "' " + maskedTextBox1.Text.Trim() + "'," +
                        "' " + maskedTextBox2.Text.Trim() + "')";

                    SqlCommand comm = new SqlCommand(s, conn);
                    comm.ExecuteScalar();

                    this.Close();
                    Form10 f = new Form10();
                    f.Show();
                }
                conn.Close();
            }
        }
    }
}
