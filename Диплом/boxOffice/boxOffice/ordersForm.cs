using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxOffice
{
    public partial class ordersForm : Form
    {
        public ordersForm()
        {
            InitializeComponent();
        }

        public void base_load()
        {
            DataSet ds = new DataSet();
            OleDbConnection con = staticVariables.con;
            OleDbCommand com = new OleDbCommand("select * from Заказы", con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            ordersDataGridView.DataSource = dt;
            con.Close();
        }

        public void clearFields()
        {
            theatreCombobox.SelectedIndex = 0;
            //perfomanceCombobox.SelectedIndex = 0;
            perfomanceNameLabel.Text = "name";
            countNumericUpDown.Value = 0;
        }

        int orderID;

        private void ordersForm_Load(object sender, EventArgs e)
        {
            base_load();
            ordersPanel.Hide();
            OleDbConnection con = staticVariables.con;
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select Название from Театр", con);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    theatreCombobox.Items.Add(reader.GetString(0));
                }
                reader.Close();
                con.Close();
                theatreCombobox.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Не удалось получить список театров.");
                con.Close();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить из списка выбранный заказ?", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OleDbConnection con = staticVariables.con;
            orderID = Convert.ToInt32(ordersDataGridView[0, ordersDataGridView.CurrentRow.Index].Value);
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from Заказы where [id заказа]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = orderID;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            
            ordersPanel.Show();
        }

        string perfomance_name;

        public void getPerfomanceName(int perfomance_id)
        {
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [Название спектакля] from Репертуар where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.VarChar).Value = perfomance_id;
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomance_name = reader.GetString(0);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось связаться с базой данных.\nОшибка: " + ex.Message);
            }
        }

        bool isPerformed = false;

        public void getScheduleList()
        {
            perfomanceCombobox.Items.Clear();
            submitButton.Enabled = true;
            DateTime date = perfomanceDateTimePicker.Value.Date;
            int theatreID = theatreCombobox.SelectedIndex + 1;
            OleDbConnection con = staticVariables.con;
            int perfomanceID = 0;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id спектакля], [Время начала спектакля] from Расписание where [id театра]=@id and [Дата спектакля]=@date", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = theatreID;
                cmd.Parameters.Add("@date", OleDbType.DBDate).Value = date;
                if(!isPerformed)
                    con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    perfomanceID = reader.GetInt32(0);
                }
                reader.Close();
                if(!isPerformed)
                    con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить расписание спектаклей.\nОшибка: " + ex.Message);
                con.Close();
            }
            getPerfomanceName(perfomanceID);
            perfomanceNameLabel.Text = perfomance_name;
        }
    

        private void theatreCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            getScheduleList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ordersPanel.Hide();
            clearFields();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isPerformed = true;
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Заказы where [id заказа]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = Convert.ToInt32(ordersDataGridView[0, ordersDataGridView.CurrentRow.Index].Value);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    getPerfomanceName(reader.GetInt32(1));
                    theatreCombobox.SelectedIndex = reader.GetInt32(2) - 1;
                    perfomanceCombobox.Text = perfomance_name;
                    countNumericUpDown.Value = reader.GetInt32(3);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось получить список заказов.\nОшибка: " + ex.Message);
                con.Close();
            }
            ordersPanel.Show();
            isPerformed = false;
        }

        int perfomanceID;

        public void getPerfomanceID()
        {
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id спектакля] from Репертуар where [Название спектакля]=@perfomancename", con);
                cmd.Parameters.Add("perfomancename", OleDbType.VarChar).Value = perfomanceCombobox.Text;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    perfomanceID = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось получить список спектаклей.\nОшибка: " + ex.Message);
                con.Close();
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            if(submitButton.Text == "Добавить")
            {
                getPerfomanceID();
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Заказы ([id спектакля], [id театра], [Количество билетов]) values (@perfomanceid, @theatreid, @count)", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomanceID;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreCombobox.SelectedIndex + 1;
                    cmd.Parameters.Add("@count", OleDbType.Integer).Value = countNumericUpDown.Value;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                    con.Close();
                    base_load();
                    ordersPanel.Hide();
                    clearFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
            }
            if(submitButton.Text == "Изменить")
            {
                getPerfomanceID();
                try
                {
                    OleDbCommand cmd = new OleDbCommand("update Заказы set [id спектакля]=@perfomanceid, [id театра]=@theatreid, [Количество билетов]=@count", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomanceID;
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreCombobox.SelectedIndex + 1;
                    cmd.Parameters.Add("@count", OleDbType.Integer).Value = countNumericUpDown.Value;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данный успешно изменены.");
                    con.Close();
                    base_load();
                    ordersPanel.Hide();
                    clearFields();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось изменить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
            }
        }

        private void perfomanceDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            getScheduleList();
        }
    }
}
