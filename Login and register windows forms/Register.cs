using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndRegistration
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            if (male.Checked == true) female.Checked = false;
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            if (female.Checked == true) male.Checked = false;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (username.Text.Length < 3 || username.Text.Length > 16)
                msg += "\n - username must be between 3 and 16 characters";
            if (male.Checked == false && female.Checked == false)
                msg += "\n - please select gender.";
            if (password.Text != confirm_password.Text)
                msg += "\n - password doesnt match";
            if (mbnum.Text.Length != 10)
                msg += "\n - mobile number must have 10 digits";


            if (msg == "") msg = "Registration succesful.";

            MessageBox.Show(msg);
        }
    }
}