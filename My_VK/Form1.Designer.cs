namespace My_VK
{
    partial class formAuthorization
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAuthorization));
            this.iconVK = new System.Windows.Forms.PictureBox();
            this.labelEnterEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.checkBoxSaveEnterData = new System.Windows.Forms.CheckBox();
            this.Confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).BeginInit();
            this.SuspendLayout();
            // 
            // iconVK
            // 
            this.iconVK.Image = ((System.Drawing.Image)(resources.GetObject("iconVK.Image")));
            this.iconVK.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconVK.InitialImage")));
            this.iconVK.Location = new System.Drawing.Point(395, 32);
            this.iconVK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconVK.Name = "iconVK";
            this.iconVK.Size = new System.Drawing.Size(87, 99);
            this.iconVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconVK.TabIndex = 0;
            this.iconVK.TabStop = false;
            // 
            // labelEnterEmail
            // 
            this.labelEnterEmail.AutoSize = true;
            this.labelEnterEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterEmail.Location = new System.Drawing.Point(365, 143);
            this.labelEnterEmail.Name = "labelEnterEmail";
            this.labelEnterEmail.Size = new System.Drawing.Size(145, 22);
            this.labelEnterEmail.TabIndex = 1;
            this.labelEnterEmail.Text = "Введите номер";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(279, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваш номер телефона будет использоватся\r\n                    для входа в аакаунт";
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(319, 228);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(237, 27);
            this.phoneNumberField.TabIndex = 3;
            this.phoneNumberField.TextChanged += new System.EventHandler(this.phoneNumberField_TextChanged);
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.AutoSize = true;
            this.labelEnterPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterPassword.Location = new System.Drawing.Point(364, 277);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(151, 22);
            this.labelEnterPassword.TabIndex = 4;
            this.labelEnterPassword.Text = "Введите пароль";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(319, 318);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(237, 27);
            this.passwordField.TabIndex = 5;
            // 
            // checkBoxSaveEnterData
            // 
            this.checkBoxSaveEnterData.AutoSize = true;
            this.checkBoxSaveEnterData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxSaveEnterData.Location = new System.Drawing.Point(321, 360);
            this.checkBoxSaveEnterData.Name = "checkBoxSaveEnterData";
            this.checkBoxSaveEnterData.Size = new System.Drawing.Size(138, 24);
            this.checkBoxSaveEnterData.TabIndex = 6;
            this.checkBoxSaveEnterData.Text = "Сохранить вход";
            this.checkBoxSaveEnterData.UseVisualStyleBackColor = true;
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.Confirm.Location = new System.Drawing.Point(321, 402);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(237, 27);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Продолжить";
            this.Confirm.UseVisualStyleBackColor = false;
            // 
            // formAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.checkBoxSaveEnterData);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.labelEnterPassword);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEnterEmail);
            this.Controls.Add(this.iconVK);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formAuthorization";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox iconVK;
        private Label labelEnterEmail;
        private Label label1;
        private TextBox phoneNumberField;
        private Label labelEnterPassword;
        private TextBox passwordField;
        private CheckBox checkBoxSaveEnterData;
        private Button Confirm;
    }
}