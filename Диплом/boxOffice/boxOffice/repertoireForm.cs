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
            DataTable dt = ds.Tables[0];
            repertoireDataGridView.DataSource = dt;
            con.Close();
        }

        private void repertoireForm_Load(object sender, EventArgs e)
        {
            repertoirePanel.Hide();
            this.Height = 550;
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
        }

        private void addPerfomanceButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            this.Height = 810;
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
            this.Height = 550;
            clearFields();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            int currentCellColumn = repertoireDataGridView.CurrentCell.ColumnIndex;
            int currentCellRow = repertoireDataGridView.CurrentCell.RowIndex;
            int perfomanceID = Convert.ToInt32(repertoireDataGridView[0, repertoireDataGridView.CurrentRow.Index].Value);
            if (submitButton.Text == "Добавить")
            {
                if(perfomanceNameTextbox.Text == "" || authorOfWorkTextbox.Text == "" ||
                     genreOfWorkTextbox.Text == "" || directorTextbox.Text == "" ||
                     artDirectorTextbox.Text == "" || actorsTextbox.Text == "" || descriptionTextbox.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                }
                try
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Репертуар ([id театра], [Название спектакля], [Автор произведения], [Жанр произведения], [Режиссер-постановщик], [Художник-постановщик], [Возрастное ограничение], [Действующие лица и исполнители], Описание) " +
                        "values (@theatreid, @name, @author, @genre, @director, @artdirector, @agelimit, @actors, @description)", con);
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatresCombobox.SelectedIndex + 1;
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
                    this.Height = 550;
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
            if(submitButton.Text == "Изменить")
            {
                try
                {
                    OleDbCommand cmd = new OleDbCommand("update Репертуар set [id театра]=@theatreid, [Название спектакля]=@perfomancename, [Автор произведения]=@author, " +
                    "[Жанр произведения]=@genre, [Режиссер-постановщик]=@director, [Художник-постановщик]=@artdirector, [Возрастное ограничение]=@agelimit, " +
                    "[Действующие лица и исполнители]=@actors, Описание=@description where [id спектакля]=@perfomanceid", con);
                    cmd.Parameters.Add("@theatreid", OleDbType.Integer).Value = theatresCombobox.SelectedIndex + 1;
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
                    this.Height = 550;
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
            OleDbConnection con = staticVariables.con;
            try
            {
                OleDbCommand cmd = new OleDbCommand("select * from Репертуар where [id спектакля]=@id", con);
                cmd.Parameters.Add("@id", OleDbType.Integer).Value = perfomanceID;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    theatresCombobox.SelectedIndex = reader.GetInt32(1) - 1;
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
            this.Height = 810;
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
    }
}
