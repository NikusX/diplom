namespace boxOffice
{
    partial class userProfileForm
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
            this.myProfileLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextbox = new System.Windows.Forms.TextBox();
            this.fioLabel = new System.Windows.Forms.Label();
            this.fioTextbox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.adressLabel = new System.Windows.Forms.Label();
            this.adressTextbox = new System.Windows.Forms.TextBox();
            this.personalDiscountLabel = new System.Windows.Forms.Label();
            this.personalDiscount = new System.Windows.Forms.Label();
            this.changeProfileButton = new System.Windows.Forms.Button();
            this.changeProfileCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // myProfileLabel
            // 
            this.myProfileLabel.AutoSize = true;
            this.myProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myProfileLabel.Location = new System.Drawing.Point(131, 9);
            this.myProfileLabel.Name = "myProfileLabel";
            this.myProfileLabel.Size = new System.Drawing.Size(163, 26);
            this.myProfileLabel.TabIndex = 0;
            this.myProfileLabel.Text = "Мой профиль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(20, 60);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(59, 20);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Логин:";
            // 
            // loginTextbox
            // 
            this.loginTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextbox.Location = new System.Drawing.Point(81, 57);
            this.loginTextbox.Name = "loginTextbox";
            this.loginTextbox.ReadOnly = true;
            this.loginTextbox.Size = new System.Drawing.Size(323, 26);
            this.loginTextbox.TabIndex = 2;
            this.loginTextbox.Tag = "";
            // 
            // fioLabel
            // 
            this.fioLabel.AutoSize = true;
            this.fioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioLabel.Location = new System.Drawing.Point(20, 92);
            this.fioLabel.Name = "fioLabel";
            this.fioLabel.Size = new System.Drawing.Size(51, 20);
            this.fioLabel.TabIndex = 7;
            this.fioLabel.Text = "ФИО:";
            // 
            // fioTextbox
            // 
            this.fioTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioTextbox.Location = new System.Drawing.Point(81, 89);
            this.fioTextbox.Name = "fioTextbox";
            this.fioTextbox.ReadOnly = true;
            this.fioTextbox.Size = new System.Drawing.Size(323, 26);
            this.fioTextbox.TabIndex = 6;
            this.fioTextbox.Tag = "";
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(154, 121);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(250, 26);
            this.birthdateDateTimePicker.TabIndex = 9;
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateLabel.Location = new System.Drawing.Point(20, 126);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(132, 20);
            this.birthdateLabel.TabIndex = 8;
            this.birthdateLabel.Text = "Дата рождения:";
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressLabel.Location = new System.Drawing.Point(20, 156);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(61, 20);
            this.adressLabel.TabIndex = 11;
            this.adressLabel.Text = "Адрес:";
            // 
            // adressTextbox
            // 
            this.adressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTextbox.Location = new System.Drawing.Point(81, 153);
            this.adressTextbox.Multiline = true;
            this.adressTextbox.Name = "adressTextbox";
            this.adressTextbox.ReadOnly = true;
            this.adressTextbox.Size = new System.Drawing.Size(323, 65);
            this.adressTextbox.TabIndex = 10;
            this.adressTextbox.Tag = "";
            // 
            // personalDiscountLabel
            // 
            this.personalDiscountLabel.AutoSize = true;
            this.personalDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalDiscountLabel.Location = new System.Drawing.Point(20, 221);
            this.personalDiscountLabel.Name = "personalDiscountLabel";
            this.personalDiscountLabel.Size = new System.Drawing.Size(209, 20);
            this.personalDiscountLabel.TabIndex = 12;
            this.personalDiscountLabel.Text = "Персональная скидка (%):";
            // 
            // personalDiscount
            // 
            this.personalDiscount.AutoSize = true;
            this.personalDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalDiscount.Location = new System.Drawing.Point(226, 221);
            this.personalDiscount.Name = "personalDiscount";
            this.personalDiscount.Size = new System.Drawing.Size(18, 20);
            this.personalDiscount.TabIndex = 13;
            this.personalDiscount.Text = "0";
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.Enabled = false;
            this.changeProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProfileButton.Location = new System.Drawing.Point(96, 285);
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.Size = new System.Drawing.Size(239, 39);
            this.changeProfileButton.TabIndex = 14;
            this.changeProfileButton.Text = "Изменить";
            this.changeProfileButton.UseVisualStyleBackColor = true;
            this.changeProfileButton.Click += new System.EventHandler(this.changeProfileButton_Click);
            // 
            // changeProfileCheckbox
            // 
            this.changeProfileCheckbox.AutoSize = true;
            this.changeProfileCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProfileCheckbox.Location = new System.Drawing.Point(100, 255);
            this.changeProfileCheckbox.Name = "changeProfileCheckbox";
            this.changeProfileCheckbox.Size = new System.Drawing.Size(239, 24);
            this.changeProfileCheckbox.TabIndex = 15;
            this.changeProfileCheckbox.Text = "Изменить данные профиля";
            this.changeProfileCheckbox.UseVisualStyleBackColor = true;
            this.changeProfileCheckbox.CheckedChanged += new System.EventHandler(this.changeProfileCheckbox_CheckedChanged);
            // 
            // userProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 333);
            this.Controls.Add(this.changeProfileCheckbox);
            this.Controls.Add(this.changeProfileButton);
            this.Controls.Add(this.personalDiscount);
            this.Controls.Add(this.personalDiscountLabel);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.adressTextbox);
            this.Controls.Add(this.birthdateDateTimePicker);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.fioLabel);
            this.Controls.Add(this.fioTextbox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.loginTextbox);
            this.Controls.Add(this.myProfileLabel);
            this.Name = "userProfileForm";
            this.Text = "Профиль пользователя";
            this.Load += new System.EventHandler(this.userProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label myProfileLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginTextbox;
        private System.Windows.Forms.Label fioLabel;
        private System.Windows.Forms.TextBox fioTextbox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.TextBox adressTextbox;
        private System.Windows.Forms.Label personalDiscountLabel;
        private System.Windows.Forms.Label personalDiscount;
        private System.Windows.Forms.Button changeProfileButton;
        private System.Windows.Forms.CheckBox changeProfileCheckbox;
    }
}