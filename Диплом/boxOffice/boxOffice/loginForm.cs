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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) // действия при клике на кнопку "Вход"
        {
            string login = loginTextbox.Text;
            login = login.Trim();
            string password = passwordTextbox.Text;
            try
            {
                OleDbConnection con = staticVariables.con;
                con.Open();
                OleDbCommand cmd = new OleDbCommand("select [id пользователя], ФИО, [Дата рождения], Логин, Пароль, Адрес, [Персональная скидка (%)], Роль from Пользователь where Логин=:login and Пароль=:password", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("login", OleDbType.VarChar).Value = login;
                cmd.Parameters.Add("password", OleDbType.VarChar).Value = password;
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    if(reader.GetString(3) == login && reader.GetString(4) == password) // проверяется соответствие логина и пароля
                    {
                        staticVariables.userId = reader.GetInt32(0);
                        staticVariables.userFio = reader.GetString(1);
                        staticVariables.userBirthDate = reader.GetDateTime(2);
                        staticVariables.userLogin = reader.GetString(3);
                        staticVariables.userAdress = reader.GetString(5);
                        staticVariables.userDiscount = reader.GetInt32(6);
                        staticVariables.userRole = reader.GetString(7);
                        MessageBox.Show("Вход успешно выполнен!");
                        reader.Close();
                        con.Close();
                        loginTextbox.Text = "";
                        passwordTextbox.Text = "";
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("1Логин или пароль введены неверно. Проверьте правильность ввода данных.");
                    reader.Close();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("2Логин или пароль введены неверно. Проверьте правильность ввода данных.");
            }

            switch (staticVariables.userRole)
            {
                case "Заказчик":
                    buyerForm buyerForm1 = new buyerForm();
                    buyerForm1.ShowDialog();
                    break;
                case "Менеджер по продаже":
                    salesManagerForm salesManagerForm1 = new salesManagerForm();
                    salesManagerForm1.ShowDialog();
                    break;
                case "Директор":
                    directorForm directorForm1 = new directorForm();
                    directorForm1.ShowDialog();
                    break;
                case "Техник":
                    technicianForm technicianForm1 = new technicianForm();
                    technicianForm1.ShowDialog();
                    break;
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            staticVariables.mainForm = this;
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            regForm regForm1 = new regForm();
            regForm1.ShowDialog();
        }
    }
}
