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
    public partial class add_number : Form
    {
        public add_number()
        {
            InitializeComponent();
            LoadCombo();
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

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(comboBox1.SelectedValue);

            database.OpenCon();
            string add = String.Format("INSERT INTO numbers (ID_Category, Price_Day, Quantity) VALUES ("+c+", '" + textBox2.Text + "', '"+textBox1.Text+"')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Номер добавлен");
        }
    }
}
