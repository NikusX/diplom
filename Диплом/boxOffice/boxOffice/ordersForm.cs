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
using Excel = Microsoft.Office.Interop.Excel;

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
        int value = 0;
        GroupBox[] tickets = new GroupBox[5];
        NumericUpDown[] rows = new NumericUpDown[6];
        NumericUpDown[] seats = new NumericUpDown[6];

        private void ordersForm_Load(object sender, EventArgs e)
        {
            ticketsDataGridView.Hide();
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
            backButton.Hide();
            printTicketButton.Hide();
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
                    OleDbCommand cmd = new OleDbCommand("insert into Заказы ([id спектакля], [id театра], [Количество билетов], [Дата спектакля], Стоимость) values (@perfomanceid, @theatreid, @count, @date, @stoim)", con);
                    cmd.Parameters.Add("@perfomanceid", OleDbType.Integer).Value = perfomaceIDs[perfomanceCombobox.SelectedIndex];
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatreIDs[perfomanceCombobox.SelectedIndex];
                    cmd.Parameters.Add("@count", OleDbType.Integer).Value = countNumericUpDown.Value;
                    cmd.Parameters.Add("@date", OleDbType.DBDate).Value = perfomanceDateTimePicker.Value.Date;
                    string[] cost = costNumLabel.Text.Split(' ');
                    int costInt = Convert.ToInt32(cost[0]);
                    cmd.Parameters.Add("@stoim", OleDbType.Integer).Value = costInt;
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
            if(perfomanceCombobox.Text == "В эту дату спектакли отсутствуют!")
            {
                costNumLabel.Text = "0 руб.";
                return;
            }
            costNumLabel.Text = (value * countNumericUpDown.Value).ToString() + " руб.";
        }

        private void ordersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int order_id = Convert.ToInt32(ordersDataGridView[0, ordersDataGridView.CurrentRow.Index].Value);
            DataSet ds = new DataSet();
            OleDbConnection con = staticVariables.con;
            con.Open();
            OleDbCommand cmd = new OleDbCommand("select * from Заказ where [id заказа]=@id", con);
            cmd.Parameters.Add("@id", OleDbType.Integer).Value = order_id;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = cmd;
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            ticketsDataGridView.DataSource = dt;
            con.Close();
            ticketsDataGridView.Show();
            backButton.Show();
            printTicketButton.Show();
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
                    costNumLabel.Text = "0 руб.";
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

        private void backButton_Click(object sender, EventArgs e)
        {
            ticketsDataGridView.Hide();
            backButton.Hide();
            printTicketButton.Hide();
        }

        private void perfomanceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (perfomanceCombobox.Text == "В эту дату спектакли отсутствуют!")
                return;
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select [Цена билета] from Расписание where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = perfomaceIDs[perfomanceCombobox.SelectedIndex];
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    value = reader.GetInt32(0);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("При выполение команды произошла ошибка.\nОшибка: " + ex);
                con.Close();
            }
            costNumLabel.Text = "0 руб.";
            costNumLabel.Text = (value * countNumericUpDown.Value).ToString() + " руб.";
        }

        string theatrename = "";
        string perfomancename = "";
        DateTime time;

        public void getNames(int theatreID, int perfomanceID)
        {
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select Название from Театр where [id театра]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = theatreID;
                OleDbCommand cmd1 = new OleDbCommand("select [Название спектакля] from Репертуар where [id спектакля]=@id", con);
                cmd1.Parameters.Add("@id", OleDbType.Integer).Value = perfomanceID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    theatrename = reader.GetString(0);
                }
                reader.Close();
                OleDbDataReader reader1 = cmd1.ExecuteReader();
                if(reader1.Read())
                {
                    perfomancename = reader1.GetString(0);
                }
                reader1.Close();
                OleDbCommand cmd2 = new OleDbCommand("select [Время начала спектакля] from Расписание where [Дата спектакля]=@date and [id спектакля]=@id", con);
                cmd2.Parameters.Add("@date", OleDbType.DBDate).Value = ordersDataGridView[4, ordersDataGridView.CurrentRow.Index].Value;
                cmd2.Parameters.Add("@id", OleDbType.Integer).Value = perfomanceID;
                OleDbDataReader reader2 = cmd2.ExecuteReader();
                if(reader2.Read())
                {
                    time = reader2.GetDateTime(0);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("При выполение команды произошла ошибка.\nОшибка: " + ex);
                con.Close();
            }
        }

        private void printTicketButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(@"C:\Users\Никита\Desktop\Учеба\diplom\Диплом\boxOffice\boxOffice\resources\ticket.xlsx");
            Excel.Worksheet worksheet = excelApp.ActiveSheet;
            worksheet.Cells[3, 2] = ticketsDataGridView[0, ticketsDataGridView.CurrentRow.Index].Value;
            worksheet.Cells[3, 9] = ticketsDataGridView[0, ticketsDataGridView.CurrentRow.Index].Value;
            getNames(Convert.ToInt32(ordersDataGridView[2, ordersDataGridView.CurrentRow.Index].Value), Convert.ToInt32(ordersDataGridView[1, ordersDataGridView.CurrentRow.Index].Value));
            worksheet.Cells[5, 2] = theatrename;
            worksheet.Cells[7, 2] = perfomancename;
            worksheet.Cells[3, 5] = ordersDataGridView[4, ordersDataGridView.CurrentRow.Index].Value;
            worksheet.Cells[3, 7] = time.ToShortTimeString();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void ordersReportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[1, 1] = ordersDataGridView.Columns[0].HeaderText;
            worksheet.Cells[1, 2] = ordersDataGridView.Columns[1].HeaderText;
            worksheet.Cells[1, 3] = ordersDataGridView.Columns[2].HeaderText;
            worksheet.Cells[1, 4] = ordersDataGridView.Columns[3].HeaderText;
            worksheet.Cells[1, 5] = ordersDataGridView.Columns[4].HeaderText;
            worksheet.Cells[1, 6] = ordersDataGridView.Columns[5].HeaderText;
            int i = 0;
            int summ = 0;
            for (i = 0; i < ordersDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = ordersDataGridView[0, i].Value;
                worksheet.Cells[i + 2, 2] = ordersDataGridView[1, i].Value;
                worksheet.Cells[i + 2, 3] = ordersDataGridView[2, i].Value;
                worksheet.Cells[i + 2, 4] = ordersDataGridView[3, i].Value;
                worksheet.Cells[i + 2, 5] = ordersDataGridView[4, i].Value;
                worksheet.Cells[i + 2, 6] = ordersDataGridView[5, i].Value;
                summ += Convert.ToInt32(ordersDataGridView[5, i].Value);
            }
            worksheet.Cells[i + 2, 5] = "Итого:";
            worksheet.Cells[i + 2, 6] = summ;
            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }
    }
}
