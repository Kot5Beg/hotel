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
    public partial class upd_client : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string email { get; set; }
        public static string date { get; set; }

        public upd_client()
        {
            InitializeComponent();
        }

        public upd_client(string ID, string Sur, string N, string P, string A, string Ph, string Em, string D)
        {
            InitializeComponent();
            id = ID;
            surname = Sur;
            name = N;
            patronymic = P;
            address = A;
            phone = Ph;
            email = Em;
            date = D;
            LoadText();
            LoadCombo();
        }

        public void LoadText()
        {
            textBox1.Text = surname;
            textBox2.Text = name;
            textBox3.Text = patronymic;
            comboBox1.Text = address;
            textBox4.Text = phone;
            textBox5.Text = email;
            dateTimePicker1.Text = date;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox1.SelectedValue);
            database.OpenCon();
            string save = String.Format("UPDATE {0} SET Surname = '{1}', Name = '{2}', Patronymic = '{3}', ID_Wish = '{4}', Phone = '{5}', Email = '{6}', Date_birth = '{7}' WHERE ID = '{8}'", "clients", textBox1.Text, textBox2.Text, textBox3.Text, n, textBox4.Text, textBox5.Text, dateTimePicker1.Value.Date, id);
            SqlCommand com = new SqlCommand(save, database.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
        }
    }
}
