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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label3.Text =
                    Path.GetFileName(openFileDialog1.FileName);
                File.Copy(openFileDialog1.FileName,
                    AppDomain.CurrentDomain.BaseDirectory + label3.Text, true);
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                if (textBox1.Text.Trim() == "" ||
                    maskedTextBox1.Text.Trim() == "")
                {
                    MessageBox.Show("Не все поля заполненны!");
                }
                else
                {
                    SqlConnection conn
                        = new SqlConnection(Program.st_connect);
                    conn.Open();
                    string s1 = "select * from Instructors where Name_instructor='" +
                        textBox1.Text.Trim() + "'";
                    SqlCommand comm1 = new SqlCommand(s1, conn);
                    SqlDataReader read12 = comm1.ExecuteReader();
                    if(read12.HasRows)
                    {
                        MessageBox.Show("Логин занят!");
                    }
                    else
                    {
                        read12.Close();
                        string s = "insert into Instructors " + "" +
                            "(Name_Instructor,Phone,Photo) values " +
                            "('" + textBox1.Text.Trim() + "'," +
                            " '" + maskedTextBox1.Text.Trim() + "'," +
                            "'" + label3.Text + "')";
                        SqlCommand comm = new SqlCommand(s, conn);
                        comm.ExecuteScalar();
                        conn.Close();
                    }
                    
          
                }
            }
            SqlConnection conn2
                        = new SqlConnection(Program.st_connect);
            conn2.Open();
            string s12 = "select * from Instructors ";
            SqlCommand comm2 = new SqlCommand(s12, conn2);
            SqlDataReader read1 = comm2.ExecuteReader();
            conn2.Close();
            this.Close();
            Form5
                f = new Form5();
            f.Show();
            //catch
            //{
            //    MessageBox.Show("Что-то не так!");
            //}
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
