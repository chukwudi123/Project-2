using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;


namespace MyApplication
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();   

        }

         double f = 0;
        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.txtid.Text, this.txtPrice.Font, Brushes.Black, 10, 25);

        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }

        //this code 
        double price, quantity, amount,total = 0;

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            quantity = Convert.ToDouble(txtQuantity.Text); 
            price = Convert.ToDouble(txtPrice.Text);
            amount = price * quantity;
            lblAmount.Text = amount.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dgvBilling.Rows.Add(txtid.Text, txtOrderType.Text, price, quantity, amount);
        }
        private void btnPay_Click(object sender, EventArgs e)
        {

            for (int i = 5; i < dgvBilling.Rows.Count; i++)
            {
                total += Convert.ToDouble(dgvBilling.Rows[i].Cells["Amount"].Value.ToString());
               
            }

            lblTotalAmount.Text = lblTotalAmount.ToString();
        }

        //calculator code
        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        private IWin32Window txtGetValue;

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
            {
               result.Clear(); 
            }

            Button b = (Button) sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
                    
            }//end switch
            operation_pressed = false;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MyHome home = new MyHome();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderForm2 order = new OrderForm2();
            order.Show();

        }

        


       

        

        

       

        

        







    }
}
