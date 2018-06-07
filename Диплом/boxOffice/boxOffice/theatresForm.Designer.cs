namespace boxOffice
{
    partial class theatresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(theatresForm));
            this.theatresDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.theatresPanel = new System.Windows.Forms.Panel();
            this.theatreAdressTextbox = new System.Windows.Forms.TextBox();
            this.theatreAdressLabel = new System.Windows.Forms.Label();
            this.theatreNameTextbox = new System.Windows.Forms.TextBox();
            this.theatreNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.inFieldLabel = new System.Windows.Forms.Label();
            this.findTextbox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.fieldsCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.theatresDataGridView)).BeginInit();
            this.theatresPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // theatresDataGridView
            // 
            this.theatresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theatresDataGridView.Location = new System.Drawing.Point(12, 12);
            this.theatresDataGridView.Name = "theatresDataGridView";
            this.theatresDataGridView.Size = new System.Drawing.Size(898, 213);
            this.theatresDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(302, 231);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 57);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(157, 231);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(139, 57);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 231);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 57);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // theatresPanel
            // 
            this.theatresPanel.Controls.Add(this.theatreAdressTextbox);
            this.theatresPanel.Controls.Add(this.theatreAdressLabel);
            this.theatresPanel.Controls.Add(this.theatreNameTextbox);
            this.theatresPanel.Controls.Add(this.theatreNameLabel);
            this.theatresPanel.Controls.Add(this.submitButton);
            this.theatresPanel.Controls.Add(this.cancelButton);
            this.theatresPanel.Controls.Add(this.headerLabel);
            this.theatresPanel.Location = new System.Drawing.Point(12, 12);
            this.theatresPanel.Name = "theatresPanel";
            this.theatresPanel.Size = new System.Drawing.Size(898, 377);
            this.theatresPanel.TabIndex = 8;
            // 
            // theatreAdressTextbox
            // 
            this.theatreAdressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreAdressTextbox.Location = new System.Drawing.Point(285, 84);
            this.theatreAdressTextbox.Multiline = true;
            this.theatreAdressTextbox.Name = "theatreAdressTextbox";
            this.theatreAdressTextbox.Size = new System.Drawing.Size(460, 92);
            this.theatreAdressTextbox.TabIndex = 13;
            // 
            // theatreAdressLabel
            // 
            this.theatreAdressLabel.AutoSize = true;
            this.theatreAdressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreAdressLabel.Location = new System.Drawing.Point(138, 87);
            this.theatreAdressLabel.Name = "theatreAdressLabel";
            this.theatreAdressLabel.Size = new System.Drawing.Size(115, 20);
            this.theatreAdressLabel.TabIndex = 12;
            this.theatreAdressLabel.Text = "Адрес театра";
            // 
            // theatreNameTextbox
            // 
            this.theatreNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreNameTextbox.Location = new System.Drawing.Point(285, 52);
            this.theatreNameTextbox.Name = "theatreNameTextbox";
            this.theatreNameTextbox.Size = new System.Drawing.Size(460, 26);
            this.theatreNameTextbox.TabIndex = 11;
            // 
            // theatreNameLabel
            // 
            this.theatreNameLabel.AutoSize = true;
            this.theatreNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreNameLabel.Location = new System.Drawing.Point(138, 55);
            this.theatreNameLabel.Name = "theatreNameLabel";
            this.theatreNameLabel.Size = new System.Drawing.Size(141, 20);
            this.theatreNameLabel.TabIndex = 10;
            this.theatreNameLabel.Text = "Название театра";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(434, 197);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(139, 57);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Action";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(288, 197);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 57);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(400, 20);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(58, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "action";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(779, 302);
            this.findButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(124, 27);
            this.findButton.TabIndex = 19;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // inFieldLabel
            // 
            this.inFieldLabel.AutoSize = true;
            this.inFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inFieldLabel.Location = new System.Drawing.Point(329, 306);
            this.inFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inFieldLabel.Name = "inFieldLabel";
            this.inFieldLabel.Size = new System.Drawing.Size(59, 20);
            this.inFieldLabel.TabIndex = 18;
            this.inFieldLabel.Text = "в поле";
            // 
            // findTextbox
            // 
            this.findTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTextbox.Location = new System.Drawing.Point(66, 303);
            this.findTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findTextbox.Name = "findTextbox";
            this.findTextbox.Size = new System.Drawing.Size(260, 26);
            this.findTextbox.TabIndex = 17;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findLabel.Location = new System.Drawing.Point(10, 306);
            this.findLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(57, 20);
            this.findLabel.TabIndex = 16;
            this.findLabel.Text = "Найти";
            // 
            // fieldsCombobox
            // 
            this.fieldsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldsCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldsCombobox.FormattingEnabled = true;
            this.fieldsCombobox.Location = new System.Drawing.Point(388, 302);
            this.fieldsCombobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fieldsCombobox.Name = "fieldsCombobox";
            this.fieldsCombobox.Size = new System.Drawing.Size(388, 28);
            this.fieldsCombobox.TabIndex = 15;
            // 
            // theatresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(920, 400);
            this.Controls.Add(this.theatresPanel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.inFieldLabel);
            this.Controls.Add(this.findTextbox);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.fieldsCombobox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.theatresDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "theatresForm";
            this.Text = "Театры";
            this.Load += new System.EventHandler(this.theatresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.theatresDataGridView)).EndInit();
            this.theatresPanel.ResumeLayout(false);
            this.theatresPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView theatresDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel theatresPanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox theatreAdressTextbox;
        private System.Windows.Forms.Label theatreAdressLabel;
        private System.Windows.Forms.TextBox theatreNameTextbox;
        private System.Windows.Forms.Label theatreNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label inFieldLabel;
        private System.Windows.Forms.TextBox findTextbox;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.ComboBox fieldsCombobox;
    }
}