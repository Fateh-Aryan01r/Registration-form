using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_form
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void label1_Click(object senlder, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//Button 1

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sum = a + b;
            textBox3.Text = sum.ToString();
            MessageBox.Show("Here is your Answer" + textBox3);


        }

        private void button2_Click(object sender, EventArgs e)
        {//Button 2
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sum = a - b;
            textBox3.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {//Button 3
            try
            {
                decimal a = Convert.ToDecimal(textBox1.Text);
                decimal b = Convert.ToDecimal(textBox2.Text);
                if (b != 0)
                {
                    decimal modulus = a % b;
                    textBox3.Text = modulus.ToString();
                }
                else
                {
                    MessageBox.Show("Error");
                }
                
        
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Division by Zero is not allow's" + MessageBoxButtons.OKCancel + MessageBoxIcon.Warning );
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {//Button 4
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int sum = a * b;
            textBox3.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {// Button 5
            decimal a = Convert.ToDecimal(textBox1.Text);
            decimal b = Convert.ToDecimal(textBox2.Text);
            decimal sum = a / b;
            textBox3.Text = sum.ToString();     
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 