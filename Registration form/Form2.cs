using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName = txtstudentName.Text;
            string EmailAddress = textBox2.Text;
            int Age = Convert.ToInt32(textBox3.Text);
            if (Age <= 17)
            {
                MessageBox.Show("Invalid Age", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            string Gender = "";
            if (radioButton1.Checked == true)
            {
                Gender = "Male";

            }
            else if (radioButton2.Checked == true)
            {
                Gender = "Female";
            }
            else
            {
                MessageBox.Show("Ivalid Gender", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }

            string Subject = textBox4.Text;
            DateTime DateofBirth = datetimePicker1.Value;
            string MaritalStatus = checkBox1.Text;
            if (MaritalStatus == checkBox1.Text )
            {
                MaritalStatus = "Married";
            }else if (MaritalStatus == checkBox2.Text)
            {
                MaritalStatus = "Unmarried";
            }

              
            
            string Language = "";
            if (radioButton3.Checked == true)
            {
                    Language = "English";
            } else if (radioButton4.Checked == true)
            {
                    Language = "Hindi";
            }


            MessageBox.Show(studentName +  EmailAddress  + Age +   Gender  + Subject + DateofBirth  + MaritalStatus + Language);
           

        }

        


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
