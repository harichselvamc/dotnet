using System;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        WebService1SoapClient obj;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int ans = obj.Add(a, b); // Call the web service method
                MessageBox.Show("INCOME TAX AFTER TAX DEDUCTION: " + ans);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            obj = new WebService1SoapClient(); // Initialize the web service client
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event can be used for input validation if needed
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Optional event handler
        }
    }
}
