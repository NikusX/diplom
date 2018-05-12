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
    public partial class regForm : Form
    {
        public regForm()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            string login = loginTextbox.Text;
            login = login.Trim();
            string password = passwordTextbox.Text;
            string passwordRepeat = passwordRepeatTextbox.Text;
            string fio = fioTextbox.Text;
            DateTime birthDate = birthdateDateTimePicker.Value;
            string adress = adressTextbox.Text;
            if(login == "" || password == "" || fio == "" || adress == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            if(passwordRepeat != password)
            {
                MessageBox.Show("Повторный пароль введен не верно.");
                return;
            }
            if(password.ToLower().Contains(login.ToLower()))
            {
                MessageBox.Show("Пароль не должен содержать логин.");
                return;
            }
            try
            {
                OleDbConnection con = staticVariables.con;
                con.Open();
                OleDbCommand cmd = new OleDbCommand("insert into Пользователь(ФИО, [Дата рождения], Логин, Пароль, Адрес, [Персональная скидка (%)], Роль) values (@fio, @birthDate, @login, @password, @adress, 0, 'Заказчик')", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("@fio", OleDbType.VarChar).Value = fio;
                cmd.Parameters.Add("@birthDate", OleDbType.DBDate).Value = birthDate;
                cmd.Parameters.Add("@login", OleDbType.VarChar).Value = login;
                cmd.Parameters.Add("@password", OleDbType.VarChar).Value = password;
                cmd.Parameters.Add("@adress", OleDbType.VarChar).Value = adress;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Вы успешно зарегистрированы.");
                con.Close();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Не удалось связаться с базой данных.");
            }
        }

        private void PasswordShowCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(PasswordShowCheckbox.Checked)
            {
                passwordTextbox.PasswordChar = '\0';
                passwordRepeatTextbox.PasswordChar = '\0';
            }
            else
            {
                passwordTextbox.PasswordChar = '•';
                passwordRepeatTextbox.PasswordChar = '•';
            }
        }
    }
}
