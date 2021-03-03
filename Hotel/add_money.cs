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
    public partial class add_money : Form
    {
        public add_money()
        {
            InitializeComponent();
            LoadCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(comboBox1.SelectedValue);
            
            database.OpenCon();
            string add = String.Format("INSERT INTO money (ID_Client, Date, Money_View) VALUES ("+c+",'"+dateTimePicker1.Value.Date+"','" + textBox1.Text + "')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Оплата добавлена");
        }

        private void LoadCombo()
        {
            database.OpenCon();
            SqlCommand sc = new SqlCommand("SELECT * FROM clients", database.Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sc);
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Surname";
            comboBox1.ValueMember = "ID";
            database.CloseConnection();
        }
    }
}
