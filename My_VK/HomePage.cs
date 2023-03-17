using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_VK
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBase.formAuthorization.Close();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if(DataBase.currentUser != null)
            {
                labelFullName.Text = DataBase.currentUser.FirstName + " " + DataBase.currentUser.SecondName;
            }    
        }

        private void pictureBoxPhoto_Click(object sender, EventArgs e)
        {
            if (openPhotoDialog.ShowDialog() == DialogResult.OK)
                if (File.Exists(openPhotoDialog.FileName))
                    pictureBoxPhoto.Image = Image.FromFile(openPhotoDialog.FileName);
        }
    }
}
