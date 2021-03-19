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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }
        private void lblFNameResult_Click(object sender, EventArgs e)
        {
        }
        private void lblLNameResult_Click(object sender, EventArgs e)
        {   
        }
        private void lblEmailResult_Click(object sender, EventArgs e)
        {
        }
        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblEmailResult.Text = Signup.Email;
            lblLNameResult.Text = Signup.LName;
            lblFNameResult.Text = Signup.FName;
            if(Signup.SMS == true)
            {
                labelSMSResult.Text = "Ticked";
            }
            if(Signup.Reports == true)
            {
                labelReportsResult.Text = "Ticked";
            }
            if(Signup.TransRep == true)
            {
                labelTransReportsResult.Text = "Ticked";
            }
        }

        private void btnCorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you \n Your input has been saved");
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void btnIncorrect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry for the wrong record,\n Please enter your data again");
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }
    }
}
