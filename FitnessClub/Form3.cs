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
    public partial class Form3 : Form
    {

        int n = 0;

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.ID_Users = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select * from Users where ID_Users= " + Program.ID_Users.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            SqlDataReader read = comm.ExecuteReader();
            read.Read();

            Form7 f = new Form7();
            f.textBox1.Text = read.GetString(1);
            f.textBox2.Text = read.GetString(2);
            f.maskedTextBox1.Text = read.GetString(3);
            f.textBox4.Text = read.GetString(4);
            f.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            Program.ID_Users = Convert.ToInt32(dataGridView1[0, k].Value);
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "delete from Users where ID_Users= " + Program.ID_Users.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
            MessageBox.Show("Клиент удалён!");
            this.Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select ID_Users,FIO,Email,Phone,Address from Users where type=0 " +
                       "order by ID_Users offset " + n.ToString() + " " +
                       "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button2.Enabled = true;
            }
            conn.Close();
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = n - 10;
            if (n <= 0)
            {
                button1.Enabled = false;
            }
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select ID_Users,FIO,Email,Phone,Address from Users where type=0 " +
                       "order by ID_Users offset " + n.ToString() + " " +
                       "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n = n + 10;
            button1.Enabled = true;
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select ID_Users,FIO,Email,Phone,Address from Users where type=0 " +
                       "order by ID_Users offset " + n.ToString() + " " +
                       "rows fetch next 10 rows only";
            SqlDataAdapter adap = new SqlDataAdapter(s, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            if (ds.Tables[0].Rows.Count >= 10)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Show();
            this.Close();
        }
    }
}
