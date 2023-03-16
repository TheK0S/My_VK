namespace My_VK
{
    partial class FormRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.iconVK = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameField = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.SecondNameField = new System.Windows.Forms.TextBox();
            this.LastNameField = new System.Windows.Forms.TextBox();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.passwordConfirmField = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.labelPasswordError = new System.Windows.Forms.Label();
            this.labelLoginAlreadyRegistered = new System.Windows.Forms.Label();
            this.labelEasyPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).BeginInit();
            this.SuspendLayout();
            // 
            // iconVK
            // 
            this.iconVK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconVK.Image = ((System.Drawing.Image)(resources.GetObject("iconVK.Image")));
            this.iconVK.InitialImage = ((System.Drawing.Image)(resources.GetObject("iconVK.InitialImage")));
            this.iconVK.Location = new System.Drawing.Point(556, 24);
            this.iconVK.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.iconVK.Name = "iconVK";
            this.iconVK.Size = new System.Drawing.Size(100, 100);
            this.iconVK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconVK.TabIndex = 1;
            this.iconVK.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(459, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите данные для регистрации";
            // 
            // FirstNameField
            // 
            this.FirstNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstNameField.Location = new System.Drawing.Point(444, 387);
            this.FirstNameField.Name = "FirstNameField";
            this.FirstNameField.Size = new System.Drawing.Size(340, 27);
            this.FirstNameField.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(359, 387);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(44, 21);
            this.labelFirstName.TabIndex = 4;
            this.labelFirstName.Text = "Имя:";
            // 
            // labelSecondName
            // 
            this.labelSecondName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSecondName.Location = new System.Drawing.Point(325, 447);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(78, 21);
            this.labelSecondName.TabIndex = 5;
            this.labelSecondName.Text = "Фамилия:";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(326, 507);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 21);
            this.labelLastName.TabIndex = 6;
            this.labelLastName.Text = "Отчество:";
            // 
            // SecondNameField
            // 
            this.SecondNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SecondNameField.Location = new System.Drawing.Point(444, 447);
            this.SecondNameField.Name = "SecondNameField";
            this.SecondNameField.Size = new System.Drawing.Size(340, 27);
            this.SecondNameField.TabIndex = 7;
            // 
            // LastNameField
            // 
            this.LastNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastNameField.Location = new System.Drawing.Point(444, 507);
            this.LastNameField.Name = "LastNameField";
            this.LastNameField.Size = new System.Drawing.Size(340, 27);
            this.LastNameField.TabIndex = 8;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBirthDate.Location = new System.Drawing.Point(282, 567);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(124, 21);
            this.labelBirthDate.TabIndex = 9;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(444, 567);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(444, 627);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(90, 24);
            this.radioButtonMan.TabIndex = 11;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Мужской";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGender.Location = new System.Drawing.Point(361, 627);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(41, 21);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Пол:";
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(563, 627);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(89, 24);
            this.radioButtonWoman.TabIndex = 13;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Женский";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordField.Location = new System.Drawing.Point(444, 267);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(340, 27);
            this.passwordField.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(336, 267);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(66, 21);
            this.labelPassword.TabIndex = 16;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhoneNumber.Location = new System.Drawing.Point(273, 207);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(133, 21);
            this.labelPhoneNumber.TabIndex = 15;
            this.labelPhoneNumber.Text = "Номер телефона:";
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumberField.Location = new System.Drawing.Point(444, 207);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(340, 27);
            this.phoneNumberField.TabIndex = 14;
            this.phoneNumberField.TextChanged += new System.EventHandler(this.phoneNumberField_TextChanged);
            // 
            // passwordConfirmField
            // 
            this.passwordConfirmField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordConfirmField.Location = new System.Drawing.Point(444, 327);
            this.passwordConfirmField.Name = "passwordConfirmField";
            this.passwordConfirmField.PasswordChar = '*';
            this.passwordConfirmField.Size = new System.Drawing.Size(340, 27);
            this.passwordConfirmField.TabIndex = 19;
            this.passwordConfirmField.TextChanged += new System.EventHandler(this.passwordConfirmField_TextChanged);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelConfirmPassword.Location = new System.Drawing.Point(244, 327);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(162, 21);
            this.labelConfirmPassword.TabIndex = 18;
            this.labelConfirmPassword.Text = "Подтвердить пароль:";
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
            this.Confirm.Location = new System.Drawing.Point(488, 687);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(237, 30);
            this.Confirm.TabIndex = 20;
            this.Confirm.Text = "Продолжить";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.BackColor = System.Drawing.SystemColors.Control;
            this.labelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordError.Location = new System.Drawing.Point(813, 330);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(167, 20);
            this.labelPasswordError.TabIndex = 21;
            this.labelPasswordError.Text = "Пароли не совпадают!";
            this.labelPasswordError.Visible = false;
            // 
            // labelLoginAlreadyRegistered
            // 
            this.labelLoginAlreadyRegistered.AutoSize = true;
            this.labelLoginAlreadyRegistered.BackColor = System.Drawing.SystemColors.Control;
            this.labelLoginAlreadyRegistered.ForeColor = System.Drawing.Color.Red;
            this.labelLoginAlreadyRegistered.Location = new System.Drawing.Point(813, 210);
            this.labelLoginAlreadyRegistered.Name = "labelLoginAlreadyRegistered";
            this.labelLoginAlreadyRegistered.Size = new System.Drawing.Size(228, 20);
            this.labelLoginAlreadyRegistered.TabIndex = 22;
            this.labelLoginAlreadyRegistered.Text = "Телефон уже зарегистрирован!";
            this.labelLoginAlreadyRegistered.Visible = false;
            // 
            // labelEasyPassword
            // 
            this.labelEasyPassword.AutoSize = true;
            this.labelEasyPassword.BackColor = System.Drawing.SystemColors.Control;
            this.labelEasyPassword.ForeColor = System.Drawing.Color.Red;
            this.labelEasyPassword.Location = new System.Drawing.Point(813, 270);
            this.labelEasyPassword.Name = "labelEasyPassword";
            this.labelEasyPassword.Size = new System.Drawing.Size(195, 20);
            this.labelEasyPassword.TabIndex = 23;
            this.labelEasyPassword.Text = "Слишком простой пароль!";
            this.labelEasyPassword.Visible = false;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.labelEasyPassword);
            this.Controls.Add(this.labelLoginAlreadyRegistered);
            this.Controls.Add(this.labelPasswordError);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.passwordConfirmField);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.radioButtonWoman);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.LastNameField);
            this.Controls.Add(this.SecondNameField);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelSecondName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.FirstNameField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconVK);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormRegistration";
            this.Text = "My VK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistration_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.iconVK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox iconVK;
        private Label label1;
        private TextBox FirstNameField;
        private Label labelFirstName;
        private Label labelSecondName;
        private Label labelLastName;
        private TextBox SecondNameField;
        private TextBox LastNameField;
        private Label labelBirthDate;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonMan;
        private Label labelGender;
        private RadioButton radioButtonWoman;
        private TextBox passwordField;
        private Label labelPassword;
        private Label labelPhoneNumber;
        private TextBox phoneNumberField;
        private TextBox passwordConfirmField;
        private Label labelConfirmPassword;
        private Button Confirm;
        private Label labelPasswordError;
        private Label labelLoginAlreadyRegistered;
        private Label labelEasyPassword;
    }
}