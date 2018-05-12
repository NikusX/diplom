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
    public partial class userProfileForm : Form
    {
        public userProfileForm()
        {
            InitializeComponent();
        }

        private void changeProfileCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(changeProfileCheckbox.Checked)
            {
                changeProfileButton.Enabled = true;
                loginTextbox.ReadOnly = false;
                fioTextbox.ReadOnly = false;
                adressTextbox.ReadOnly = false;
            }
            else
            {
                loginTextbox.Text = staticVariables.userLogin;
                fioTextbox.Text = staticVariables.userFio;
                adressTextbox.Text = staticVariables.userAdress;
                loginTextbox.ReadOnly = true;
                fioTextbox.ReadOnly = true;
                adressTextbox.ReadOnly = true;
            }
        }

        private void userProfileForm_Load(object sender, EventArgs e)
        {
            birthdateDateTimePicker.MaxDate = DateTime.Today;
            loginTextbox.Text = staticVariables.userLogin;
            fioTextbox.Text = staticVariables.userFio;
            birthdateDateTimePicker.Value = staticVariables.userBirthDate;
            adressTextbox.Text = staticVariables.userAdress;
            personalDiscount.Text = staticVariables.userDiscount.ToString();
        }

        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите изменить данные профиля?", "Подтверждение действия", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // да, меняем данные профиля
                staticVariables.userLogin = loginTextbox.Text;
                staticVariables.userFio = fioTextbox.Text;
                staticVariables.userBirthDate = birthdateDateTimePicker.Value;
                staticVariables.userAdress = adressTextbox.Text;
                OleDbConnection con = staticVariables.con;
                try
                {
                    OleDbCommand cmd = new OleDbCommand("update Пользователь set ФИО=@fio, [Дата рождения]=@birthdate, Логин=@login, Адрес=@adress where [id пользователя]=@userid", con);
                    cmd.Parameters.Add("@fio", OleDbType.VarChar).Value = staticVariables.userFio;
                    cmd.Parameters.Add("@birthdate", OleDbType.DBDate).Value = staticVariables.userBirthDate;
                    cmd.Parameters.Add("@login", OleDbType.VarChar).Value = staticVariables.userLogin;
                    cmd.Parameters.Add("@adress", OleDbType.VarChar).Value = staticVariables.userAdress;
                    cmd.Parameters.Add("@userid", OleDbType.Integer).Value = staticVariables.userId;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Ваши данные успешно изменены.");
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при изменении данных.");
                    con.Close();
                    return;
                }
                changeProfileCheckbox.Checked = false;
                loginTextbox.ReadOnly = true;
                fioTextbox.ReadOnly = true;
                adressTextbox.ReadOnly = true;
            }
            else return; // нет, выходим
        }
    }
}
