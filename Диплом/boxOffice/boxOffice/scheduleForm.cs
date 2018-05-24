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
        }

        bool isPerformed = false;

        private void editButton_Click(object sender, EventArgs e)
        {
            isPerformed = true;
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            OleDbConnection con = staticVariables.con;
            int scheduleID = Convert.ToInt32(scheduleDataGridView[0, scheduleDataGridView.CurrentRow.Index].Value);
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Расписание where id=:id", con);
                cmd.Parameters.Add("id", OleDbType.Integer).Value = scheduleID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomancesCombobox.SelectedIndex = reader.GetInt32(1) - 1;
                    perfomanceDateTimePicker.Value = reader.GetDateTime(3);
                    perfomanceStartsDateTimePicker.Value = reader.GetDateTime(4);
                    perfomanceEndsDateTimePicker.Value = reader.GetDateTime(5);
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

        private void perfomancesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            theatreId = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id театра], [Название спектакля] from Репертуар", con);
                if(!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if(reader.GetString(1) == perfomancesCombobox.Text)
                    {
                        theatreId = reader.GetInt32(0);
                    }
                }
                reader.Close();
                if(!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось найти выбранный театр.\nОшибка: " + ex.Message);
                if (!isPerformed)
                    con.Close();
            }
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
                    OleDbCommand cmd = new OleDbCommand("insert into Расписание ([id спектакля], [id театра], [Дата спектакля], [Время начала спектакля], [Время окончания спектакля]) " +
                    "values (@perfomanceid, @theatreid, @perfomancedate, @starttime, @endtime)", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomancesCombobox.SelectedIndex + 1;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@perfomancedate", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value;
                    cmd.Parameters.Add("@starttime", OleDbType.VarChar).Value = perfomanceStartsDateTimePicker.Value.ToShortTimeString();
                    cmd.Parameters.Add("@endtime", OleDbType.VarChar).Value = perfomanceEndsDateTimePicker.Value.ToShortTimeString();
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                    con.Close();
                    schedulePanel.Hide();
                    clearFields();
                    base_load();
                }
                catch(Exception ex)
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
                    OleDbCommand cmd = new OleDbCommand("update Расписание set [id спектакля]=@perfomanceid, [id театра]=@theatreid, [Дата спектакля]=@perfomacedate, [Время начала спектакля]=@perfomancestarts, [Время окончания спектакля]=perfomanceends where id=@id", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomancesCombobox.SelectedIndex + 1;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreId;
                    cmd.Parameters.Add("@perfomancedate", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value;
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
                catch(Exception ex)
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
    }
}
