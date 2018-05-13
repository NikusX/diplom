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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boxOfficeDBDataSet = new boxOffice.boxOfficeDBDataSet();
            this.репертуарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.репертуарTableAdapter = new boxOffice.boxOfficeDBDataSetTableAdapters.РепертуарTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.репертуарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.репертуарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // boxOfficeDBDataSet
            // 
            this.boxOfficeDBDataSet.DataSetName = "boxOfficeDBDataSet";
            this.boxOfficeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // репертуарBindingSource
            // 
            this.репертуарBindingSource.DataMember = "Репертуар";
            this.репертуарBindingSource.DataSource = this.boxOfficeDBDataSet;
            // 
            // репертуарTableAdapter
            // 
            this.репертуарTableAdapter.ClearBeforeFill = true;
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
            // repertoireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 548);
            this.Controls.Add(this.dataGridView1);
            this.Name = "repertoireForm";
            this.Text = "Репертуар";
            this.Load += new System.EventHandler(this.repertoireForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOfficeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.репертуарBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}