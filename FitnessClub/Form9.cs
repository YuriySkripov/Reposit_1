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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (textBox1.Text.Trim() == "" )
                {
                    MessageBox.Show("Введите имя!");
                }
                else
                {
                    SqlConnection conn
                        = new SqlConnection(Program.st_connect);
                    conn.Open();
                    string s1 = "select * from Uslugi where Name_Uslugi='" +
                        textBox1.Text.Trim() + "'";
                    SqlCommand comm1 = new SqlCommand(s1, conn);
                    SqlDataReader read12 = comm1.ExecuteReader();
                    if (read12.HasRows)
                    {
                        MessageBox.Show("Логин занят!");
                    }
                    else
                    {
                        read12.Close();
                        string s = "insert into Uslugi " + "" +
                            "(Name_Uslugi) values " +
                            "('" + textBox1.Text.Trim() + "')";
                        SqlCommand comm = new SqlCommand(s, conn);
                        comm.ExecuteScalar();
                        conn.Close();
                        Form8 f = new Form8();
                        f.Show();
                        this.Close();

                    }


                }
            }
            
        }
    }
}
