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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FIO = textBox1.Text.Trim();
            string Email = textBox2.Text.Trim();
            if (FIO == "" || Email == "")
            {
                MessageBox.Show("Ведите данные!!!");
            }
            else
            {
                SqlConnection connect =
                    new SqlConnection(Program.st_connect);
                connect.Open();
                string s = "select * from Users where FIO='" + FIO + "'and Email='" + Email + "'";
                SqlCommand command = new SqlCommand(s, connect);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    Program.ID_Users = reader.GetInt32(0);
                    Program.type_user = reader.GetBoolean(5);

                    if (Program.type_user == false)
                    {
                        Form2 f = new Form2();
                        f.textBox1.Text = reader.GetString(1);
                        f.textBox2.Text = reader.GetString(2);
                        f.maskedTextBox1.Text = reader.GetString(3);
                        f.textBox4.Text = reader.GetString(4);
                        f.Show();


                    }
                    else
                    {
                        Form3 f = new Form3();
                        f.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}
