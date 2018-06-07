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
            this.addButton = new System.Windows.Forms.Button();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.ticket6 = new System.Windows.Forms.GroupBox();
            this.seatTicket6NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket6NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket6Label = new System.Windows.Forms.Label();
            this.rowTicket6Label = new System.Windows.Forms.Label();
            this.ticket5 = new System.Windows.Forms.GroupBox();
            this.seatTicket5NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket5NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket5Label = new System.Windows.Forms.Label();
            this.rowTicket5Label = new System.Windows.Forms.Label();
            this.ticket4 = new System.Windows.Forms.GroupBox();
            this.seatTicket4NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket4NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket4Label = new System.Windows.Forms.Label();
            this.rowTicket4Label = new System.Windows.Forms.Label();
            this.ticket3 = new System.Windows.Forms.GroupBox();
            this.seatTicket3NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket3NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket3Label = new System.Windows.Forms.Label();
            this.rowTicket3Label = new System.Windows.Forms.Label();
            this.ticket2 = new System.Windows.Forms.GroupBox();
            this.seatTicket2NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket2NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket2Label = new System.Windows.Forms.Label();
            this.rowTicket2Label = new System.Windows.Forms.Label();
            this.ticket1 = new System.Windows.Forms.GroupBox();
            this.seatTicket1NUD = new System.Windows.Forms.NumericUpDown();
            this.rowTicket1NUD = new System.Windows.Forms.NumericUpDown();
            this.seatTicket1Label = new System.Windows.Forms.Label();
            this.rowTicket1Label = new System.Windows.Forms.Label();
            this.perfomanceDateLabel = new System.Windows.Forms.Label();
            this.perfomanceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.countNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.perfomanceCombobox = new System.Windows.Forms.ComboBox();
            this.perfomanceLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.ordersPanel.SuspendLayout();
            this.ticket6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket6NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket6NUD)).BeginInit();
            this.ticket5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket5NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket5NUD)).BeginInit();
            this.ticket4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket4NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket4NUD)).BeginInit();
            this.ticket3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket3NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket3NUD)).BeginInit();
            this.ticket2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket2NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket2NUD)).BeginInit();
            this.ticket1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket1NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(677, 208);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellDoubleClick);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(205, 226);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(187, 57);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(12, 226);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(187, 57);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Добавить заказ";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ordersPanel
            // 
            this.ordersPanel.Controls.Add(this.ticket6);
            this.ordersPanel.Controls.Add(this.ticket5);
            this.ordersPanel.Controls.Add(this.ticket4);
            this.ordersPanel.Controls.Add(this.ticket3);
            this.ordersPanel.Controls.Add(this.ticket2);
            this.ordersPanel.Controls.Add(this.ticket1);
            this.ordersPanel.Controls.Add(this.perfomanceDateLabel);
            this.ordersPanel.Controls.Add(this.perfomanceDateTimePicker);
            this.ordersPanel.Controls.Add(this.submitButton);
            this.ordersPanel.Controls.Add(this.cancelButton);
            this.ordersPanel.Controls.Add(this.countLabel);
            this.ordersPanel.Controls.Add(this.countNumericUpDown);
            this.ordersPanel.Controls.Add(this.perfomanceCombobox);
            this.ordersPanel.Controls.Add(this.perfomanceLabel);
            this.ordersPanel.Controls.Add(this.headerLabel);
            this.ordersPanel.Location = new System.Drawing.Point(12, 9);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(677, 413);
            this.ordersPanel.TabIndex = 11;
            // 
            // ticket6
            // 
            this.ticket6.Controls.Add(this.seatTicket6NUD);
            this.ticket6.Controls.Add(this.rowTicket6NUD);
            this.ticket6.Controls.Add(this.seatTicket6Label);
            this.ticket6.Controls.Add(this.rowTicket6Label);
            this.ticket6.Location = new System.Drawing.Point(451, 244);
            this.ticket6.Name = "ticket6";
            this.ticket6.Size = new System.Drawing.Size(213, 92);
            this.ticket6.TabIndex = 20;
            this.ticket6.TabStop = false;
            this.ticket6.Text = "Билет №6";
            // 
            // seatTicket6NUD
            // 
            this.seatTicket6NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket6NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket6NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket6NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket6NUD.Name = "seatTicket6NUD";
            this.seatTicket6NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket6NUD.TabIndex = 7;
            this.seatTicket6NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket6NUD
            // 
            this.rowTicket6NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket6NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket6NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket6NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket6NUD.Name = "rowTicket6NUD";
            this.rowTicket6NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket6NUD.TabIndex = 6;
            this.rowTicket6NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket6Label
            // 
            this.seatTicket6Label.AutoSize = true;
            this.seatTicket6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket6Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket6Label.Name = "seatTicket6Label";
            this.seatTicket6Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket6Label.TabIndex = 5;
            this.seatTicket6Label.Text = "Место";
            // 
            // rowTicket6Label
            // 
            this.rowTicket6Label.AutoSize = true;
            this.rowTicket6Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket6Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket6Label.Name = "rowTicket6Label";
            this.rowTicket6Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket6Label.TabIndex = 4;
            this.rowTicket6Label.Text = "Ряд";
            // 
            // ticket5
            // 
            this.ticket5.Controls.Add(this.seatTicket5NUD);
            this.ticket5.Controls.Add(this.rowTicket5NUD);
            this.ticket5.Controls.Add(this.seatTicket5Label);
            this.ticket5.Controls.Add(this.rowTicket5Label);
            this.ticket5.Location = new System.Drawing.Point(232, 244);
            this.ticket5.Name = "ticket5";
            this.ticket5.Size = new System.Drawing.Size(213, 92);
            this.ticket5.TabIndex = 18;
            this.ticket5.TabStop = false;
            this.ticket5.Text = "Билет №5";
            // 
            // seatTicket5NUD
            // 
            this.seatTicket5NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket5NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket5NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket5NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket5NUD.Name = "seatTicket5NUD";
            this.seatTicket5NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket5NUD.TabIndex = 7;
            this.seatTicket5NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket5NUD
            // 
            this.rowTicket5NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket5NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket5NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket5NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket5NUD.Name = "rowTicket5NUD";
            this.rowTicket5NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket5NUD.TabIndex = 6;
            this.rowTicket5NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket5Label
            // 
            this.seatTicket5Label.AutoSize = true;
            this.seatTicket5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket5Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket5Label.Name = "seatTicket5Label";
            this.seatTicket5Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket5Label.TabIndex = 5;
            this.seatTicket5Label.Text = "Место";
            // 
            // rowTicket5Label
            // 
            this.rowTicket5Label.AutoSize = true;
            this.rowTicket5Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket5Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket5Label.Name = "rowTicket5Label";
            this.rowTicket5Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket5Label.TabIndex = 4;
            this.rowTicket5Label.Text = "Ряд";
            // 
            // ticket4
            // 
            this.ticket4.Controls.Add(this.seatTicket4NUD);
            this.ticket4.Controls.Add(this.rowTicket4NUD);
            this.ticket4.Controls.Add(this.seatTicket4Label);
            this.ticket4.Controls.Add(this.rowTicket4Label);
            this.ticket4.Location = new System.Drawing.Point(13, 244);
            this.ticket4.Name = "ticket4";
            this.ticket4.Size = new System.Drawing.Size(213, 92);
            this.ticket4.TabIndex = 19;
            this.ticket4.TabStop = false;
            this.ticket4.Text = "Билет №4";
            // 
            // seatTicket4NUD
            // 
            this.seatTicket4NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket4NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket4NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket4NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket4NUD.Name = "seatTicket4NUD";
            this.seatTicket4NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket4NUD.TabIndex = 7;
            this.seatTicket4NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket4NUD
            // 
            this.rowTicket4NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket4NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket4NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket4NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket4NUD.Name = "rowTicket4NUD";
            this.rowTicket4NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket4NUD.TabIndex = 6;
            this.rowTicket4NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket4Label
            // 
            this.seatTicket4Label.AutoSize = true;
            this.seatTicket4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket4Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket4Label.Name = "seatTicket4Label";
            this.seatTicket4Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket4Label.TabIndex = 5;
            this.seatTicket4Label.Text = "Место";
            // 
            // rowTicket4Label
            // 
            this.rowTicket4Label.AutoSize = true;
            this.rowTicket4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket4Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket4Label.Name = "rowTicket4Label";
            this.rowTicket4Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket4Label.TabIndex = 4;
            this.rowTicket4Label.Text = "Ряд";
            // 
            // ticket3
            // 
            this.ticket3.Controls.Add(this.seatTicket3NUD);
            this.ticket3.Controls.Add(this.rowTicket3NUD);
            this.ticket3.Controls.Add(this.seatTicket3Label);
            this.ticket3.Controls.Add(this.rowTicket3Label);
            this.ticket3.Location = new System.Drawing.Point(451, 146);
            this.ticket3.Name = "ticket3";
            this.ticket3.Size = new System.Drawing.Size(213, 92);
            this.ticket3.TabIndex = 18;
            this.ticket3.TabStop = false;
            this.ticket3.Text = "Билет №3";
            // 
            // seatTicket3NUD
            // 
            this.seatTicket3NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket3NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket3NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket3NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket3NUD.Name = "seatTicket3NUD";
            this.seatTicket3NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket3NUD.TabIndex = 7;
            this.seatTicket3NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket3NUD
            // 
            this.rowTicket3NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket3NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket3NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket3NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket3NUD.Name = "rowTicket3NUD";
            this.rowTicket3NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket3NUD.TabIndex = 6;
            this.rowTicket3NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket3Label
            // 
            this.seatTicket3Label.AutoSize = true;
            this.seatTicket3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket3Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket3Label.Name = "seatTicket3Label";
            this.seatTicket3Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket3Label.TabIndex = 5;
            this.seatTicket3Label.Text = "Место";
            // 
            // rowTicket3Label
            // 
            this.rowTicket3Label.AutoSize = true;
            this.rowTicket3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket3Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket3Label.Name = "rowTicket3Label";
            this.rowTicket3Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket3Label.TabIndex = 4;
            this.rowTicket3Label.Text = "Ряд";
            // 
            // ticket2
            // 
            this.ticket2.Controls.Add(this.seatTicket2NUD);
            this.ticket2.Controls.Add(this.rowTicket2NUD);
            this.ticket2.Controls.Add(this.seatTicket2Label);
            this.ticket2.Controls.Add(this.rowTicket2Label);
            this.ticket2.Location = new System.Drawing.Point(232, 146);
            this.ticket2.Name = "ticket2";
            this.ticket2.Size = new System.Drawing.Size(213, 92);
            this.ticket2.TabIndex = 18;
            this.ticket2.TabStop = false;
            this.ticket2.Text = "Билет №2";
            // 
            // seatTicket2NUD
            // 
            this.seatTicket2NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket2NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket2NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket2NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket2NUD.Name = "seatTicket2NUD";
            this.seatTicket2NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket2NUD.TabIndex = 7;
            this.seatTicket2NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket2NUD
            // 
            this.rowTicket2NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket2NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket2NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket2NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket2NUD.Name = "rowTicket2NUD";
            this.rowTicket2NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket2NUD.TabIndex = 6;
            this.rowTicket2NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket2Label
            // 
            this.seatTicket2Label.AutoSize = true;
            this.seatTicket2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket2Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket2Label.Name = "seatTicket2Label";
            this.seatTicket2Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket2Label.TabIndex = 5;
            this.seatTicket2Label.Text = "Место";
            // 
            // rowTicket2Label
            // 
            this.rowTicket2Label.AutoSize = true;
            this.rowTicket2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket2Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket2Label.Name = "rowTicket2Label";
            this.rowTicket2Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket2Label.TabIndex = 4;
            this.rowTicket2Label.Text = "Ряд";
            // 
            // ticket1
            // 
            this.ticket1.Controls.Add(this.seatTicket1NUD);
            this.ticket1.Controls.Add(this.rowTicket1NUD);
            this.ticket1.Controls.Add(this.seatTicket1Label);
            this.ticket1.Controls.Add(this.rowTicket1Label);
            this.ticket1.Location = new System.Drawing.Point(13, 146);
            this.ticket1.Name = "ticket1";
            this.ticket1.Size = new System.Drawing.Size(213, 92);
            this.ticket1.TabIndex = 17;
            this.ticket1.TabStop = false;
            this.ticket1.Text = "Билет №1";
            // 
            // seatTicket1NUD
            // 
            this.seatTicket1NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket1NUD.Location = new System.Drawing.Point(73, 49);
            this.seatTicket1NUD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.seatTicket1NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.seatTicket1NUD.Name = "seatTicket1NUD";
            this.seatTicket1NUD.Size = new System.Drawing.Size(134, 26);
            this.seatTicket1NUD.TabIndex = 3;
            this.seatTicket1NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rowTicket1NUD
            // 
            this.rowTicket1NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket1NUD.Location = new System.Drawing.Point(73, 18);
            this.rowTicket1NUD.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.rowTicket1NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowTicket1NUD.Name = "rowTicket1NUD";
            this.rowTicket1NUD.Size = new System.Drawing.Size(134, 26);
            this.rowTicket1NUD.TabIndex = 2;
            this.rowTicket1NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // seatTicket1Label
            // 
            this.seatTicket1Label.AutoSize = true;
            this.seatTicket1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seatTicket1Label.Location = new System.Drawing.Point(6, 51);
            this.seatTicket1Label.Name = "seatTicket1Label";
            this.seatTicket1Label.Size = new System.Drawing.Size(57, 20);
            this.seatTicket1Label.TabIndex = 1;
            this.seatTicket1Label.Text = "Место";
            // 
            // rowTicket1Label
            // 
            this.rowTicket1Label.AutoSize = true;
            this.rowTicket1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowTicket1Label.Location = new System.Drawing.Point(7, 20);
            this.rowTicket1Label.Name = "rowTicket1Label";
            this.rowTicket1Label.Size = new System.Drawing.Size(39, 20);
            this.rowTicket1Label.TabIndex = 0;
            this.rowTicket1Label.Text = "Ряд";
            // 
            // perfomanceDateLabel
            // 
            this.perfomanceDateLabel.AutoSize = true;
            this.perfomanceDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateLabel.Location = new System.Drawing.Point(13, 52);
            this.perfomanceDateLabel.Name = "perfomanceDateLabel";
            this.perfomanceDateLabel.Size = new System.Drawing.Size(131, 20);
            this.perfomanceDateLabel.TabIndex = 15;
            this.perfomanceDateLabel.Text = "Дата спектакля";
            // 
            // perfomanceDateTimePicker
            // 
            this.perfomanceDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.perfomanceDateTimePicker.Location = new System.Drawing.Point(145, 47);
            this.perfomanceDateTimePicker.Name = "perfomanceDateTimePicker";
            this.perfomanceDateTimePicker.Size = new System.Drawing.Size(517, 26);
            this.perfomanceDateTimePicker.TabIndex = 14;
            this.perfomanceDateTimePicker.ValueChanged += new System.EventHandler(this.perfomanceDateTimePicker_ValueChanged);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(330, 342);
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
            this.cancelButton.Location = new System.Drawing.Point(184, 342);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 57);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(13, 114);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(100, 20);
            this.countLabel.TabIndex = 6;
            this.countLabel.Text = "Количество";
            // 
            // countNumericUpDown
            // 
            this.countNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNumericUpDown.Location = new System.Drawing.Point(120, 112);
            this.countNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.countNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.Name = "countNumericUpDown";
            this.countNumericUpDown.Size = new System.Drawing.Size(84, 26);
            this.countNumericUpDown.TabIndex = 5;
            this.countNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumericUpDown.ValueChanged += new System.EventHandler(this.countNumericUpDown_ValueChanged);
            // 
            // perfomanceCombobox
            // 
            this.perfomanceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.perfomanceCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceCombobox.FormattingEnabled = true;
            this.perfomanceCombobox.Location = new System.Drawing.Point(120, 78);
            this.perfomanceCombobox.Name = "perfomanceCombobox";
            this.perfomanceCombobox.Size = new System.Drawing.Size(542, 28);
            this.perfomanceCombobox.TabIndex = 2;
            // 
            // perfomanceLabel
            // 
            this.perfomanceLabel.AutoSize = true;
            this.perfomanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceLabel.Location = new System.Drawing.Point(13, 81);
            this.perfomanceLabel.Name = "perfomanceLabel";
            this.perfomanceLabel.Size = new System.Drawing.Size(91, 20);
            this.perfomanceLabel.TabIndex = 1;
            this.perfomanceLabel.Text = "Спектакль";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(299, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(58, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "action";
            // 
            // ordersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(700, 434);
            this.Controls.Add(this.ordersPanel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ordersDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ordersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.ordersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            this.ticket6.ResumeLayout(false);
            this.ticket6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket6NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket6NUD)).EndInit();
            this.ticket5.ResumeLayout(false);
            this.ticket5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket5NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket5NUD)).EndInit();
            this.ticket4.ResumeLayout(false);
            this.ticket4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket4NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket4NUD)).EndInit();
            this.ticket3.ResumeLayout(false);
            this.ticket3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket3NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket3NUD)).EndInit();
            this.ticket2.ResumeLayout(false);
            this.ticket2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket2NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket2NUD)).EndInit();
            this.ticket1.ResumeLayout(false);
            this.ticket1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatTicket1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowTicket1NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.NumericUpDown countNumericUpDown;
        private System.Windows.Forms.ComboBox perfomanceCombobox;
        private System.Windows.Forms.Label perfomanceLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label perfomanceDateLabel;
        private System.Windows.Forms.DateTimePicker perfomanceDateTimePicker;
        private System.Windows.Forms.GroupBox ticket6;
        private System.Windows.Forms.GroupBox ticket5;
        private System.Windows.Forms.GroupBox ticket4;
        private System.Windows.Forms.GroupBox ticket3;
        private System.Windows.Forms.GroupBox ticket2;
        private System.Windows.Forms.GroupBox ticket1;
        private System.Windows.Forms.NumericUpDown seatTicket6NUD;
        private System.Windows.Forms.NumericUpDown rowTicket6NUD;
        private System.Windows.Forms.Label seatTicket6Label;
        private System.Windows.Forms.Label rowTicket6Label;
        private System.Windows.Forms.NumericUpDown seatTicket5NUD;
        private System.Windows.Forms.NumericUpDown rowTicket5NUD;
        private System.Windows.Forms.Label seatTicket5Label;
        private System.Windows.Forms.Label rowTicket5Label;
        private System.Windows.Forms.NumericUpDown seatTicket4NUD;
        private System.Windows.Forms.NumericUpDown rowTicket4NUD;
        private System.Windows.Forms.Label seatTicket4Label;
        private System.Windows.Forms.Label rowTicket4Label;
        private System.Windows.Forms.NumericUpDown seatTicket3NUD;
        private System.Windows.Forms.NumericUpDown rowTicket3NUD;
        private System.Windows.Forms.Label seatTicket3Label;
        private System.Windows.Forms.Label rowTicket3Label;
        private System.Windows.Forms.NumericUpDown seatTicket2NUD;
        private System.Windows.Forms.NumericUpDown rowTicket2NUD;
        private System.Windows.Forms.Label seatTicket2Label;
        private System.Windows.Forms.Label rowTicket2Label;
        private System.Windows.Forms.NumericUpDown seatTicket1NUD;
        private System.Windows.Forms.NumericUpDown rowTicket1NUD;
        private System.Windows.Forms.Label seatTicket1Label;
        private System.Windows.Forms.Label rowTicket1Label;
    }
}