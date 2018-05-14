namespace boxOffice
{
    partial class repertoireForm
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
            this.components = new System.ComponentModel.Container();
            this.repertoireDataGridView = new System.Windows.Forms.DataGridView();
            this.idСпектакляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idТеатраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеСпектакляDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.авторПроизведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрПроизведенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.режиссерпостановщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.художникпостановщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возрастноеОграничениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.репертуарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boxOfficeDBDataSet = new boxOffice.boxOfficeDBDataSet();
            this.репертуарTableAdapter = new boxOffice.boxOfficeDBDataSetTableAdapters.РепертуарTableAdapter();
            this.addPerfomanceButton = new System.Windows.Forms.Button();
            this.repertoirePanel = new System.Windows.Forms.Panel();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.actorsTextbox = new System.Windows.Forms.TextBox();
            this.actorsLabel = new System.Windows.Forms.Label();
            this.ageLimitCombobox = new System.Windows.Forms.ComboBox();
            this.ageLimitLabel = new System.Windows.Forms.Label();
            this.artDirectorLabel = new System.Windows.Forms.Label();
            this.artDirectorTextbox = new System.Windows.Forms.TextBox();
            this.directorLabel = new System.Windows.Forms.Label();
            this.directorTextbox = new System.Windows.Forms.TextBox();
            this.genreOfWorkLabel = new System.Windows.Forms.Label();
            this.genreOfWorkTextbox = new System.Windows.Forms.TextBox();
            this.authorOfWorkLabel = new System.Windows.Forms.Label();
            this.authorOfWorkTextbox = new System.Windows.Forms.TextBox();
            this.perfomanceNameLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.theatresCombobox = new System.Windows.Forms.ComboBox();
            this.perfomanceNameTextbox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.theatreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repertoireDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.репертуарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeDBDataSet)).BeginInit();
            this.repertoirePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // repertoireDataGridView
            // 
            this.repertoireDataGridView.AllowUserToAddRows = false;
            this.repertoireDataGridView.AllowUserToDeleteRows = false;
            this.repertoireDataGridView.AutoGenerateColumns = false;
            this.repertoireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.repertoireDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idСпектакляDataGridViewTextBoxColumn,
            this.idТеатраDataGridViewTextBoxColumn,
            this.названиеСпектакляDataGridViewTextBoxColumn,
            this.авторПроизведенияDataGridViewTextBoxColumn,
            this.жанрПроизведенияDataGridViewTextBoxColumn,
            this.режиссерпостановщикDataGridViewTextBoxColumn,
            this.художникпостановщикDataGridViewTextBoxColumn,
            this.возрастноеОграничениеDataGridViewTextBoxColumn,
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn,
            this.описаниеDataGridViewTextBoxColumn});
            this.repertoireDataGridView.DataSource = this.репертуарBindingSource;
            this.repertoireDataGridView.Location = new System.Drawing.Point(9, 10);
            this.repertoireDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.repertoireDataGridView.Name = "repertoireDataGridView";
            this.repertoireDataGridView.ReadOnly = true;
            this.repertoireDataGridView.RowTemplate.Height = 24;
            this.repertoireDataGridView.Size = new System.Drawing.Size(1052, 215);
            this.repertoireDataGridView.TabIndex = 0;
            // 
            // idСпектакляDataGridViewTextBoxColumn
            // 
            this.idСпектакляDataGridViewTextBoxColumn.DataPropertyName = "id спектакля";
            this.idСпектакляDataGridViewTextBoxColumn.HeaderText = "id спектакля";
            this.idСпектакляDataGridViewTextBoxColumn.Name = "idСпектакляDataGridViewTextBoxColumn";
            this.idСпектакляDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idТеатраDataGridViewTextBoxColumn
            // 
            this.idТеатраDataGridViewTextBoxColumn.DataPropertyName = "id театра";
            this.idТеатраDataGridViewTextBoxColumn.HeaderText = "id театра";
            this.idТеатраDataGridViewTextBoxColumn.Name = "idТеатраDataGridViewTextBoxColumn";
            this.idТеатраDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // названиеСпектакляDataGridViewTextBoxColumn
            // 
            this.названиеСпектакляDataGridViewTextBoxColumn.DataPropertyName = "Название спектакля";
            this.названиеСпектакляDataGridViewTextBoxColumn.HeaderText = "Название спектакля";
            this.названиеСпектакляDataGridViewTextBoxColumn.Name = "названиеСпектакляDataGridViewTextBoxColumn";
            this.названиеСпектакляDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // авторПроизведенияDataGridViewTextBoxColumn
            // 
            this.авторПроизведенияDataGridViewTextBoxColumn.DataPropertyName = "Автор произведения";
            this.авторПроизведенияDataGridViewTextBoxColumn.HeaderText = "Автор произведения";
            this.авторПроизведенияDataGridViewTextBoxColumn.Name = "авторПроизведенияDataGridViewTextBoxColumn";
            this.авторПроизведенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // жанрПроизведенияDataGridViewTextBoxColumn
            // 
            this.жанрПроизведенияDataGridViewTextBoxColumn.DataPropertyName = "Жанр произведения";
            this.жанрПроизведенияDataGridViewTextBoxColumn.HeaderText = "Жанр произведения";
            this.жанрПроизведенияDataGridViewTextBoxColumn.Name = "жанрПроизведенияDataGridViewTextBoxColumn";
            this.жанрПроизведенияDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // режиссерпостановщикDataGridViewTextBoxColumn
            // 
            this.режиссерпостановщикDataGridViewTextBoxColumn.DataPropertyName = "Режиссер-постановщик";
            this.режиссерпостановщикDataGridViewTextBoxColumn.HeaderText = "Режиссер-постановщик";
            this.режиссерпостановщикDataGridViewTextBoxColumn.Name = "режиссерпостановщикDataGridViewTextBoxColumn";
            this.режиссерпостановщикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // художникпостановщикDataGridViewTextBoxColumn
            // 
            this.художникпостановщикDataGridViewTextBoxColumn.DataPropertyName = "Художник-постановщик";
            this.художникпостановщикDataGridViewTextBoxColumn.HeaderText = "Художник-постановщик";
            this.художникпостановщикDataGridViewTextBoxColumn.Name = "художникпостановщикDataGridViewTextBoxColumn";
            this.художникпостановщикDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // возрастноеОграничениеDataGridViewTextBoxColumn
            // 
            this.возрастноеОграничениеDataGridViewTextBoxColumn.DataPropertyName = "Возрастное ограничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.HeaderText = "Возрастное ограничение";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.Name = "возрастноеОграничениеDataGridViewTextBoxColumn";
            this.возрастноеОграничениеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // действующиеЛицаИИсполнителиDataGridViewTextBoxColumn
            // 
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn.DataPropertyName = "Действующие лица и исполнители";
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn.HeaderText = "Действующие лица и исполнители";
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn.Name = "действующиеЛицаИИсполнителиDataGridViewTextBoxColumn";
            this.действующиеЛицаИИсполнителиDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // репертуарBindingSource
            // 
            this.репертуарBindingSource.DataMember = "Репертуар";
            this.репертуарBindingSource.DataSource = this.boxOfficeDBDataSet;
            // 
            // boxOfficeDBDataSet
            // 
            this.boxOfficeDBDataSet.DataSetName = "boxOfficeDBDataSet";
            this.boxOfficeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // репертуарTableAdapter
            // 
            this.репертуарTableAdapter.ClearBeforeFill = true;
            // 
            // addPerfomanceButton
            // 
            this.addPerfomanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.addPerfomanceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPerfomanceButton.Location = new System.Drawing.Point(9, 230);
            this.addPerfomanceButton.Name = "addPerfomanceButton";
            this.addPerfomanceButton.Size = new System.Drawing.Size(139, 57);
            this.addPerfomanceButton.TabIndex = 1;
            this.addPerfomanceButton.Text = "Добавить";
            this.addPerfomanceButton.UseVisualStyleBackColor = false;
            this.addPerfomanceButton.Click += new System.EventHandler(this.addPerfomanceButton_Click);
            // 
            // repertoirePanel
            // 
            this.repertoirePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repertoirePanel.Controls.Add(this.descriptionTextbox);
            this.repertoirePanel.Controls.Add(this.descriptionLabel);
            this.repertoirePanel.Controls.Add(this.actorsTextbox);
            this.repertoirePanel.Controls.Add(this.actorsLabel);
            this.repertoirePanel.Controls.Add(this.ageLimitCombobox);
            this.repertoirePanel.Controls.Add(this.ageLimitLabel);
            this.repertoirePanel.Controls.Add(this.artDirectorLabel);
            this.repertoirePanel.Controls.Add(this.artDirectorTextbox);
            this.repertoirePanel.Controls.Add(this.directorLabel);
            this.repertoirePanel.Controls.Add(this.directorTextbox);
            this.repertoirePanel.Controls.Add(this.genreOfWorkLabel);
            this.repertoirePanel.Controls.Add(this.genreOfWorkTextbox);
            this.repertoirePanel.Controls.Add(this.authorOfWorkLabel);
            this.repertoirePanel.Controls.Add(this.authorOfWorkTextbox);
            this.repertoirePanel.Controls.Add(this.perfomanceNameLabel);
            this.repertoirePanel.Controls.Add(this.submitButton);
            this.repertoirePanel.Controls.Add(this.cancelButton);
            this.repertoirePanel.Controls.Add(this.theatresCombobox);
            this.repertoirePanel.Controls.Add(this.perfomanceNameTextbox);
            this.repertoirePanel.Controls.Add(this.headerLabel);
            this.repertoirePanel.Controls.Add(this.theatreLabel);
            this.repertoirePanel.Location = new System.Drawing.Point(191, 10);
            this.repertoirePanel.Name = "repertoirePanel";
            this.repertoirePanel.Size = new System.Drawing.Size(720, 602);
            this.repertoirePanel.TabIndex = 2;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextbox.Location = new System.Drawing.Point(19, 422);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(681, 99);
            this.descriptionTextbox.TabIndex = 22;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.Location = new System.Drawing.Point(15, 399);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 20);
            this.descriptionLabel.TabIndex = 21;
            this.descriptionLabel.Text = "Описание";
            // 
            // actorsTextbox
            // 
            this.actorsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsTextbox.Location = new System.Drawing.Point(19, 295);
            this.actorsTextbox.Multiline = true;
            this.actorsTextbox.Name = "actorsTextbox";
            this.actorsTextbox.Size = new System.Drawing.Size(681, 99);
            this.actorsTextbox.TabIndex = 20;
            // 
            // actorsLabel
            // 
            this.actorsLabel.AutoSize = true;
            this.actorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actorsLabel.Location = new System.Drawing.Point(15, 272);
            this.actorsLabel.Name = "actorsLabel";
            this.actorsLabel.Size = new System.Drawing.Size(273, 20);
            this.actorsLabel.TabIndex = 19;
            this.actorsLabel.Text = "Действующие лица и исполнители";
            // 
            // ageLimitCombobox
            // 
            this.ageLimitCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLimitCombobox.FormattingEnabled = true;
            this.ageLimitCombobox.Location = new System.Drawing.Point(221, 235);
            this.ageLimitCombobox.Name = "ageLimitCombobox";
            this.ageLimitCombobox.Size = new System.Drawing.Size(479, 28);
            this.ageLimitCombobox.TabIndex = 17;
            // 
            // ageLimitLabel
            // 
            this.ageLimitLabel.AutoSize = true;
            this.ageLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageLimitLabel.Location = new System.Drawing.Point(15, 238);
            this.ageLimitLabel.Name = "ageLimitLabel";
            this.ageLimitLabel.Size = new System.Drawing.Size(200, 20);
            this.ageLimitLabel.TabIndex = 16;
            this.ageLimitLabel.Text = "Возрастное ограничение";
            // 
            // artDirectorLabel
            // 
            this.artDirectorLabel.AutoSize = true;
            this.artDirectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artDirectorLabel.Location = new System.Drawing.Point(15, 206);
            this.artDirectorLabel.Name = "artDirectorLabel";
            this.artDirectorLabel.Size = new System.Drawing.Size(190, 20);
            this.artDirectorLabel.TabIndex = 14;
            this.artDirectorLabel.Text = "Художник-постановщик";
            // 
            // artDirectorTextbox
            // 
            this.artDirectorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.artDirectorTextbox.Location = new System.Drawing.Point(209, 203);
            this.artDirectorTextbox.Name = "artDirectorTextbox";
            this.artDirectorTextbox.Size = new System.Drawing.Size(491, 26);
            this.artDirectorTextbox.TabIndex = 13;
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorLabel.Location = new System.Drawing.Point(15, 174);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(188, 20);
            this.directorLabel.TabIndex = 12;
            this.directorLabel.Text = "Режиссер-постановщик";
            // 
            // directorTextbox
            // 
            this.directorTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorTextbox.Location = new System.Drawing.Point(209, 171);
            this.directorTextbox.Name = "directorTextbox";
            this.directorTextbox.Size = new System.Drawing.Size(491, 26);
            this.directorTextbox.TabIndex = 11;
            // 
            // genreOfWorkLabel
            // 
            this.genreOfWorkLabel.AutoSize = true;
            this.genreOfWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreOfWorkLabel.Location = new System.Drawing.Point(15, 142);
            this.genreOfWorkLabel.Name = "genreOfWorkLabel";
            this.genreOfWorkLabel.Size = new System.Drawing.Size(162, 20);
            this.genreOfWorkLabel.TabIndex = 10;
            this.genreOfWorkLabel.Text = "Жанр произведения";
            // 
            // genreOfWorkTextbox
            // 
            this.genreOfWorkTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genreOfWorkTextbox.Location = new System.Drawing.Point(190, 139);
            this.genreOfWorkTextbox.Name = "genreOfWorkTextbox";
            this.genreOfWorkTextbox.Size = new System.Drawing.Size(510, 26);
            this.genreOfWorkTextbox.TabIndex = 9;
            // 
            // authorOfWorkLabel
            // 
            this.authorOfWorkLabel.AutoSize = true;
            this.authorOfWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorOfWorkLabel.Location = new System.Drawing.Point(15, 110);
            this.authorOfWorkLabel.Name = "authorOfWorkLabel";
            this.authorOfWorkLabel.Size = new System.Drawing.Size(169, 20);
            this.authorOfWorkLabel.TabIndex = 8;
            this.authorOfWorkLabel.Text = "Автор произведения";
            // 
            // authorOfWorkTextbox
            // 
            this.authorOfWorkTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorOfWorkTextbox.Location = new System.Drawing.Point(190, 107);
            this.authorOfWorkTextbox.Name = "authorOfWorkTextbox";
            this.authorOfWorkTextbox.Size = new System.Drawing.Size(510, 26);
            this.authorOfWorkTextbox.TabIndex = 7;
            // 
            // perfomanceNameLabel
            // 
            this.perfomanceNameLabel.AutoSize = true;
            this.perfomanceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceNameLabel.Location = new System.Drawing.Point(15, 78);
            this.perfomanceNameLabel.Name = "perfomanceNameLabel";
            this.perfomanceNameLabel.Size = new System.Drawing.Size(83, 20);
            this.perfomanceNameLabel.TabIndex = 6;
            this.perfomanceNameLabel.Text = "Название";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitButton.Location = new System.Drawing.Point(356, 533);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(139, 57);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Action";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(150)))));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(211, 533);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 57);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // theatresCombobox
            // 
            this.theatresCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatresCombobox.FormattingEnabled = true;
            this.theatresCombobox.Location = new System.Drawing.Point(75, 41);
            this.theatresCombobox.Name = "theatresCombobox";
            this.theatresCombobox.Size = new System.Drawing.Size(625, 28);
            this.theatresCombobox.TabIndex = 3;
            // 
            // perfomanceNameTextbox
            // 
            this.perfomanceNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perfomanceNameTextbox.Location = new System.Drawing.Point(104, 75);
            this.perfomanceNameTextbox.Name = "perfomanceNameTextbox";
            this.perfomanceNameTextbox.Size = new System.Drawing.Size(596, 26);
            this.perfomanceNameTextbox.TabIndex = 2;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.headerLabel.Location = new System.Drawing.Point(333, 12);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(60, 20);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "Action";
            // 
            // theatreLabel
            // 
            this.theatreLabel.AutoSize = true;
            this.theatreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.theatreLabel.Location = new System.Drawing.Point(15, 44);
            this.theatreLabel.Name = "theatreLabel";
            this.theatreLabel.Size = new System.Drawing.Size(54, 20);
            this.theatreLabel.TabIndex = 0;
            this.theatreLabel.Text = "Театр";
            // 
            // repertoireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(1070, 624);
            this.Controls.Add(this.repertoirePanel);
            this.Controls.Add(this.addPerfomanceButton);
            this.Controls.Add(this.repertoireDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "repertoireForm";
            this.Text = "Репертуар";
            this.Load += new System.EventHandler(this.repertoireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repertoireDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.репертуарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeDBDataSet)).EndInit();
            this.repertoirePanel.ResumeLayout(false);
            this.repertoirePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView repertoireDataGridView;
        private boxOfficeDBDataSet boxOfficeDBDataSet;
        private System.Windows.Forms.BindingSource репертуарBindingSource;
        private boxOfficeDBDataSetTableAdapters.РепертуарTableAdapter репертуарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idСпектакляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idТеатраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеСпектакляDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn авторПроизведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрПроизведенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn режиссерпостановщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn художникпостановщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn возрастноеОграничениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn действующиеЛицаИИсполнителиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addPerfomanceButton;
        private System.Windows.Forms.Panel repertoirePanel;
        private System.Windows.Forms.ComboBox theatresCombobox;
        private System.Windows.Forms.TextBox perfomanceNameTextbox;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label theatreLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.TextBox directorTextbox;
        private System.Windows.Forms.Label genreOfWorkLabel;
        private System.Windows.Forms.TextBox genreOfWorkTextbox;
        private System.Windows.Forms.Label authorOfWorkLabel;
        private System.Windows.Forms.TextBox authorOfWorkTextbox;
        private System.Windows.Forms.Label perfomanceNameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox ageLimitCombobox;
        private System.Windows.Forms.Label ageLimitLabel;
        private System.Windows.Forms.Label artDirectorLabel;
        private System.Windows.Forms.TextBox artDirectorTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox actorsTextbox;
        private System.Windows.Forms.Label actorsLabel;
    }
}