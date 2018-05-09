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
        public static OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\boxOfficeDB.mdb");

        public static string userRole = "";
        public static int userId;

        public static loginForm mainForm;
        public static List<Template> forms = new List<Template>();
        public static void addToList(Template t)
        {
            forms.Add(t);
        }
        public static void closeAll()
        {
            for(int i=0; i<forms.Count(); i++)
            {
                forms[i].Close();
            }
            mainForm.Show();
        }
    }
}