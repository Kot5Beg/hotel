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
    public partial class add_worker : Form
    {
        public add_worker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string add = String.Format("INSERT INTO worker (Surname, Name, Patronymic, Address, Phone, Email, Date_of_birth, Gender) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox6.Text + "', '" + textBox5.Text + "', '" +textBox4.Text+ "', '" + dateTimePicker1.Value.Date + "')");
            SqlCommand sc = new SqlCommand(add, database.Con);
            sc.ExecuteNonQuery();
            database.CloseConnection();
            MessageBox.Show("Работник добавлен");
        }
    }
}
