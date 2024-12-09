using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppWebServiceTest;


namespace WindowsFormsAppWebServiceTest
{
    public partial class Form1 : Form
    {
        private ServiceReference1.WebServiceKoosSoapClient myClient = new ServiceReference1.WebServiceKoosSoapClient();
        private string myConnectionString = WindowsFormsAppWebServiceTest.Properties.Settings.Default.myConnectionString;
       private imageProcess process = new imageProcess();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblOutput.Text = this.myClient.AddTwoInts(7, 8);

        }

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = process.GetPhoto();
        }
    }
}
