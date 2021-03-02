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
    }
}
