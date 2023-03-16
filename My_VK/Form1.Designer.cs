namespace My_VK
{
    partial class FormAuthorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAuthorization));
            this.iconVK = new System.Windows.Forms.PictureBox();
            this.labelEnterEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.labelEnterPassword = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.checkBoxSaveEnterData = new System.Windows.Forms.CheckBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.popUpWindow = new System.Windows.Forms.ToolTip(this.components);
            this.registrationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAuthorizationError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).BeginInit();
            this.SuspendLayout();
            // 
            // iconVK
            // 
            this.iconVK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconVK.Image = ((System.Drawing.Image)(resources.GetObject("iconVK.Image")));
            this.iconVK.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconVK.InitialImage")));
            this.iconVK.Location = new System.Drawing.Point(390, 31);
            this.iconVK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconVK.Name = "iconVK";
            this.iconVK.Size = new System.Drawing.Size(100, 100);
            this.iconVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconVK.TabIndex = 0;
            this.iconVK.TabStop = false;
            // 
            // labelEnterEmail
            // 
            this.labelEnterEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterEmail.AutoSize = true;
            this.labelEnterEmail.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterEmail.Location = new System.Drawing.Point(367, 142);
            this.labelEnterEmail.Name = "labelEnterEmail";
            this.labelEnterEmail.Size = new System.Drawing.Size(145, 22);
            this.labelEnterEmail.TabIndex = 1;
            this.labelEnterEmail.Text = "Введите номер";
            this.labelEnterEmail.Click += new System.EventHandler(this.labelEnterEmail_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(285, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ваш номер телефона будет использоватся\r\n                    для входа в аакаунт";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberField.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumberField.Location = new System.Drawing.Point(321, 229);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(237, 27);
            this.phoneNumberField.TabIndex = 3;
            this.phoneNumberField.TextChanged += new System.EventHandler(this.phoneNumberField_TextChanged);
            // 
            // labelEnterPassword
            // 
            this.labelEnterPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEnterPassword.AutoSize = true;
            this.labelEnterPassword.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterPassword.Location = new System.Drawing.Point(364, 272);
            this.labelEnterPassword.Name = "labelEnterPassword";
            this.labelEnterPassword.Size = new System.Drawing.Size(151, 22);
            this.labelEnterPassword.TabIndex = 4;
            this.labelEnterPassword.Text = "Введите пароль";
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordField.BackColor = System.Drawing.SystemColors.Window;
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordField.Location = new System.Drawing.Point(321, 309);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(237, 27);
            this.passwordField.TabIndex = 5;
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // checkBoxSaveEnterData
            // 
            this.checkBoxSaveEnterData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxSaveEnterData.AutoSize = true;
            this.checkBoxSaveEnterData.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxSaveEnterData.Location = new System.Drawing.Point(370, 350);
            this.checkBoxSaveEnterData.Name = "checkBoxSaveEnterData";
            this.checkBoxSaveEnterData.Size = new System.Drawing.Size(138, 24);
            this.checkBoxSaveEnterData.TabIndex = 6;
            this.checkBoxSaveEnterData.Text = "Сохранить вход";
            this.checkBoxSaveEnterData.UseVisualStyleBackColor = true;
            this.checkBoxSaveEnterData.MouseLeave += new System.EventHandler(this.checkBoxSaveEnterData_MouseLeave);
            this.checkBoxSaveEnterData.MouseHover += new System.EventHandler(this.checkBoxSaveEnterData_MouseHover);
            // 
            // Confirm
            // 
            this.Confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Confirm.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Confirm.FlatAppearance.BorderSize = 0;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.Confirm.Location = new System.Drawing.Point(321, 389);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(237, 30);
            this.Confirm.TabIndex = 7;
            this.Confirm.Text = "Продолжить";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // popUpWindow
            // 
            this.popUpWindow.BackColor = System.Drawing.SystemColors.Menu;
            this.popUpWindow.ToolTipTitle = "Сохранить вход";
            // 
            // registrationButton
            // 
            this.registrationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registrationButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.registrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.registrationButton.FlatAppearance.BorderSize = 0;
            this.registrationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registrationButton.ForeColor = System.Drawing.SystemColors.Window;
            this.registrationButton.Location = new System.Drawing.Point(321, 469);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(237, 30);
            this.registrationButton.TabIndex = 8;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = false;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(321, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Если у вас нет учетной записи";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthorizationError
            // 
            this.labelAuthorizationError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAuthorizationError.AutoSize = true;
            this.labelAuthorizationError.BackColor = System.Drawing.SystemColors.Menu;
            this.labelAuthorizationError.ForeColor = System.Drawing.Color.Red;
            this.labelAuthorizationError.Location = new System.Drawing.Point(332, 517);
            this.labelAuthorizationError.Name = "labelAuthorizationError";
            this.labelAuthorizationError.Size = new System.Drawing.Size(216, 20);
            this.labelAuthorizationError.TabIndex = 10;
            this.labelAuthorizationError.Text = "Неверный логин или пароль!";
            this.labelAuthorizationError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAuthorizationError.Visible = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.labelAuthorizationError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationButton);
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
            this.Name = "FormAuthorization";
            this.Text = "My VK";
            this.Load += new System.EventHandler(this.formAuthorization_Load);
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
        private ToolTip popUpWindow;
        private Button registrationButton;
        private Label label2;
        private Label labelAuthorizationError;
    }
}