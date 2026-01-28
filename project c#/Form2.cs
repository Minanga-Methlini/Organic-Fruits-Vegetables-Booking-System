using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_c_
{

    public partial class Form2 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Documents\project c#\project c#\Database2.mdf"";Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Admin values('" + textBox1.Text + "','" + textBox2.Text + "')", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully insert");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 signup = new Form1();
            signup.ShowDialog();
        }
    }
}
