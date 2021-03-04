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
    public partial class upd_number : Form
    {
        public static string id { get; set; }
        public static string category { get; set; }
        public static string price { get; set; }
        public static string quan { get; set; }

        public upd_number()
        {
            InitializeComponent();
        }

        public upd_number(string ID, string Category, string Price, string Quan)
        {
            InitializeComponent();
            id = ID;
            category = Category;
            price = Price;
            quan = Quan;
            LoadCombo();
            LoadText();
        }

        public void LoadText()
        {
            comboBox1.Text = category;
            textBox1.Text = price;
            textBox2.Text = quan;
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
            int n = Convert.ToInt32(comboBox1.SelectedValue);
            database.OpenCon();
            string save = String.Format("UPDATE {0} SET ID_Category = {1}, Price_Day = '{2}', Quantity = '{3}' WHERE ID = '{4}'", "numbers", n, textBox1.Text, textBox2.Text, id);
            SqlCommand com = new SqlCommand(save, database.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
        }
    }
}
