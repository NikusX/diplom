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

        List<int> perfomaceIDs = new List<int>();
        List<int> theatreIDs = new List<int>();

        public void clearFields()
        {
            perfomanceDateTimePicker.Value = DateTime.Today.Date;
            perfomanceCombobox.SelectedIndex = 0;
            countNumericUpDown.Value = 1;
            perfomaceIDs.Clear();
            rowTicket1NUD.Value = 1;
            rowTicket2NUD.Value = 1;
            rowTicket3NUD.Value = 1;
            rowTicket4NUD.Value = 1;
            rowTicket5NUD.Value = 1;
            rowTicket6NUD.Value = 1;
            seatTicket1NUD.Value = 1;
            seatTicket2NUD.Value = 1;
            seatTicket3NUD.Value = 1;
            seatTicket4NUD.Value = 1;
            seatTicket5NUD.Value = 1;
            seatTicket6NUD.Value = 1;
        }

        int orderID;
        GroupBox[] tickets = new GroupBox[5];
        NumericUpDown[] rows = new NumericUpDown[6];
        NumericUpDown[] seats = new NumericUpDown[6];

        private void ordersForm_Load(object sender, EventArgs e)
        {
            base_load();
            ordersPanel.Hide();
            ticket2.Hide();
            ticket3.Hide();
            ticket4.Hide();
            ticket5.Hide();
            ticket6.Hide();
            tickets[0] = ticket2;
            tickets[1] = ticket3;
            tickets[2] = ticket4;
            tickets[3] = ticket5;
            tickets[4] = ticket6;
            rows[0] = rowTicket1NUD;
            rows[1] = rowTicket2NUD;
            rows[2] = rowTicket3NUD;
            rows[3] = rowTicket4NUD;
            rows[4] = rowTicket5NUD;
            rows[5] = rowTicket6NUD;
            seats[0] = seatTicket1NUD;
            seats[1] = seatTicket2NUD;
            seats[2] = seatTicket3NUD;
            seats[3] = seatTicket4NUD;
            seats[4] = seatTicket5NUD;
            seats[5] = seatTicket6NUD;
            perfomanceDateTimePicker.Value = DateTime.Today.Date;
            perfomanceDateTimePicker.MinDate = DateTime.Today.Date;
            perfomanceCombobox.SelectedIndex = 0;
        }

        int count = 0;

        public void countOfOrders()
        {
            OleDbConnection con = staticVariables.con;
            try
            {
                con.Open();
                OleDbCommand cmd1 = new OleDbCommand("select count(*) from Заказ", con);
                OleDbDataReader reader = cmd1.ExecuteReader();
                while (reader.Read())
                {
                    count = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось связаться с базой данных.\nОшибка: " + ex);
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
                countOfOrders();
                con.Open();
                cmd.ExecuteNonQuery();
                for (int i = 0; i < count; i++)
                {
                    OleDbCommand cmd2 = new OleDbCommand("delete from Заказ where [id заказа]=@id", con);
                    cmd2.Parameters.Add("@id", OleDbType.Integer).Value = orderID;
                    cmd2.ExecuteNonQuery();
                }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ordersPanel.Hide();
            clearFields();
        }

        bool Checked = true;

        public void ticketsCheck()
        {
            List<int> order_id = new List<int>();
            countOfOrders();
            OleDbConnection con = staticVariables.con;
            con.Open();
            try
            {
                OleDbCommand cmd1 = new OleDbCommand("select [id заказа] from Заказы where [id спектакля]=@id and [Дата спектакля]=@date", con);
                cmd1.Parameters.Add("@id", OleDbType.Integer).Value = perfomaceIDs[perfomanceCombobox.SelectedIndex];
                cmd1.Parameters.Add("@date", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value.Date;
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                while(reader1.Read())
                {
                    order_id.Add(reader1.GetInt32(0));
                }
                int row = 0;
                int seat = 0;
                for(int i = 0; i < countNumericUpDown.Value; i++)
                    for(int z = 0; z < order_id.Count(); z++)
                        for(int j = 0; j < count; j++)
                        {
                            OleDbCommand cmd = new OleDbCommand("select [Номер ряда], [Номер места] from Заказ where [id заказа]=@orderid", con);
                            cmd.Parameters.Add("@orderid", OleDbType.Integer).Value = order_id[z];
                            OleDbDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                row = reader.GetInt32(0);
                                seat = reader.GetInt32(1);
                            }
                            if (rows[i].Value == row && seats[i].Value == seat)
                            {
                                MessageBox.Show("Одно или несколько выбранных мест уже заняты.");
                                Checked = false;
                                con.Close();
                                return;
                            }
                        }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось проверить билеты.\nОшибка: " + ex.Message);
                con.Close();
                Checked = false;
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            if(submitButton.Text == "Добавить")
            {
                if(perfomanceCombobox.Text == "В эту дату спектакли отсутствуют!")
                {
                    MessageBox.Show("Заказ билетов невозможен!\nВ эту дату спектакли отсутствуют!");
                    return;
                }
                ticketsCheck();
                if (Checked == false)
                    return;
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Заказы ([id спектакля], [id театра], [Количество билетов], [Дата спектакля]) values (@perfomanceid, @theatreid, @count, @date)", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomaceIDs[perfomanceCombobox.SelectedIndex];
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreIDs[perfomanceCombobox.SelectedIndex];
                    cmd.Parameters.Add("@count", OleDbType.Integer).Value = countNumericUpDown.Value;
                    cmd.Parameters.Add("@date", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value.Date;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    int lastOrderID = 0;
                    OleDbCommand cmd1 = new OleDbCommand("select top 1 [id заказа] from Заказы order by [id заказа] desc", con);
                    OleDbDataReader reader = cmd1.ExecuteReader();
                    if(reader.Read())
                    {
                        lastOrderID = reader.GetInt32(0);
                    }
                    for(int i = 0; i < countNumericUpDown.Value; i++)
                    {
                        OleDbCommand cmd2 = new OleDbCommand("insert into Заказ ([id заказа], [Номер ряда], [Номер места]) values (@orderID, @rowNumber, @seatNumber)", con);
                        cmd2.Parameters.Add("@orderID", OleDbType.Integer).Value = lastOrderID;
                        cmd2.Parameters.Add("@rowNumber", OleDbType.Integer).Value = rows[i].Value;
                        cmd2.Parameters.Add("@seatNumber", OleDbType.Integer).Value = seats[i].Value;
                        cmd2.ExecuteNonQuery();
                    }
                    con.Close();
                    MessageBox.Show("Данные успешно добавлены.");
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
        }

        private void countNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach(GroupBox element in tickets)
            {
                element.Hide();
            }
            for(int i = 0; i < countNumericUpDown.Value - 1; i++)
            {
                tickets[i].Show();
            }
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // при двойном клике выводить информацию о заказе
        }
        
        public void getPerfomancesNames()
        {
            perfomanceCombobox.Items.Clear();
            OleDbConnection con = staticVariables.con;
            try
            {
                con.Open();
                for(int i = 0; i < perfomaceIDs.Count(); i++)
                {
                    OleDbCommand cmd = new OleDbCommand("select [Название спектакля] from Репертуар where [id спектакля]=@id", con);
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = perfomaceIDs[i];
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        perfomanceCombobox.Items.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
                con.Close();
                if(perfomanceCombobox.Items.Count == 0)
                {
                    perfomanceCombobox.Items.Add("В эту дату спектакли отсутствуют!");
                }
                perfomanceCombobox.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("При выполение команды произошла ошибка.\nОшибка: " + ex);
                con.Close();
            }
        }

        private void perfomanceDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            perfomaceIDs.Clear();
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [id спектакля], [id театра] from Расписание where [Дата спектакля]=@date", con);
                cmd.Parameters.Add("@date", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    perfomaceIDs.Add(reader.GetInt32(0));
                    theatreIDs.Add(reader.GetInt32(1));
                }
                reader.Close();
                con.Close();
                getPerfomancesNames();
            }
            catch(Exception ex)
            {
                MessageBox.Show("При выполение команды произошла ошибка.\nОшибка: " + ex);
                con.Close();
            }
        }
    }
}
