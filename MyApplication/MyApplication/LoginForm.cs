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

namespace MyApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            // this code connect the applicathion to the Database,where he collect information inside the database
            SqlConnection con = new SqlConnection("Data Source=STANLEY\\SQLEXPRESS;Initial Catalog=MyDatabase;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from FastFood where Username = '"+ textBox1.Text +"' and Password = '" + textBox2.Text +"' and LoginAs = '" + comboBox1.Text + "'",con);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            int count = 0;

            while (dr.Read())
            {
                count += 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Your Login was successful");

                this.Hide();
                MyHome myHome = new MyHome();
                myHome.Show();
                
            }
            else if (count > 0)
            {
                MessageBox.Show(" Try again once more");
            }
            else
            {
                MessageBox.Show("Wrong Username and Password");
            }
       // this code is to clear the text in the testBox 
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";


        }
       /// this code display the text on the textBoxs
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter username")
            {
                textBox1.Text = "";

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter username";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter Password")
            {
                textBox2.Text = "";

                textBox2.ForeColor = Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter Password";

                textBox2.ForeColor = Color.Silver;
            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "choose user")
            {
                comboBox1.Text = "";

                comboBox1.ForeColor = Color.Black;
            }

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "choose user";

                comboBox1.ForeColor = Color.Silver;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

       

      

        
    }
}
