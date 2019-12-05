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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = true;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            maskedTextBox1.Enabled = true;
            textBox4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Program.st_connect);
            connect.Open();
            string s = "update Users set " +
                "FIO='" + textBox1.Text.Trim() + "', "
                + "Email='" + textBox2.Text.Trim() + "', "
                + "Phone='" + maskedTextBox1.Text.Trim() + "', "
                + "Address='" + textBox4.Text.Trim()+"' "
                +"where ID_Users="+Program.ID_Users.ToString();
               
            SqlCommand comm = new SqlCommand(s, connect);
            comm.ExecuteScalar();
            connect.Close();
            button2.Visible = false;
            button1.Visible = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            maskedTextBox1.Enabled = false;
            textBox4.Enabled = false;
        }
    }
}
