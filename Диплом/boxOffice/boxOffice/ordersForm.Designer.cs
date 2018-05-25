namespace boxOffice
{
    partial class ordersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordersForm));
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.perfomanceNameLabel = new System.Windows.Forms.Label();
            this.perfomanceDateLabel = new System.Windows.Forms.Label();
            this.perfomanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.theatreCombobox = new System.Windows.Forms.ComboBox();
            this.theatreLabel = new System.Windows.Forms.Label();
            this.perfomanceCombobox = new System.Windows.Forms.ComboBox();
            this.perfomanceLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.ordersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(16, 15);
            this.ordersDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.Size = new System.Drawing.Size(903, 256);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(531, 278);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(249, 70);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(273, 278);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(249, 70);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(16, 278);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(249, 70);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить заказ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.perfomanceNameLabel);
            this.ordersPanel.Controls.Add(this.perfomanceDateLabel);
            this.ordersPanel.Controls.Add(this.perfomanceDateTimePicker);
            this.ordersPanel.Controls.Add(this.submitButton);
            this.ordersPanel.Controls.Add(this.cancelButton);
            this.ordersPanel.Controls.Add(this.countLabel);
            this.ordersPanel.Controls.Add(this.countNumericUpDown);
            this.ordersPanel.Controls.Add(this.theatreCombobox);
            this.ordersPanel.Controls.Add(this.theatreLabel);
            this.ordersPanel.Controls.Add(this.perfomanceCombobox);
            this.ordersPanel.Controls.Add(this.perfomanceLabel);
            this.ordersPanel.Controls.Add(this.headerLabel);
            this.ordersPanel.Location = new System.Drawing.Point(16, 15);
            this.ordersPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(903, 518);
            this.ordersPanel.TabIndex = 11;
            // 
            // perfomanceNameLabel
            // 
            this.perfomanceNameLabel.AutoSize = true;
            this.perfomanceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceNameLabel.Location = new System.Drawing.Point(155, 235);
            this.perfomanceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perfomanceNameLabel.Name = "perfomanceNameLabel";
            this.perfomanceNameLabel.Size = new System.Drawing.Size(61, 25);
            this.perfomanceNameLabel.TabIndex = 16;
            this.perfomanceNameLabel.Text = "name";
            // 
            // perfomanceDateLabel
            // 
            this.perfomanceDateLabel.AutoSize = true;
            this.perfomanceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateLabel.Location = new System.Drawing.Point(17, 64);
            this.perfomanceDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perfomanceDateLabel.Name = "perfomanceDateLabel";
            this.perfomanceDateLabel.Size = new System.Drawing.Size(163, 25);
            this.perfomanceDateLabel.TabIndex = 15;
            this.perfomanceDateLabel.Text = "Дата спектакля";
            // 
            // perfomanceDateTimePicker
            // 
            this.perfomanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.perfomanceDateTimePicker.Location = new System.Drawing.Point(213, 58);
            this.perfomanceDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.perfomanceDateTimePicker.Name = "perfomanceDateTimePicker";
            this.perfomanceDateTimePicker.Size = new System.Drawing.Size(661, 30);
            this.perfomanceDateTimePicker.TabIndex = 14;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(465, 426);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(185, 70);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Action";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(271, 426);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(185, 70);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(17, 186);
            this.countLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(123, 25);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Количество";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNumericUpDown.Location = new System.Drawing.Point(160, 183);
            this.countNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(160, 30);
            this.countNumericUpDown.TabIndex = 5;
            // 
            // theatreCombobox
            // 
            this.theatreCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.theatreCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreCombobox.FormattingEnabled = true;
            this.theatreCombobox.Location = new System.Drawing.Point(160, 100);
            this.theatreCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.theatreCombobox.Name = "theatreCombobox";
            this.theatreCombobox.Size = new System.Drawing.Size(715, 33);
            this.theatreCombobox.TabIndex = 4;
            // 
            // theatreLabel
            // 
            this.theatreLabel.AutoSize = true;
            this.theatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreLabel.Location = new System.Drawing.Point(17, 103);
            this.theatreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.theatreLabel.Name = "theatreLabel";
            this.theatreLabel.Size = new System.Drawing.Size(68, 25);
            this.theatreLabel.TabIndex = 3;
            this.theatreLabel.Text = "Театр";
            // 
            // perfomanceCombobox
            // 
            this.perfomanceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfomanceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceCombobox.FormattingEnabled = true;
            this.perfomanceCombobox.Location = new System.Drawing.Point(160, 142);
            this.perfomanceCombobox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.perfomanceCombobox.Name = "perfomanceCombobox";
            this.perfomanceCombobox.Size = new System.Drawing.Size(715, 33);
            this.perfomanceCombobox.TabIndex = 2;
            // 
            // perfomanceLabel
            // 
            this.perfomanceLabel.AutoSize = true;
            this.perfomanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceLabel.Location = new System.Drawing.Point(17, 145);
            this.perfomanceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.perfomanceLabel.Name = "perfomanceLabel";
            this.perfomanceLabel.Size = new System.Drawing.Size(111, 25);
            this.perfomanceLabel.TabIndex = 1;
            this.perfomanceLabel.Text = "Спектакль";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(399, 18);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(70, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "action";
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(935, 548);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ordersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.ComboBox theatreCombobox;
        private System.Windows.Forms.Label theatreLabel;
        private System.Windows.Forms.ComboBox perfomanceCombobox;
        private System.Windows.Forms.Label perfomanceLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label perfomanceDateLabel;
        private System.Windows.Forms.DateTimePicker perfomanceDateTimePicker;
        private System.Windows.Forms.Label perfomanceNameLabel;
    }
}