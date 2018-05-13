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
                OleDbCommand cmd = new OleDbCommand("select [id пользователя], ФИО, Логин, Пароль from Пользователь where Логин=:login and Пароль=:password", con);
                cmd.Parameters.Add("login", OleDbType.VarChar).Value = login;
                cmd.Parameters.Add("password", OleDbType.VarChar).Value = password;
                OleDbDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    staticVariables.userId = reader.GetInt32(0);
                    staticVariables.userFio = reader.GetString(1);
                    staticVariables.userLogin = reader.GetString(2);
                    MessageBox.Show("Добро пожаловать, \n" + staticVariables.userFio + "!");
                    reader.Close();
                    con.Close();
                    loginTextbox.Text = "";
                    passwordTextbox.Text = "";
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Логин или пароль введены неверно. Проверьте правильность ввода данных.");
                    reader.Close();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Логин или пароль введены неверно. Проверьте правильность ввода данных.");
            }

            mainForm mainForm1 = new mainForm();
            mainForm1.Show();
        }
    }
}
