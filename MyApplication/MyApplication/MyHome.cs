using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class MyHome : Form
    {
        public MyHome()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MyHome home = new MyHome();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm order = new OrderForm();
            order.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Payment Payment = new Payment();
            Payment.Show();
        }

        
        // button that connect to the alarm.
        

        
        

     

      

        

    
    }
}
