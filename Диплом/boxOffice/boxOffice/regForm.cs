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
<<<<<<< HEAD
            login = login.Trim();
            string password = passwordTextbox.Text;
            string fio = fioTextbox.Text;
            DateTime birthDate = birthdateDateTimePicker.Value;
            string adress = adressTextbox.Text;
            if(login == "" || password == "" || fio == "" || adress == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            if(password.Equals(login))
            {
                MessageBox.Show("Пароль не должен содержать логин.");
            }
            try
            {

            }
            catch
            {

            }
            OleDbConnection con = staticVariables.con;
            OleDbCommand cmd = new OleDbCommand("insert into ", con);
=======
            string password = passwordTextbox.Text;
            string fio = fioTextbox.Text;

>>>>>>> a24c158fbd0026e3834eb745a5128066c91bb36f
        }
    }
}
