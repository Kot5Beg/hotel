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

namespace Hotel
{
    public partial class admin : Form
    {
        public static DataTable res;
        public admin()
        {
            InitializeComponent();
            Loading("SELECT * FROM worker", dataGridView1);
        }

        public static void Loading(string query, DataGridView grid)
        {
            res = database.Load(query);
            grid.DataSource = res;
            grid.Columns["ID"].Visible = false;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab == worker)
            {
                string client = "SELECT * FROM worker";
                Loading(client, dataGridView1);
            }
            else if (tabControl1.SelectedTab == numbers)
            {
                string product = "SELECT * FROM numbers";
                Loading(product, dataGridView2);
            }
            else if (tabControl1.SelectedTab == activity)
            {
                string product = "SELECT * FROM activity";
                Loading(product, dataGridView3);
            }
            else if (tabControl1.SelectedTab == category)
            {
                string type = "SELECT * FROM category";
                Loading(type, dataGridView4);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string worker = "SELECT * FROM worker WHERE CONCAT (Surname, Name, Patronymic, Address, Phone, Email, Date_of_birth) LIKE '%" + textBox1.Text + "%' ";
            Loading(worker, dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string worker = "SELECT * FROM numbers WHERE CONCAT (ID_Category, Price_Day, Quantity) LIKE '%" + textBox2.Text + "%' ";
            Loading(worker, dataGridView2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                string client = "SELECT * FROM worker ORDER BY Name ASC";
                Loading(client, dataGridView1);
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (checkBox1.Checked == false)
            {
                string client = "SELECT * FROM worker";
                Loading(client, dataGridView1);
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                string client = "SELECT * FROM worker ORDER BY Patronymic ASC";
                Loading(client, dataGridView1);
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
            }
            else if (checkBox2.Checked == false)
            {
                string client = "SELECT * FROM worker";
                Loading(client, dataGridView1);
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                string client = "SELECT * FROM worker ORDER BY Surname ASC";
                Loading(client, dataGridView1);
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else if (checkBox3.Checked == false)
            {
                string client = "SELECT * FROM worker";
                Loading(client, dataGridView1);
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы точно хотите удалить запсиь?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM worker WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запсиь?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView2.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM numbers WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить запсиь?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                database.OpenCon();
                var num = (int)dataGridView4.CurrentRow.Cells["ID"].Value;
                SqlCommand sc = new SqlCommand(String.Format("DELETE FROM category WHERE ID = {0}", num), database.Con);
                sc.ExecuteNonQuery();
                database.CloseConnection();
            }
            else
            {
                MessageBox.Show("Ошибка удаления");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            add_category ac = new add_category();
            ac.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            add_number an = new add_number();
            an.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_worker aw = new add_worker();
            aw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[number];
            upd_worker uw = new upd_worker(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString(),
                row.Cells[4].Value.ToString(),
                row.Cells[5].Value.ToString(),
                row.Cells[6].Value.ToString(),
                row.Cells[7].Value.ToString());
            uw.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = dataGridView4.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView4.Rows[number];
            upd_category uc = new upd_category(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString());
            uc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<string> manager = new List<string>();
            var number = dataGridView2.CurrentCell.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[number];
            upd_number un = new upd_number(row.Cells[0].Value.ToString(),
                row.Cells[1].Value.ToString(),
                row.Cells[2].Value.ToString(),
                row.Cells[3].Value.ToString());
            un.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string client = "SELECT * FROM worker";
            Loading(client, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string product = "SELECT * FROM numbers";
            Loading(product, dataGridView2);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string type = "SELECT * FROM category";
            Loading(type, dataGridView4);
        }
    }
}
