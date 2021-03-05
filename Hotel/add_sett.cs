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
    public partial class add_sett : Form
    {
        public add_sett()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void LoadCombo()
        {
            database.OpenCon();

            SqlCommand sc2 = new SqlCommand("SELECT * FROM numbers", database.Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sc2);
            da2.Fill(dt2);
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "ID_Category";
            comboBox3.ValueMember = "ID";

            SqlCommand sc1 = new SqlCommand("SELECT * FROM worker", database.Con);
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(sc1);
            da1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Surname";
            comboBox1.ValueMember = "ID";

            SqlCommand sc3 = new SqlCommand("SELECT * FROM clients", database.Con);
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter(sc3);
            da3.Fill(dt3);
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "Surname";
            comboBox2.ValueMember = "ID";

            database.CloseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(comboBox3.SelectedValue);
            int a = Convert.ToInt32(comboBox1.SelectedValue);
            int b = Convert.ToInt32(comboBox2.SelectedValue);

            database.OpenCon();
            string add = String.Format("INSERT INTO settlement (ID_number, Check_in_date, Departure_Date, ID_worker, Price, ID_client) VALUES (" + c + ", '" + dateTimePicker1.Value.Date + "', '"+dateTimePicker2.Value.Date+"', "+a+", '"+textBox1.Text+"', "+b+")");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Заселение оформлено");
        }
    }
}
