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
    public partial class add_client : Form
    {
        public add_client()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(comboBox1.SelectedValue);

            database.OpenCon();
            string add = String.Format("INSERT INTO clients (Surname, Name, Patronymic, ID_Wish, Phone, Email, Date_birth) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "' , "+c+", '"+textBox4.Text+"', '"+textBox5.Text+"', '"+dateTimePicker1.Value.Date+"')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Клиент добавлен");
        }

        private void LoadCombo()
        {
            database.OpenCon();
            SqlCommand sc2 = new SqlCommand("SELECT * FROM wish", database.Con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(sc2);
            da2.Fill(dt2);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "Date";
            comboBox1.ValueMember = "ID";
            database.CloseConnection();
        }
    }
}
