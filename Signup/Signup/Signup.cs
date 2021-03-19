using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup
{
    public partial class Signup : Form
    {
        public static string FName;
        public static string LName;
        public static string Email;

        public static Boolean SMS;
        public static Boolean Reports;
        public static Boolean TransRep;
        Confirmation Confirmation = new Confirmation();
        public Signup()
        {
            InitializeComponent();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            FName = textBoxFName.Text;
            LName = textBoxLName.Text;
            Email = textBoxEmail.Text;
            if (Email == "" || LName == "" || FName == "")
            {
                MessageBox.Show("Field cannot be left empty");
            }
            else
            {
                this.Hide();
                Confirmation.Show();
            }
        }

        private void checkBoxSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSMS.Checked)
            {
                SMS = true;
                lblSMS.Text = "SMS charges may apply";
            }
            else
            {
                SMS = false;
                lblSMS.Text = "......";
            }
        }

        private void checkBoxReports_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxReports.Checked)
            {
                Reports = true;
                lblReports.Text = "";
            }
            else
            {
                Reports = false;
                lblReports.Text = "......";
            }
        }

        private void checkBoxTransRep_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTransRep.Checked)
            {
                TransRep = true;
                lblTransReports.Text = "Transactions charges may apply";
            }
            else
            {
                TransRep = false;
                lblTransReports.Text = "......";
            }
        }
    }
}
