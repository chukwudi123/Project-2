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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyHome mh = new MyHome();
            mh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            OrderForm2 form = new OrderForm2();
            form.Show();
        }




        // check the checkBox before clicking on the  Order button for payment.if you do not check  the checkbox the button will not work

        private void OrderForm_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void Do_Checked()
        {
            button1.Enabled = checkBox1.Checked;
            button2.Enabled = checkBox2.Checked;
            button3.Enabled = checkBox3.Checked;
            button4.Enabled = checkBox4.Checked;
            button5.Enabled = checkBox5.Checked;
            button6.Enabled = checkBox6.Checked;
            button7.Enabled = checkBox7.Checked;
            button8.Enabled = checkBox8.Checked;
            button9.Enabled = checkBox9.Checked;
            button10.Enabled = checkBox10.Checked;
            button11.Enabled = checkBox11.Checked;
            button12.Enabled = checkBox12.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            Do_Checked();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                 Do_Checked();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
                 Do_Checked();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
                 Do_Checked();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {  
                Do_Checked();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
                Do_Checked();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
               Do_Checked();
        }

       
       

      

        

       


        
       



    }
}
