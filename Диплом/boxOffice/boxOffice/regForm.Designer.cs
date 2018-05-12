namespace boxOffice
{
    partial class regForm
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
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.fioTextbox = new System.Windows.Forms.TextBox();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adressLabel = new System.Windows.Forms.Label();
            this.adressTextbox = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.passwordRepeatLabel = new System.Windows.Forms.Label();
            this.passwordRepeatTextbox = new System.Windows.Forms.TextBox();
            this.PasswordShowCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextbox.Location = new System.Drawing.Point(44, 40);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.Size = new System.Drawing.Size(323, 26);
            this.loginTextbox.TabIndex = 0;
            this.loginTextbox.Tag = "";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(40, 17);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(55, 20);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Логин";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(40, 69);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(67, 20);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Пароль";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextbox.Location = new System.Drawing.Point(44, 92);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '•';
            this.passwordTextbox.Size = new System.Drawing.Size(323, 26);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.Tag = "";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(40, 203);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(47, 20);
            this.fioLabel.TabIndex = 5;
            this.fioLabel.Text = "ФИО";
            // 
            // fioTextbox
            // 
            this.fioTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextbox.Location = new System.Drawing.Point(44, 226);
            this.fioTextbox.Name = "fioTextbox";
            this.fioTextbox.Size = new System.Drawing.Size(323, 26);
            this.fioTextbox.TabIndex = 4;
            this.fioTextbox.Tag = "";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateLabel.Location = new System.Drawing.Point(40, 255);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(128, 20);
            this.birthdateLabel.TabIndex = 6;
            this.birthdateLabel.Text = "Дата рождения";
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(44, 278);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(161, 26);
            this.birthdateDateTimePicker.TabIndex = 7;
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(40, 307);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(57, 20);
            this.adressLabel.TabIndex = 9;
            this.adressLabel.Text = "Адрес";
            // 
            // adressTextbox
            // 
            this.adressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTextbox.Location = new System.Drawing.Point(44, 330);
            this.adressTextbox.Multiline = true;
            this.adressTextbox.Name = "adressTextbox";
            this.adressTextbox.Size = new System.Drawing.Size(323, 65);
            this.adressTextbox.TabIndex = 8;
            this.adressTextbox.Tag = "";
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(44, 400);
            this.regButton.Margin = new System.Windows.Forms.Padding(2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(323, 35);
            this.regButton.TabIndex = 10;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // passwordRepeatLabel
            // 
            this.passwordRepeatLabel.AutoSize = true;
            this.passwordRepeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatLabel.Location = new System.Drawing.Point(40, 121);
            this.passwordRepeatLabel.Name = "passwordRepeatLabel";
            this.passwordRepeatLabel.Size = new System.Drawing.Size(152, 20);
            this.passwordRepeatLabel.TabIndex = 12;
            this.passwordRepeatLabel.Text = "Повторите пароль";
            // 
            // passwordRepeatTextbox
            // 
            this.passwordRepeatTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordRepeatTextbox.Location = new System.Drawing.Point(44, 144);
            this.passwordRepeatTextbox.Name = "passwordRepeatTextbox";
            this.passwordRepeatTextbox.PasswordChar = '•';
            this.passwordRepeatTextbox.Size = new System.Drawing.Size(323, 26);
            this.passwordRepeatTextbox.TabIndex = 11;
            this.passwordRepeatTextbox.Tag = "";
            // 
            // PasswordShowCheckbox
            // 
            this.PasswordShowCheckbox.AutoSize = true;
            this.PasswordShowCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordShowCheckbox.Location = new System.Drawing.Point(47, 173);
            this.PasswordShowCheckbox.Name = "PasswordShowCheckbox";
            this.PasswordShowCheckbox.Size = new System.Drawing.Size(160, 24);
            this.PasswordShowCheckbox.TabIndex = 13;
            this.PasswordShowCheckbox.Text = "Показать пароль";
            this.PasswordShowCheckbox.UseVisualStyleBackColor = true;
            this.PasswordShowCheckbox.CheckedChanged += new System.EventHandler(this.PasswordShowCheckbox_CheckedChanged);
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 446);
            this.Controls.Add(this.PasswordShowCheckbox);
            this.Controls.Add(this.passwordRepeatLabel);
            this.Controls.Add(this.passwordRepeatTextbox);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.adressTextbox);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.fioTextbox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextbox);
            this.Name = "regForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TextBox fioTextbox;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox adressTextbox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label passwordRepeatLabel;
        private System.Windows.Forms.TextBox passwordRepeatTextbox;
        private System.Windows.Forms.CheckBox PasswordShowCheckbox;
    }
}