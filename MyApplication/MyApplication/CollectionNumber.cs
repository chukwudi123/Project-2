using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class CollectionNumber : Form
    {
        public CollectionNumber()
        {
            InitializeComponent();

        }
        private void txtGetValue_TextChanged(object sender, EventArgs e)
        {
           
        }
        // this line of code print the collecton  

        int value = 0;

        private void Print_Click(object sender, EventArgs ex)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.PaperSize = new PaperSize(" A4 ", 827, 1170);
                pd.PrintPage += new PrintPageEventHandler(this.pd_PrintPage);
                pd.Print();
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occurred while printing", e.ToString());
            }
            
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            ev.Graphics.DrawString(txtGenerating.Text.ToString(), new Font("Time New Roman", 24, FontStyle.Bold),
                Brushes.Black, 20, 100);
        }
        // ths is the time and date setting 
        private void CollectionNumber_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        // this code display the collection number, it generate different number

        private void btnCollection_Click(object sender, EventArgs e)
        {
            Random Random = new Random();

            int numbers = Random.Next(0, 1001);

            txtGenerating.Text = numbers.ToString();
         
        }

        // the is code display the mainpage which is the myHome

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            MyHome MyHome = new MyHome();
            MyHome.Show();

        }

       

        

       
    }
}
