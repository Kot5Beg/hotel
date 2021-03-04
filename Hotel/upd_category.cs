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
    public partial class upd_category : Form
    {
        public static string id { get; set; }
        public static string rating { get; set; }

        public upd_category()
        {
            InitializeComponent();
        }

        public upd_category(string ID, string RATING)
        {
            InitializeComponent();
            id = ID;
            rating = RATING;
            LoadData();
        }

        public void LoadData()
        {
            textBox1.Text = rating;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            database.OpenCon();
            string save = String.Format("UPDATE {0} SET rating = '{1}' WHERE ID = '{2}'", "category", textBox1.Text, id);
            SqlCommand com = new SqlCommand(save, database.Con);
            com.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
        }
    }
}
