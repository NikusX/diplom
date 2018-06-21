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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scheduleForm));
            this.scheduleDataGridView = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.schedulePanel = new System.Windows.Forms.Panel();
            this.rubLabel = new System.Windows.Forms.Label();
            this.ticketCostLabel = new System.Windows.Forms.Label();
            this.ticketCostTextbox = new System.Windows.Forms.TextBox();
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
            this.findButton = new System.Windows.Forms.Button();
            this.inFieldLabel = new System.Windows.Forms.Label();
            this.findTextbox = new System.Windows.Forms.TextBox();
            this.findLabel = new System.Windows.Forms.Label();
            this.fieldsCombobox = new System.Windows.Forms.ComboBox();
            this.scheduleReportButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterCombobox = new System.Windows.Forms.ComboBox();
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
            this.scheduleDataGridView.Size = new System.Drawing.Size(918, 242);
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
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
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
            this.schedulePanel.Controls.Add(this.rubLabel);
            this.schedulePanel.Controls.Add(this.ticketCostLabel);
            this.schedulePanel.Controls.Add(this.ticketCostTextbox);
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
            this.schedulePanel.Size = new System.Drawing.Size(918, 412);
            this.schedulePanel.TabIndex = 7;
            // 
            // rubLabel
            // 
            this.rubLabel.AutoSize = true;
            this.rubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rubLabel.Location = new System.Drawing.Point(400, 223);
            this.rubLabel.Name = "rubLabel";
            this.rubLabel.Size = new System.Drawing.Size(38, 20);
            this.rubLabel.TabIndex = 20;
            this.rubLabel.Text = "руб.";
            // 
            // ticketCostLabel
            // 
            this.ticketCostLabel.AutoSize = true;
            this.ticketCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketCostLabel.Location = new System.Drawing.Point(135, 223);
            this.ticketCostLabel.Name = "ticketCostLabel";
            this.ticketCostLabel.Size = new System.Drawing.Size(107, 20);
            this.ticketCostLabel.TabIndex = 19;
            this.ticketCostLabel.Text = "Цена билета";
            // 
            // ticketCostTextbox
            // 
            this.ticketCostTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ticketCostTextbox.Location = new System.Drawing.Point(283, 220);
            this.ticketCostTextbox.Name = "ticketCostTextbox";
            this.ticketCostTextbox.Size = new System.Drawing.Size(102, 26);
            this.ticketCostTextbox.TabIndex = 18;
            // 
            // perfomanceEndsLabel
            // 
            this.perfomanceEndsLabel.AutoSize = true;
            this.perfomanceEndsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceEndsLabel.Location = new System.Drawing.Point(134, 193);
            this.perfomanceEndsLabel.Name = "perfomanceEndsLabel";
            this.perfomanceEndsLabel.Size = new System.Drawing.Size(142, 20);
            this.perfomanceEndsLabel.TabIndex = 17;
            this.perfomanceEndsLabel.Text = "Время окончания";
            // 
            // perfomanceEndsDateTimePicker
            // 
            this.perfomanceEndsDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceEndsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.perfomanceEndsDateTimePicker.Location = new System.Drawing.Point(283, 188);
            this.perfomanceEndsDateTimePicker.Name = "perfomanceEndsDateTimePicker";
            this.perfomanceEndsDateTimePicker.ShowUpDown = true;
            this.perfomanceEndsDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceEndsDateTimePicker.TabIndex = 16;
            // 
            // perfomanceStartsLabel
            // 
            this.perfomanceStartsLabel.AutoSize = true;
            this.perfomanceStartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceStartsLabel.Location = new System.Drawing.Point(134, 161);
            this.perfomanceStartsLabel.Name = "perfomanceStartsLabel";
            this.perfomanceStartsLabel.Size = new System.Drawing.Size(117, 20);
            this.perfomanceStartsLabel.TabIndex = 15;
            this.perfomanceStartsLabel.Text = "Время начала";
            // 
            // perfomanceStartsDateTimePicker
            // 
            this.perfomanceStartsDateTimePicker.Checked = false;
            this.perfomanceStartsDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceStartsDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.perfomanceStartsDateTimePicker.Location = new System.Drawing.Point(283, 156);
            this.perfomanceStartsDateTimePicker.Name = "perfomanceStartsDateTimePicker";
            this.perfomanceStartsDateTimePicker.ShowUpDown = true;
            this.perfomanceStartsDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceStartsDateTimePicker.TabIndex = 14;
            // 
            // perfomanceDateLabel
            // 
            this.perfomanceDateLabel.AutoSize = true;
            this.perfomanceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateLabel.Location = new System.Drawing.Point(134, 128);
            this.perfomanceDateLabel.Name = "perfomanceDateLabel";
            this.perfomanceDateLabel.Size = new System.Drawing.Size(131, 20);
            this.perfomanceDateLabel.TabIndex = 13;
            this.perfomanceDateLabel.Text = "Дата спектакля";
            // 
            // perfomanceDateTimePicker
            // 
            this.perfomanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.perfomanceDateTimePicker.Location = new System.Drawing.Point(283, 124);
            this.perfomanceDateTimePicker.Name = "perfomanceDateTimePicker";
            this.perfomanceDateTimePicker.Size = new System.Drawing.Size(497, 26);
            this.perfomanceDateTimePicker.TabIndex = 12;
            // 
            // theatreTextbox
            // 
            this.theatreTextbox.Enabled = false;
            this.theatreTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.theatreTextbox.Location = new System.Drawing.Point(194, 91);
            this.theatreTextbox.Name = "theatreTextbox";
            this.theatreTextbox.Size = new System.Drawing.Size(586, 26);
            this.theatreTextbox.TabIndex = 11;
            // 
            // theatreLabel
            // 
            this.theatreLabel.AutoSize = true;
            this.theatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreLabel.Location = new System.Drawing.Point(134, 93);
            this.theatreLabel.Name = "theatreLabel";
            this.theatreLabel.Size = new System.Drawing.Size(54, 20);
            this.theatreLabel.TabIndex = 10;
            this.theatreLabel.Text = "Театр";
            // 
            // perfomancesLabel
            // 
            this.perfomancesLabel.AutoSize = true;
            this.perfomancesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomancesLabel.Location = new System.Drawing.Point(134, 58);
            this.perfomancesLabel.Name = "perfomancesLabel";
            this.perfomancesLabel.Size = new System.Drawing.Size(91, 20);
            this.perfomancesLabel.TabIndex = 9;
            this.perfomancesLabel.Text = "Спектакль";
            // 
            // perfomancesCombobox
            // 
            this.perfomancesCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfomancesCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomancesCombobox.FormattingEnabled = true;
            this.perfomancesCombobox.Location = new System.Drawing.Point(231, 54);
            this.perfomancesCombobox.Name = "perfomancesCombobox";
            this.perfomancesCombobox.Size = new System.Drawing.Size(549, 28);
            this.perfomancesCombobox.TabIndex = 8;
            this.perfomancesCombobox.SelectedIndexChanged += new System.EventHandler(this.perfomancesCombobox_SelectedIndexChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(457, 270);
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
            this.cancelButton.Location = new System.Drawing.Point(311, 270);
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
            this.headerLabel.Location = new System.Drawing.Point(423, 17);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(60, 20);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Action";
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.Location = new System.Drawing.Point(786, 329);
            this.findButton.Margin = new System.Windows.Forms.Padding(2);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(124, 27);
            this.findButton.TabIndex = 14;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // inFieldLabel
            // 
            this.inFieldLabel.AutoSize = true;
            this.inFieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inFieldLabel.Location = new System.Drawing.Point(336, 332);
            this.inFieldLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inFieldLabel.Name = "inFieldLabel";
            this.inFieldLabel.Size = new System.Drawing.Size(59, 20);
            this.inFieldLabel.TabIndex = 13;
            this.inFieldLabel.Text = "в поле";
            // 
            // findTextbox
            // 
            this.findTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findTextbox.Location = new System.Drawing.Point(73, 330);
            this.findTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.findTextbox.Name = "findTextbox";
            this.findTextbox.Size = new System.Drawing.Size(260, 26);
            this.findTextbox.TabIndex = 12;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findLabel.Location = new System.Drawing.Point(16, 332);
            this.findLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(57, 20);
            this.findLabel.TabIndex = 11;
            this.findLabel.Text = "Найти";
            // 
            // fieldsCombobox
            // 
            this.fieldsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldsCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldsCombobox.FormattingEnabled = true;
            this.fieldsCombobox.Location = new System.Drawing.Point(395, 329);
            this.fieldsCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.fieldsCombobox.Name = "fieldsCombobox";
            this.fieldsCombobox.Size = new System.Drawing.Size(388, 28);
            this.fieldsCombobox.TabIndex = 10;
            // 
            // scheduleReportButton
            // 
            this.scheduleReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.scheduleReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleReportButton.Location = new System.Drawing.Point(443, 258);
            this.scheduleReportButton.Name = "scheduleReportButton";
            this.scheduleReportButton.Size = new System.Drawing.Size(216, 57);
            this.scheduleReportButton.TabIndex = 15;
            this.scheduleReportButton.Text = "Создать полный отчет\r\nо расписании";
            this.scheduleReportButton.UseVisualStyleBackColor = false;
            this.scheduleReportButton.Click += new System.EventHandler(this.scheduleReportButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetFilterButton.Location = new System.Drawing.Point(17, 395);
            this.resetFilterButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(198, 27);
            this.resetFilterButton.TabIndex = 32;
            this.resetFilterButton.Text = "Очистить фильтр";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.resetFilterButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.Location = new System.Drawing.Point(785, 362);
            this.filterButton.Margin = new System.Windows.Forms.Padding(2);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(124, 27);
            this.filterButton.TabIndex = 31;
            this.filterButton.Text = "Фильтр";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(335, 366);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "в поле";
            // 
            // filterTextbox
            // 
            this.filterTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterTextbox.Location = new System.Drawing.Point(90, 363);
            this.filterTextbox.Margin = new System.Windows.Forms.Padding(2);
            this.filterTextbox.Name = "filterTextbox";
            this.filterTextbox.Size = new System.Drawing.Size(242, 26);
            this.filterTextbox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Фильтр";
            // 
            // filterCombobox
            // 
            this.filterCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterCombobox.FormattingEnabled = true;
            this.filterCombobox.Location = new System.Drawing.Point(394, 362);
            this.filterCombobox.Margin = new System.Windows.Forms.Padding(2);
            this.filterCombobox.Name = "filterCombobox";
            this.filterCombobox.Size = new System.Drawing.Size(388, 28);
            this.filterCombobox.TabIndex = 27;
            // 
            // scheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(936, 433);
            this.Controls.Add(this.schedulePanel);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterCombobox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.inFieldLabel);
            this.Controls.Add(this.findTextbox);
            this.Controls.Add(this.findLabel);
            this.Controls.Add(this.fieldsCombobox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.scheduleDataGridView);
            this.Controls.Add(this.scheduleReportButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "scheduleForm";
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.scheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataGridView)).EndInit();
            this.schedulePanel.ResumeLayout(false);
            this.schedulePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label inFieldLabel;
        private System.Windows.Forms.TextBox findTextbox;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.ComboBox fieldsCombobox;
        private System.Windows.Forms.Button scheduleReportButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filterCombobox;
        private System.Windows.Forms.Label rubLabel;
        private System.Windows.Forms.Label ticketCostLabel;
        private System.Windows.Forms.TextBox ticketCostTextbox;
    }
}