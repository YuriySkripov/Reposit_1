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
using Microsoft.Office.Interop.Excel;

namespace FitnessClub
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();
            string s = "select ID_Service,ID_Uslugi,ID_Users,ID_Instructor,Price,Start_Time,End_Time from Service ";
                       
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
            this.dataGridView1.Columns[1].Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form11 f = new Form11();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentRow.Index;
            int ID_Service = Convert.ToInt32(dataGridView1[0, k].Value);

            SqlConnection conn = new SqlConnection(Program.st_connect);
            conn.Open();

            string s = "DELETE FROM Service WHERE ID_Service=" + ID_Service.ToString();
            SqlCommand comm = new SqlCommand(s, conn);
            comm.ExecuteScalar();
            conn.Close();

            this.Close();
            Form10 f = new Form10();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application myExcel = new Microsoft.Office.Interop.Excel.Application();//создаем виртуальный объект Excel
            //создать книгу в объекте Excel
            myExcel.Application.Workbooks.Add(Type.Missing);
            //Настраиваем ячейки
            myExcel.Columns.ColumnWidth = 15;
            //Пишем заголовки ячеек
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                myExcel.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;// заголовки программно
            }

            /*myExcel.Cells[1, 2] = "Заголовок 2"; //заголовки прописаны
            myExcel.Cells[1, 3] = "Заголовок 3";
            myExcel.Cells[1, 4] = "Заголовок 4";*/

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    myExcel.Cells[j + 2, i + 1] = dataGridView1[i, j].Value.ToString();
                }
            }
            Range range = (Range)myExcel.Columns[1, Type.Missing];
            range.EntireColumn.Hidden = true;
            myExcel.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.Show();
        }
    }

}

