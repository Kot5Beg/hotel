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
    public partial class add_category : Form
    {
        public add_category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string add = String.Format("INSERT INTO category (rating) VALUES ('" + textBox1.Text + "')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Категория добавлена");
        }
    }
}
