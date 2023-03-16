using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_VK
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void phoneNumberField_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(phoneNumberField.Text, DataBase.condMail) || Regex.IsMatch(phoneNumberField.Text, DataBase.condPhoneNumber))
            {
                Confirm.Enabled = true;
                phoneNumberField.ForeColor = Color.Black;
            }
            else
            {
                Confirm.Enabled = false;
                phoneNumberField.ForeColor = Color.Red;
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(DataBase.isUniqueLogin(phoneNumberField.Text))
            {

                labelLoginAlreadyRegistered.Visible = false;
            }
            else
            {
                labelLoginAlreadyRegistered.Visible = true;
            }

            DataBase.formAuthorization.Visible = true;
            Close();
        }

        private void FormRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase.formAuthorization.Visible = true;
        }

        private void passwordConfirmField_TextChanged(object sender, EventArgs e)
        {
            if(passwordConfirmField.Text != passwordField.Text)
            {
                passwordConfirmField.ForeColor = Color.Red;
                labelPasswordError.Visible = true;
            }
            else
            {
                passwordConfirmField.ForeColor = DefaultForeColor;
                labelPasswordError.Visible = false;
            }
        }
    }
}
