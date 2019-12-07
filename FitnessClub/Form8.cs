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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet6.Uslugi". При необходимости она может быть перемещена или удалена.
            this.uslugiTableAdapter.Fill(this.fitnessClubDataSet6.Uslugi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form9 f = new Form9();
                f.Show();
                this.Close();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            int ID_Uslugi = Convert.ToInt32(dataGridView1[0, k].Value);

            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();

            string s = "DELETE FROM Uslugi WHERE ID_Uslugi=" + ID_Uslugi.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
            this.uslugiTableAdapter.Fill(this.fitnessClubDataSet6.Uslugi);
        }
    }
}

