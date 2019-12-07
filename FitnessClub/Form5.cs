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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fitnessClubDataSet5.Instructors". При необходимости она может быть перемещена или удалена.
            this.instructorsTableAdapter.Fill(this.fitnessClubDataSet5.Instructors);
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
            this.dataGridView1.Columns[2].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            int ID_Instructor = Convert.ToInt32(dataGridView1[0, k].Value);

            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();

            string s = "DELETE FROM Instructors WHERE ID_Instructor=" + ID_Instructor.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();
            this.instructorsTableAdapter.Fill(this.fitnessClubDataSet5.Instructors);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
