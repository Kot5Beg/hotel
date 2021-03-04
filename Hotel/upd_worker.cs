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
    public partial class upd_worker : Form
    {
        public static string id { get; set; }
        public static string surname { get; set; }
        public static string name { get; set; }
        public static string patronymic { get; set; }
        public static string address { get; set; }
        public static string phone { get; set; }
        public static string email { get; set; }
        public static string date { get; set; }

        public upd_worker()
        {
            InitializeComponent();
        }

        public upd_worker(string ID, string Sur, string N, string P, string A, string Ph, string Em, string D)
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
        }

        public void LoadText()
        {
            textBox1.Text = surname;
            textBox2.Text = name;
            textBox3.Text = patronymic;
            textBox6.Text = address;
            textBox5.Text = phone;
            textBox4.Text = email;
            dateTimePicker1.Text = date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string save = String.Format("UPDATE {0} SET Surname = '{1}', Name = '{2}', Patronymic = '{3}', Address = '{4}', Phone = '{5}', Email = '{6}', Date_of_birth = '{7}' WHERE ID = '{8}'", "worker", textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text,dateTimePicker1.Value.Date, id);
            SqlCommand com = new SqlCommand(save, database.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
        }
    }
}
