using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class worker : Form
    {
        public static DataTable res;
        public worker()
        {
            InitializeComponent();
            Loading("SELECT * FROM clients", dataGridView1);
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
        }
    }
}
