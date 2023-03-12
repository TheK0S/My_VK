using System.Text.RegularExpressions;

namespace My_VK
{
    public partial class formAuthorization : Form
    {
        string cond = @"(\w + ([-+.]\w +)*@\w + ([-.]\w +)*\.\w + ([-.]\w +)*)";
        string condNum = @"[+,1 - 9,0]";
        
        public formAuthorization()
        {
            InitializeComponent();
        }

        private void phoneNumberField_TextChanged(object sender, EventArgs e)
        {
            if(Regex.IsMatch(phoneNumberField.Text, cond) || (Regex.IsMatch(phoneNumberField.Text, condNum) && phoneNumberField.TextLength > 9))
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
    }
}