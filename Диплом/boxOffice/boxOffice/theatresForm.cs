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
    public partial class theatresForm : Form
    {
        public theatresForm()
        {
            InitializeComponent();
        }

        public void base_load()
        {
            DataSet ds = new DataSet();
            OleDbConnection con = staticVariables.con;
            OleDbCommand com = new OleDbCommand("select * from Театр", con);
            con.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = com;
            adapter.Fill(ds);
            DataTable dt = ds.Tables[0];
            theatresDataGridView.DataSource = dt;
            con.Close();
            theatresDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void clearFields()
        {
            theatreNameTextbox.Text = "";
            theatreAdressTextbox.Text = "";
        }

        int theatreID;

        private void theatresForm_Load(object sender, EventArgs e)
        {
            base_load();
            theatresPanel.Hide();
            for (int i = 0; i < theatresDataGridView.Columns.Count; i++)
            {
                fieldsCombobox.Items.Add(theatresDataGridView.Columns[i].HeaderText);
                filterCombobox.Items.Add(theatresDataGridView.Columns[i].HeaderText);
            }
            fieldsCombobox.SelectedIndex = 0;
            filterCombobox.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            theatresPanel.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            if (submitButton.Text == "Добавить")
            {
                if(theatreNameTextbox.Text == "" || theatreAdressTextbox.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Театр (Название, [Адрес театра]) values (@name, @adress)", con);
                    cmd.Parameters.Add("@name", OleDbType.VarChar).Value = theatreNameTextbox.Text;
                    cmd.Parameters.Add("@adress", OleDbType.VarChar).Value = theatreAdressTextbox.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно добавлены.");
                    con.Close();
                    theatresPanel.Hide();
                    base_load();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
                clearFields();
            }
            if (submitButton.Text == "Изменить")
            {
                theatreID = Convert.ToInt32(theatresDataGridView[0, theatresDataGridView.CurrentRow.Index].Value);
                int currentRow = theatresDataGridView.CurrentCell.RowIndex;
                int currentColumn = theatresDataGridView.CurrentCell.ColumnIndex;
                try
                {
                    OleDbCommand cmd = new OleDbCommand("update Театр set Название=@name, [Адрес театра]=@adress where [id театра]=@id", con);
                    cmd.Parameters.Add("@name", OleDbType.VarChar).Value = theatreNameTextbox.Text;
                    cmd.Parameters.Add("@adress", OleDbType.VarChar).Value = theatreAdressTextbox.Text;
                    cmd.Parameters.Add("@id", OleDbType.Integer).Value = theatreID;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Данные успешно изменены.");
                    con.Close();
                    base_load();
                    theatresPanel.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Не удалось изменить данные.\nОшибка: " + ex.Message);
                    con.Close();
                }
                clearFields();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить из списка выбранный театр?", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            OleDbConnection con = staticVariables.con;
            theatreID = Convert.ToInt32(theatresDataGridView[0, theatresDataGridView.CurrentRow.Index].Value);
            try
            {
                OleDbCommand cmd = new OleDbCommand("delete from Театр where [id театра]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = theatreID;
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

        private void editButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            theatreID = Convert.ToInt32(theatresDataGridView[0, theatresDataGridView.CurrentRow.Index].Value);
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Театр where [id театра]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = theatreID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    theatreNameTextbox.Text = reader.GetString(1);
                    theatreAdressTextbox.Text = reader.GetString(2);
                }
                reader.Close();
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Не удалось получить данные.\nОшибка: " + ex.Message);
                con.Close();
            }
            theatresPanel.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            theatresPanel.Hide();
            clearFields();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < theatresDataGridView.Rows.Count; i++)
                {
                    if (theatresDataGridView[fieldsCombobox.SelectedIndex, i].Value.ToString() == findTextbox.Text)
                    {
                        theatresDataGridView.CurrentCell = theatresDataGridView[fieldsCombobox.SelectedIndex, i];
                        return;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось найти введенное значение.");
            }
        }

        private void theatresReportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet worksheet;
            workbook = excelApp.Workbooks.Add(System.Reflection.Missing.Value);
            worksheet = (Excel.Worksheet)workbook.Sheets[1];
            worksheet.Cells[1, 1] = theatresDataGridView.Columns[0].HeaderText;
            worksheet.Cells[1, 2] = theatresDataGridView.Columns[1].HeaderText;
            worksheet.Cells[1, 3] = theatresDataGridView.Columns[2].HeaderText;
            for (int i = 0; i < theatresDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = theatresDataGridView[0, i].Value;
                worksheet.Cells[i + 2, 2] = theatresDataGridView[1, i].Value;
                worksheet.Cells[i + 2, 3] = theatresDataGridView[2, i].Value;
            }
            worksheet.Columns.AutoFit();
            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            (theatresDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("[" + filterCombobox.Text.ToString() + "]" + " = '{0}'", filterTextbox.Text);
        }

        private void resetFilterButton_Click(object sender, EventArgs e)
        {
            (theatresDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
        }
    }
}
