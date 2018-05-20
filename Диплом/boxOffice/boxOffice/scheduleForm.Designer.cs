namespace boxOffice
{
    partial class scheduleForm
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
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.perfomanceEndsLabel = new System.Windows.Forms.Label();
            this.perfomanceEndsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.perfomanceStartsLabel = new System.Windows.Forms.Label();
            this.perfomanceStartsDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.perfomanceDateLabel = new System.Windows.Forms.Label();
            this.perfomanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.theatreTextbox = new System.Windows.Forms.TextBox();
            this.theatreLabel = new System.Windows.Forms.Label();
            this.perfomancesLabel = new System.Windows.Forms.Label();
            this.perfomancesCombobox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).BeginInit();
            this.schedulePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scheduleDataGridView
            // 
            this.scheduleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scheduleDataGridView.Location = new System.Drawing.Point(9, 10);
            this.scheduleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.scheduleDataGridView.Name = "scheduleDataGridView";
            this.scheduleDataGridView.RowTemplate.Height = 24;
            this.scheduleDataGridView.Size = new System.Drawing.Size(676, 242);
            this.scheduleDataGridView.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(9, 258);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(139, 57);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(298, 258);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 57);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(154, 258);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(139, 57);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // schedulePanel
            // 
            this.schedulePanel.Controls.Add(this.perfomanceEndsLabel);
            this.schedulePanel.Controls.Add(this.perfomanceEndsDateTimePicker);
            this.schedulePanel.Controls.Add(this.perfomanceStartsLabel);
            this.schedulePanel.Controls.Add(this.perfomanceStartsDateTimePicker);
            this.schedulePanel.Controls.Add(this.perfomanceDateLabel);
            this.schedulePanel.Controls.Add(this.perfomanceDateTimePicker);
            this.schedulePanel.Controls.Add(this.theatreTextbox);
            this.schedulePanel.Controls.Add(this.theatreLabel);
            this.schedulePanel.Controls.Add(this.perfomancesLabel);
            this.schedulePanel.Controls.Add(this.perfomancesCombobox);
            this.schedulePanel.Controls.Add(this.submitButton);
            this.schedulePanel.Controls.Add(this.cancelButton);
            this.schedulePanel.Controls.Add(this.headerLabel);
            this.schedulePanel.Location = new System.Drawing.Point(9, 10);
            this.schedulePanel.Margin = new System.Windows.Forms.Padding(2);
            this.schedulePanel.Name = "schedulePanel";
            this.schedulePanel.Size = new System.Drawing.Size(676, 305);
            this.schedulePanel.TabIndex = 7;
            // 
            // perfomanceEndsLabel
            // 
            this.perfomanceEndsLabel.AutoSize = true;
            this.perfomanceEndsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceEndsLabel.Location = new System.Drawing.Point(13, 187);
            this.perfomanceEndsLabel.Name = "perfomanceEndsLabel";
            this.perfomanceEndsLabel.Size = new System.Drawing.Size(142, 20);
            this.perfomanceEndsLabel.TabIndex = 17;
            this.perfomanceEndsLabel.Text = "Время окончания";
            // 
            // perfomanceEndsDateTimePicker
            // 
            this.perfomanceEndsDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceEndsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.perfomanceEndsDateTimePicker.Location = new System.Drawing.Point(162, 182);
            this.perfomanceEndsDateTimePicker.Name = "perfomanceEndsDateTimePicker";
            this.perfomanceEndsDateTimePicker.ShowUpDown = true;
            this.perfomanceEndsDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceEndsDateTimePicker.TabIndex = 16;
            // 
            // perfomanceStartsLabel
            // 
            this.perfomanceStartsLabel.AutoSize = true;
            this.perfomanceStartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceStartsLabel.Location = new System.Drawing.Point(13, 155);
            this.perfomanceStartsLabel.Name = "perfomanceStartsLabel";
            this.perfomanceStartsLabel.Size = new System.Drawing.Size(117, 20);
            this.perfomanceStartsLabel.TabIndex = 15;
            this.perfomanceStartsLabel.Text = "Время начала";
            // 
            // perfomanceStartsDateTimePicker
            // 
            this.perfomanceStartsDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceStartsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.perfomanceStartsDateTimePicker.Location = new System.Drawing.Point(162, 150);
            this.perfomanceStartsDateTimePicker.Name = "perfomanceStartsDateTimePicker";
            this.perfomanceStartsDateTimePicker.ShowUpDown = true;
            this.perfomanceStartsDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceStartsDateTimePicker.TabIndex = 14;
            // 
            // perfomanceDateLabel
            // 
            this.perfomanceDateLabel.AutoSize = true;
            this.perfomanceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateLabel.Location = new System.Drawing.Point(13, 123);
            this.perfomanceDateLabel.Name = "perfomanceDateLabel";
            this.perfomanceDateLabel.Size = new System.Drawing.Size(131, 20);
            this.perfomanceDateLabel.TabIndex = 13;
            this.perfomanceDateLabel.Text = "Дата спектакля";
            // 
            // perfomanceDateTimePicker
            // 
            this.perfomanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.perfomanceDateTimePicker.Location = new System.Drawing.Point(162, 118);
            this.perfomanceDateTimePicker.Name = "perfomanceDateTimePicker";
            this.perfomanceDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceDateTimePicker.TabIndex = 12;
            // 
            // theatreTextbox
            // 
            this.theatreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.theatreTextbox.Location = new System.Drawing.Point(73, 85);
            this.theatreTextbox.Name = "theatreTextbox";
            this.theatreTextbox.Size = new System.Drawing.Size(586, 26);
            this.theatreTextbox.TabIndex = 11;
            // 
            // theatreLabel
            // 
            this.theatreLabel.AutoSize = true;
            this.theatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreLabel.Location = new System.Drawing.Point(13, 88);
            this.theatreLabel.Name = "theatreLabel";
            this.theatreLabel.Size = new System.Drawing.Size(54, 20);
            this.theatreLabel.TabIndex = 10;
            this.theatreLabel.Text = "Театр";
            // 
            // perfomancesLabel
            // 
            this.perfomancesLabel.AutoSize = true;
            this.perfomancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomancesLabel.Location = new System.Drawing.Point(13, 52);
            this.perfomancesLabel.Name = "perfomancesLabel";
            this.perfomancesLabel.Size = new System.Drawing.Size(91, 20);
            this.perfomancesLabel.TabIndex = 9;
            this.perfomancesLabel.Text = "Спектакль";
            // 
            // perfomancesCombobox
            // 
            this.perfomancesCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomancesCombobox.FormattingEnabled = true;
            this.perfomancesCombobox.Location = new System.Drawing.Point(110, 49);
            this.perfomancesCombobox.Name = "perfomancesCombobox";
            this.perfomancesCombobox.Size = new System.Drawing.Size(549, 28);
            this.perfomancesCombobox.TabIndex = 8;
            this.perfomancesCombobox.SelectedIndexChanged += new System.EventHandler(this.perfomancesCombobox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(337, 231);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(139, 57);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Action";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(191, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 57);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(302, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(60, 20);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Action";
            // 
            // scheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(692, 474);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scheduleDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "scheduleForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.scheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView scheduleDataGridView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel schedulePanel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label perfomancesLabel;
        private System.Windows.Forms.ComboBox perfomancesCombobox;
        private System.Windows.Forms.TextBox theatreTextbox;
        private System.Windows.Forms.Label theatreLabel;
        private System.Windows.Forms.Label perfomanceDateLabel;
        private System.Windows.Forms.DateTimePicker perfomanceDateTimePicker;
        private System.Windows.Forms.Label perfomanceEndsLabel;
        private System.Windows.Forms.DateTimePicker perfomanceEndsDateTimePicker;
        private System.Windows.Forms.Label perfomanceStartsLabel;
        private System.Windows.Forms.DateTimePicker perfomanceStartsDateTimePicker;
    }
}