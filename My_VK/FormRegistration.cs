using Microsoft.VisualBasic.ApplicationServices;
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

        public bool IsUniqueLogin()
        {
            foreach (var item in DataBase.users)
                if (phoneNumberField.Text == item.Login)
                    return false;

            return true;
        }

        public bool PasswordComplexityCheck()
        {
            return true;
        }

        public bool IsAuthorizationFieldsValidated()
        {
            return IsUniqueLogin()
                && passwordField.Text == passwordConfirmField.Text
                && FirstNameField.TextLength > 2
                && SecondNameField.TextLength > 2
                && LastNameField.TextLength > 2
                && dateTimePicker1.Value < dateTimePicker1.MaxDate
                && (radioButtonMan.Checked || radioButtonWoman.Checked);
        }

        private void phoneNumberField_TextChanged(object sender, EventArgs e)
        {
            if (DataBase.IsPhoneNumberValidated(phoneNumberField.Text))
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
            if(IsUniqueLogin())
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
        }
    }
}
