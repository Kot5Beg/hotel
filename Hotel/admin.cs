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
                string client = "SELECT * FROM clients";
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
            string worker = "SELECT * FROM worker WHERE CONCAT (ID_Category, Surname, Name, Patronymic, Address, Phone, Email, Date_of_birth, Gender) LIKE '%" + textBox1.Text + "%' ";
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
    }
}
