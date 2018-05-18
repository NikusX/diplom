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
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
            for(int i = 0; i < perfomances.Count; i++)
            {
                perfomancesCombobox.Items.Add(perfomances[i]);
            }
            perfomancesCombobox.SelectedIndex = 0;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            headerLabel.Text = "Редактировать";
            submitButton.Text = "Изменить";
            schedulePanel.Show();
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
                con.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
            try
            {
                OleDbCommand cmd = new OleDbCommand("select Название from Театр where [id театра]=:theatreid", con);
                cmd.Parameters.Add("theatreid", OleDbType.Integer).Value = theatreId;
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    theatreTextbox.Text = reader.GetString(0);
                }
                reader.Close();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
                con.Close();
            }
        }
    }
}
