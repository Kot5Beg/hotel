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
    public partial class add_wish : Form
    {
        public add_wish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string add = String.Format("INSERT INTO wish (Date, Notes) VALUES ('" + dateTimePicker1.Value.Date + "', '"+textBox1.Text+"')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Отзыв добавлен");
        }
    }
}
