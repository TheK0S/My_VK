using System.Text.RegularExpressions;

namespace My_VK
{
    public partial class formAuthorization : Form
    {
        string condMail = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
        string condNum = @"^\+\d{12}$";
        
        public formAuthorization()
        {
            InitializeComponent();
            popUpWindow.SetToolTip(checkBoxSaveEnterData, "Выберите, чтобы сохранить\nданные аккаунта для быстрого\nвхода на этом устройстве");
        }

        private void phoneNumberField_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(phoneNumberField.Text, condMail) || Regex.IsMatch(phoneNumberField.Text, condNum))
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
            var formRegistaration = new FormRegistration();
            formRegistaration.Show();
        }
    }
}