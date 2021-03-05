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
using Word = Microsoft.Office.Interop.Excel;

namespace Hotel
{
    public partial class worker : Form
    {
        public static DataTable res;
        string n;
        public worker()
        {
            InitializeComponent();
            Loading("SELECT * FROM clients", dataGridView1);
            LoadCombo();
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = database.Load(query);
            grid.DataSource = res;
            grid.Columns["ID"].Visible = false;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == clients)
            {
                string client = "SELECT * FROM clients";
                Loading(client, dataGridView1);
            }
            else if (tabControl1.SelectedTab == numbers)
            {
                string product = "SELECT * FROM numbers";
                Loading(product, dataGridView2);
            }
            else if (tabControl1.SelectedTab == money)
            {
                string product = "SELECT * FROM money";
                Loading(product, dataGridView3);
            }
            else if (tabControl1.SelectedTab == wish)
            {
                string type = "SELECT * FROM wish";
                Loading(type, dataGridView4);
            }
            else if(tabControl1.SelectedTab == tabPage1)
            {
                string type = "SELECT * FROM settlement";
                Loading(type, dataGridView5);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string client = "SELECT * FROM clients ORDER BY Surname ASC";
                Loading(client, dataGridView1);
                checkBox3.Enabled = false;
                checkBox2.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                string client = "SELECT * FROM clients";
                Loading(client, dataGridView1);
                checkBox3.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string client = "SELECT * FROM clients ORDER BY Name ASC";
                Loading(client, dataGridView1);
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (checkBox2.Checked == false)
            {
                string client = "SELECT * FROM clients";
                Loading(client, dataGridView1);
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                string client = "SELECT * FROM clients ORDER BY Patronymic ASC";
                Loading(client, dataGridView1);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else if (checkBox3.Checked == false)
            {
                string client = "SELECT * FROM clients";
                Loading(client, dataGridView1);
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                string client = "SELECT * FROM numbers ORDER BY Price_Day ASC";
                Loading(client, dataGridView2);
                checkBox5.Enabled = false;
            }
            else if (checkBox4.Checked == false)
            {
                string client = "SELECT * FROM numbers";
                Loading(client, dataGridView2);
                checkBox5.Enabled = true;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                string client = "SELECT * FROM numbers ORDER BY Quantity ASC";
                Loading(client, dataGridView2);
                checkBox4.Enabled = false;
            }
            else if (checkBox4.Checked == false)
            {
                string client = "SELECT * FROM numbers";
                Loading(client, dataGridView2);
                checkBox4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM clients WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView3.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM money WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView4.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM wish WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void LoadCombo()
        {
            database.OpenCon();
            SqlCommand sc2 = new SqlCommand("SELECT * FROM category", database.Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sc2);
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "rating";
            comboBox1.ValueMember = "ID";
            database.CloseConnection();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filter = "SELECT * FROM numbers WHERE ID_Category = '" + n + "'";
            Loading(filter, dataGridView2);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            n = comboBox1.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_client ac = new add_client();
            ac.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add_money am = new add_money();
            am.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            add_wish aw = new add_wish();
            aw.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM clients";
            Loading(client, dataGridView1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM money";
            Loading(client, dataGridView3);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM wish";
            Loading(client, dataGridView4);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[number];
            upd_client uw = new upd_client(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                row.Cells[7].Value.ToString());
            uw.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add_sett a = new add_sett();
            a.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView5.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM settlement WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                MessageBox.Show("Запись удалена");
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string type = "SELECT * FROM settlement";
            Loading(type, dataGridView5);
        }
    }
}
