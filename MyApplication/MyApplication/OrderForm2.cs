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
    public partial class OrderForm2 : Form
    {
        public OrderForm2()
        {
            InitializeComponent();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment pay = new Payment();
            pay.Show();
        }
        private void button25_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
            this.Hide();
        }

        private void OrderForm2_Load(object sender, EventArgs e)
        {
            Do_Checked();
        }
        private void Do_Checked()
        {
            checkBox13.Checked = button13.Enabled;
            button14.Enabled = checkBox14.Checked;
            button15.Enabled = checkBox15.Checked;
            button16.Enabled = checkBox16.Checked;
            button17.Enabled = checkBox17.Checked;
            button18.Enabled = checkBox18.Checked;
            button19.Enabled = checkBox19.Checked;
            button20.Enabled = checkBox20.Checked;
            button21.Enabled = checkBox21.Checked;
            button22.Enabled = checkBox22.Checked;
            button23.Enabled = checkBox23.Checked;
            button24.Enabled = checkBox24.Checked;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            Do_Checked();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

       
    }
}
