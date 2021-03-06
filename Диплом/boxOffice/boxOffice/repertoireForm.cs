﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace boxOffice
{
    public partial class repertoireForm : Form
    {
        public repertoireForm()
        {
            InitializeComponent();
        }

        public void base_load()
        {
            DataSet ds = new DataSet();
            OleDbConnection con = staticVariables.con;
            OleDbCommand com = new OleDbCommand("select * from Репертуар", con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(ds);
            System.Data.DataTable dt = ds.Tables[0];
            repertoireDataGridView.DataSource = dt;
            con.Close();
            repertoireDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void repertoireForm_Load(object sender, EventArgs e)
        {
            repertoirePanel.Hide();
            this.Height = 455;
            List<string> theatres = new List<string>();
            OleDbConnection con = staticVariables.con;
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select Название from Театр", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    theatres.Add(reader.GetString(0));
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
            for (int i = 0; i < theatres.Count; i++)
            {
                theatresCombobox.Items.Add(theatres[i]);
            }
            theatresCombobox.SelectedIndex = 0;
            string[] ageLimit = { "0+", "6+", "12+", "16+", "18+" };
            ageLimitCombobox.Items.AddRange(ageLimit);
            ageLimitCombobox.SelectedIndex = 0;
            base_load();
            for(int i = 0; i < repertoireDataGridView.Columns.Count; i++)
            {
                fieldsCombobox.Items.Add(repertoireDataGridView.Columns[i].HeaderText);
                filterCombobox.Items.Add(repertoireDataGridView.Columns[i].HeaderText);
            }
            fieldsCombobox.SelectedIndex = 0;
            filterCombobox.SelectedIndex = 0;
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.repertoireReportButton, "Отчет откроется в программе Excel");
        }

        int theatreId = 0;
        bool isPerformed = false;

        public void getTheatreID()
        {
            OleDbConnection con = staticVariables.con;
            theatreId = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id театра] from Театр where [Название]=@name", con);
                cmd.Parameters.Add("@name", OleDbType.VarChar).Value = theatresCombobox.Text;
                if (!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    theatreId = reader.GetInt32(0);
                }
                reader.Close();
                if (!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить id выбранного театра.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
        }

        string theatreName = "";
        public void getTheatreName(int id)
        {
            OleDbConnection con = staticVariables.con;
            theatreId = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [Название] from Театр where [id театра]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;
                if (!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    theatreName = reader.GetString(0);
                }
                reader.Close();
                if (!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить id выбранного театра.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
        }

        private void addPerfomanceButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            this.Height = 750;
            repertoirePanel.Show();
        }

        public void clearFields()
        {
            theatresCombobox.SelectedIndex = 0;
            perfomanceNameTextbox.Text = "";
            authorOfWorkTextbox.Text = "";
            genreOfWorkTextbox.Text = "";
            directorTextbox.Text = "";
            artDirectorTextbox.Text = "";
            ageLimitCombobox.SelectedIndex = 0;
            actorsTextbox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            repertoirePanel.Hide();
            this.Height = 455;
            clearFields();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            
            getTheatreID();
            if (submitButton.Text == "Добавить")
            {
                if(perfomanceNameTextbox.Text == "" || authorOfWorkTextbox.Text == "" ||
                     genreOfWorkTextbox.Text == "" || directorTextbox.Text == "" ||
                     artDirectorTextbox.Text == "" || actorsTextbox.Text == "" || descriptionTextbox.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Репертуар ([id театра], [Название спектакля], [Автор произведения], [Жанр произведения], [Режиссер-постановщик], [Художник-постановщик], [Возрастное ограничение], [Действующие лица и исполнители], Описание) " +
                        "values (@theatreid, @name, @author, @genre, @director, @artdirector, @agelimit, @actors, @description)", con);
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@name", OleDbType.VarChar).Value = perfomanceNameTextbox.Text;
                    cmd.Parameters.Add("@author", OleDbType.VarChar).Value = authorOfWorkTextbox.Text;
                    cmd.Parameters.Add("@genre", OleDbType.VarChar).Value = genreOfWorkTextbox.Text;
                    cmd.Parameters.Add("@director", OleDbType.VarChar).Value = directorTextbox.Text;
                    cmd.Parameters.Add("@artdirector", OleDbType.VarChar).Value = artDirectorTextbox.Text;
                    cmd.Parameters.Add("@agelimit", OleDbType.VarChar).Value = ageLimitCombobox.Text;
                    cmd.Parameters.Add("@actors", OleDbType.VarChar).Value = actorsTextbox.Text;
                    cmd.Parameters.Add("@description", OleDbType.VarChar).Value = descriptionTextbox.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                    repertoirePanel.Hide();
                    this.Height = 455;
                    clearFields();
                    con.Close();
                    base_load();
                }
                catch
                {
                    MessageBox.Show("Не удалось связаться с базой данных.");
                    con.Close();
                }
            }
            int currentCellColumn = 0;
            int currentCellRow = 0;
            int perfomanceID = 0;
            if(submitButton.Text == "Изменить")
            {
                currentCellColumn = repertoireDataGridView.CurrentCell.ColumnIndex;
                currentCellRow = repertoireDataGridView.CurrentCell.RowIndex;
                perfomanceID = Convert.ToInt32(repertoireDataGridView[0, repertoireDataGridView.CurrentRow.Index].Value);
                try
                {
                    OleDbCommand cmd = new OleDbCommand("update Репертуар set [id театра]=@theatreid, [Название спектакля]=@perfomancename, [Автор произведения]=@author, " +
                    "[Жанр произведения]=@genre, [Режиссер-постановщик]=@director, [Художник-постановщик]=@artdirector, [Возрастное ограничение]=@agelimit, " +
                    "[Действующие лица и исполнители]=@actors, Описание=@description where [id спектакля]=@perfomanceid", con);
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@perfomancename", OleDbType.VarChar).Value = perfomanceNameTextbox.Text;
                    cmd.Parameters.Add("@author", OleDbType.VarChar).Value = authorOfWorkTextbox.Text;
                    cmd.Parameters.Add("@genre", OleDbType.VarChar).Value = genreOfWorkTextbox.Text;
                    cmd.Parameters.Add("@director", OleDbType.VarChar).Value = directorTextbox.Text;
                    cmd.Parameters.Add("@artdirector", OleDbType.VarChar).Value = artDirectorTextbox.Text;
                    cmd.Parameters.Add("@agelimit", OleDbType.VarChar).Value = ageLimitCombobox.Text;
                    cmd.Parameters.Add("@actors", OleDbType.VarChar).Value = actorsTextbox.Text;
                    cmd.Parameters.Add("@description", OleDbType.VarChar).Value = descriptionTextbox.Text;
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomanceID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно обновлены.");
                    repertoirePanel.Hide();
                    this.Height = 455;
                    clearFields();
                    con.Close();
                    base_load();
                }
                catch
                {
                    MessageBox.Show("Не удалось связаться с базой данных.");
                    con.Close();
                }
            }
            repertoireDataGridView.CurrentCell = repertoireDataGridView[currentCellColumn, currentCellRow];
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            int perfomanceID = Convert.ToInt32(repertoireDataGridView[0, repertoireDataGridView.CurrentRow.Index].Value);
            int theatreID = Convert.ToInt32(repertoireDataGridView[1, repertoireDataGridView.CurrentRow.Index].Value);
            getTheatreName(theatreID);
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Репертуар where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = perfomanceID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    theatresCombobox.Text = theatreName;
                    perfomanceNameTextbox.Text = reader.GetString(2);
                    authorOfWorkTextbox.Text = reader.GetString(3);
                    genreOfWorkTextbox.Text = reader.GetString(4);
                    directorTextbox.Text = reader.GetString(5);
                    artDirectorTextbox.Text = reader.GetString(6);
                    ageLimitCombobox.Text = reader.GetString(7);
                    actorsTextbox.Text = reader.GetString(8);
                    descriptionTextbox.Text = reader.GetString(9);
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
            this.Height = 750;
            repertoirePanel.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить из списка выбранный спектакль?", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OleDbConnection con = staticVariables.con;
            int perfomanceID = Convert.ToInt32(repertoireDataGridView[0, repertoireDataGridView.CurrentRow.Index].Value);
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from Репертуар where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = perfomanceID;
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно удалены.");
                con.Close();
                base_load();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < repertoireDataGridView.Rows.Count; i++)
                {
                    if (repertoireDataGridView[fieldsCombobox.SelectedIndex, i].Value.ToString() == findTextbox.Text)
                    {
                        repertoireDataGridView.CurrentCell = repertoireDataGridView[fieldsCombobox.SelectedIndex, i];
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось найти введенное значение.");
            }
        }

        private void repertoireReportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[1, 1] = repertoireDataGridView.Columns[0].HeaderText;
            worksheet.Cells[1, 2] = repertoireDataGridView.Columns[1].HeaderText;
            worksheet.Cells[1, 3] = repertoireDataGridView.Columns[2].HeaderText;
            worksheet.Cells[1, 4] = repertoireDataGridView.Columns[3].HeaderText;
            worksheet.Cells[1, 5] = repertoireDataGridView.Columns[4].HeaderText;
            worksheet.Cells[1, 6] = repertoireDataGridView.Columns[5].HeaderText;
            worksheet.Cells[1, 7] = repertoireDataGridView.Columns[6].HeaderText;
            worksheet.Cells[1, 8] = repertoireDataGridView.Columns[7].HeaderText;
            worksheet.Cells[1, 9] = repertoireDataGridView.Columns[8].HeaderText;
            worksheet.Cells[1, 10] = repertoireDataGridView.Columns[9].HeaderText;
            for (int i = 0; i < repertoireDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = repertoireDataGridView[0, i] .Value;
                worksheet.Cells[i + 2, 2] = repertoireDataGridView[1, i].Value;
                worksheet.Cells[i + 2, 3] = repertoireDataGridView[2, i].Value;
                worksheet.Cells[i + 2, 4] = repertoireDataGridView[3, i].Value;
                worksheet.Cells[i + 2, 5] = repertoireDataGridView[4, i].Value;
                worksheet.Cells[i + 2, 6] = repertoireDataGridView[5, i].Value;
                worksheet.Cells[i + 2, 7] = repertoireDataGridView[6, i].Value;
                worksheet.Cells[i + 2, 8] = repertoireDataGridView[7, i].Value;
                worksheet.Cells[i + 2, 9] = repertoireDataGridView[8, i].Value;
                worksheet.Cells[i + 2, 10] = repertoireDataGridView[9, i].Value;
            }
            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            (repertoireDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + filterCombobox.Text.ToString() + "]" + " = '{0}'", filterTextbox.Text);
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            (repertoireDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }
    }
}
