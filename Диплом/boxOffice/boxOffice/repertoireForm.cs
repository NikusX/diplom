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

        private void repertoireForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "boxOfficeDBDataSet.Репертуар". При необходимости она может быть перемещена или удалена.
            this.репертуарTableAdapter.Fill(this.boxOfficeDBDataSet.Репертуар);
            repertoirePanel.Hide();
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
        }

        private void addPerfomanceButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Добавить";
            submitButton.Text = "Добавить";
            repertoirePanel.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            repertoirePanel.Hide();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            OleDbConnection con = staticVariables.con;
            if(submitButton.Text == "Добавить")
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
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Не удалось связаться с базой данных.");
                    con.Close();
                }
                this.репертуарTableAdapter.Fill(this.boxOfficeDBDataSet.Репертуар);
            }
        }
    }
}
