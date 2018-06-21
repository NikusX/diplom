using System;
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
    public partial class scheduleForm : Form
    {
        public scheduleForm()
        {
            InitializeComponent();
        }

        int theatreId;

        public void base_load()
        {
            DataSet ds = new DataSet();
            OleDbConnection con = staticVariables.con;
            OleDbCommand com = new OleDbCommand("select * from Расписание", con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            scheduleDataGridView.DataSource = dt;
            con.Close();
            scheduleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void clearFields()
        {
            perfomancesCombobox.SelectedIndex = 0;
            perfomanceDateTimePicker.Value = DateTime.Today;
            perfomanceStartsDateTimePicker.Value = DateTime.Now;
            perfomanceEndsDateTimePicker.Value = DateTime.Now;
        }

        private void scheduleForm_Load(object sender, EventArgs e)
        {
            base_load();
            schedulePanel.Hide();
            List<string> perfomances = new List<string>();
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [Название спектакля] from Репертуар", con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    perfomances.Add(reader.GetString(0));
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось получить список спектаклей.\nОшибка: " + ex.Message);
                con.Close();
            }
            for(int i = 0; i < perfomances.Count; i++)
            {
                perfomancesCombobox.Items.Add(perfomances[i]);
            }
            perfomancesCombobox.SelectedIndex = 0;
            for (int i = 0; i < scheduleDataGridView.Columns.Count; i++)
            {
                fieldsCombobox.Items.Add(scheduleDataGridView.Columns[i].HeaderText);
                filterCombobox.Items.Add(scheduleDataGridView.Columns[i].HeaderText);
            }
            fieldsCombobox.SelectedIndex = 0;
            filterCombobox.SelectedIndex = 0;
        }

        bool isPerformed = false;
        string perfomanceName;

        public void getPerfomanceName(int id)
        {
            OleDbConnection con = staticVariables.con;
            theatreId = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [Название спектакля] from Репертуар where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = id;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomanceName = reader.GetString(0);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить название спектакля.\nОшибка: " + ex.Message);
                con.Close();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isPerformed = true;
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            OleDbConnection con = staticVariables.con;
            int scheduleID = Convert.ToInt32(scheduleDataGridView[0, scheduleDataGridView.CurrentRow.Index].Value);
            int perfomance_id = Convert.ToInt32(scheduleDataGridView[2, scheduleDataGridView.CurrentRow.Index].Value);
            getPerfomanceName(perfomance_id);
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Расписание where id=:id", con);
                cmd.Parameters.Add("id", OleDbType.Integer).Value = scheduleID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomancesCombobox.Text = perfomanceName;
                    perfomanceDateTimePicker.Value = reader.GetDateTime(4);
                    perfomanceStartsDateTimePicker.Value = reader.GetDateTime(5);
                    perfomanceEndsDateTimePicker.Value = reader.GetDateTime(6);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить данные.\nОшибка: " + ex.Message);
                con.Close();
            }
            schedulePanel.Show();
            isPerformed = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            schedulePanel.Show();
        }

        public void getTheatreID()
        {
            OleDbConnection con = staticVariables.con;
            theatreId = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id театра], [Название спектакля] from Репертуар", con);
                if (!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetString(1) == perfomancesCombobox.Text)
                    {
                        theatreId = reader.GetInt32(0);
                    }
                }
                reader.Close();
                if (!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти выбранный театр.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
        }

        private void perfomancesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            getTheatreID();
            try
            {
                OleDbCommand cmd = new OleDbCommand("select Название from Театр where [id театра]=:theatreid", con);
                cmd.Parameters.Add("theatreid", OleDbType.Integer).Value = theatreId;
                if (!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    theatreTextbox.Text = reader.GetString(0);
                }
                reader.Close();
                if (!isPerformed)
                    con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось определить театр, в котором проходит выбранный спектакль.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            schedulePanel.Hide();
            clearFields();
        }

        int perfomanceID = 0;

        public void getPerfomanceID()
        {
            OleDbConnection con = staticVariables.con;
            perfomanceID = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id спектакля] from Репертуар where [Название спектакля]=@name", con);
                cmd.Parameters.Add("@name", OleDbType.VarChar).Value = perfomancesCombobox.Text;
                if (!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomanceID = reader.GetInt32(0);
                }
                reader.Close();
                if (!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить id выбранного спектакля.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            if(submitButton.Text == "Добавить")
            {
                if(theatreTextbox.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                try
                {
                    getPerfomanceID();
                    getTheatreID();
                    OleDbCommand cmd = new OleDbCommand("insert into Расписание ([Название спектакля], [id спектакля], [id театра], [Дата спектакля], [Время начала спектакля], [Время окончания спектакля], [Цена билета]) " +
                    "values (@perfomancename, @perfomanceid, @theatreid, @perfomancedate, @starttime, @endtime, @cena)", con);
                    cmd.Parameters.Add("@perfomancename", OleDbType.VarChar).Value = perfomancesCombobox.Text;
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomanceID;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@perfomancedate", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value.ToShortDateString();
                    cmd.Parameters.Add("@starttime", OleDbType.DBTimeStamp).Value = perfomanceDateTimePicker.Value.Date + perfomanceStartsDateTimePicker.Value.TimeOfDay;
                    cmd.Parameters.Add("@endtime", OleDbType.DBTimeStamp).Value = perfomanceDateTimePicker.Value.Date + perfomanceEndsDateTimePicker.Value.TimeOfDay;
                    cmd.Parameters.Add("@cena", OleDbType.Integer).Value = Convert.ToInt32(ticketCostTextbox.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                    con.Close();
                    schedulePanel.Hide();
                    clearFields();
                    base_load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
            }
            if(submitButton.Text == "Изменить")
            {
                int currentCellRow = scheduleDataGridView.CurrentCell.RowIndex;
                int currentCellColumn = scheduleDataGridView.CurrentCell.ColumnIndex;
                int scheduleID = Convert.ToInt32(scheduleDataGridView[0, scheduleDataGridView.CurrentRow.Index].Value);
                try
                {
                    getPerfomanceID();
                    getTheatreID();
                    OleDbCommand cmd = new OleDbCommand("update Расписание set [Название спектакля]=@perfomancename, [id спектакля]=@perfomanceid, [id театра]=@theatreid, [Дата спектакля]=@perfomacedate, [Время начала спектакля]=@perfomancestarts, [Время окончания спектакля]=perfomanceends where id=@id", con);
                    cmd.Parameters.Add("@perfomancename", OleDbType.VarChar).Value = perfomancesCombobox.Text;
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomanceID;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@perfomancedate", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value.ToShortDateString();
                    cmd.Parameters.Add("@perfomancestarts", OleDbType.VarChar).Value = perfomanceStartsDateTimePicker.Value.ToShortTimeString();
                    cmd.Parameters.Add("@perfomanceends", OleDbType.VarChar).Value = perfomanceEndsDateTimePicker.Value.ToShortTimeString();
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = scheduleID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно изменены.");
                    con.Close();
                    schedulePanel.Hide();
                    clearFields();
                    base_load();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось изменить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить из расписания выбранный спектакль?", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OleDbConnection con = staticVariables.con;
            int scheduleID = Convert.ToInt32(scheduleDataGridView[0, scheduleDataGridView.CurrentRow.Index].Value);
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from Расписание where [id]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = scheduleID;
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
                for (int i = 0; i < scheduleDataGridView.Rows.Count; i++)
                {
                    if (scheduleDataGridView[fieldsCombobox.SelectedIndex, i].Value.ToString() == findTextbox.Text)
                    {
                        scheduleDataGridView.CurrentCell = scheduleDataGridView[fieldsCombobox.SelectedIndex, i];
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось найти введенное значение.");
            }   
        }

        private void scheduleReportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[1, 1] = scheduleDataGridView.Columns[0].HeaderText;
            worksheet.Cells[1, 2] = scheduleDataGridView.Columns[1].HeaderText;
            worksheet.Cells[1, 3] = scheduleDataGridView.Columns[2].HeaderText;
            worksheet.Cells[1, 4] = scheduleDataGridView.Columns[3].HeaderText;
            worksheet.Cells[1, 5] = scheduleDataGridView.Columns[4].HeaderText;
            worksheet.Cells[1, 6] = scheduleDataGridView.Columns[5].HeaderText;
            for (int i = 0; i < scheduleDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = scheduleDataGridView[0, i].Value;
                worksheet.Cells[i + 2, 2] = scheduleDataGridView[1, i].Value;
                worksheet.Cells[i + 2, 3] = scheduleDataGridView[2, i].Value;
                worksheet.Cells[i + 2, 4] = scheduleDataGridView[3, i].Value;
                worksheet.Cells[i + 2, 5] = scheduleDataGridView[4, i].Value;
                worksheet.Cells[i + 2, 6] = scheduleDataGridView[5, i].Value;
            }
            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            (scheduleDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + filterCombobox.Text.ToString() + "]" + " = '{0}'", filterTextbox.Text);
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            (scheduleDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }
    }
}
