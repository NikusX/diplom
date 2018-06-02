using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxOffice
{
    public static class staticVariables
    {
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\boxOfficeDB.mdb;Jet OLEDB:Database Password=boxOfficeDB");

        public static int userId;
        public static string userFio = "";
        public static string userLogin = "";      
    }
}