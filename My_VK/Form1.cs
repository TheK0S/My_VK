using System.Text.RegularExpressions;

namespace My_VK
{
    public partial class FormAuthorization : Form
    {      
        public FormAuthorization()
        {
            InitializeComponent();
            popUpWindow.SetToolTip(checkBoxSaveEnterData, "Выберите, чтобы сохранить\nданные аккаунта для быстрого\nвхода на этом устройстве");
        }

        private void phoneNumberField_TextChanged(object sender, EventArgs e)
        {
            labelAuthorizationError.Visible = false;

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

        private void checkBoxSaveEnterData_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void checkBoxSaveEnterData_MouseLeave(object sender, EventArgs e)
        {

        }

        private void formAuthorization_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelEnterEmail_Click(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DataBase.formRegistration = new FormRegistration();
            DataBase.formRegistration.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if(DataBase.IsUserVrified(phoneNumberField.Text, passwordField.Text))
            {
                DataBase.homePage = new HomePage();
                DataBase.homePage.Show();
            }
            else
            {
                labelAuthorizationError.Visible = true;
            }
        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {
            labelAuthorizationError.Visible = false;
        }
    }
}