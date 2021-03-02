using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                admin a = new admin();
                a.Show();
                this.Hide();
            }
            else if(textBox1.Text == "worker" && textBox2.Text == "worker")
            {
                worker w = new worker();
                w.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных!");
            }
        }
    }
}
