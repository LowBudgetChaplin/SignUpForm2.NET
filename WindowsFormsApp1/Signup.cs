using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        public static string fName;
        public static string lName;
        public static string email;
        public static Boolean sms;
        public static Boolean reports;
        public static Boolean transactions;

        Confirmation c = new Confirmation();

        public Signup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTransactions.Checked)
            {
                transactions = true;
                labelTransactions.Text = "Services charges may \napply for transactions.";
            }
            else
            {
                transactions = false;
                labelTransactions.Text = "....";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            fName = txtFirstName.Text;
            lName = txtLastName.Text;
            email = txtEmail.Text;

            this.Hide();
            c.Show();
        }

        private void checkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSMS.Checked)
            {
                sms = true;
                labelSMS.Text = "Services charges may \napply for SMS.";
            }
            else
            {
                sms = false;
                labelSMS.Text = "....";
            }
        }

        private void checkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReports.Checked)
            {
                reports = true;
            }
            else
            {
                reports = false;
            }

        }

        private void labelSMS_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
