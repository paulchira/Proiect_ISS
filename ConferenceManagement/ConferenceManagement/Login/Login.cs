using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Login
{
    class Login
    {
        SqlConnection cs = new SqlConnection("Data Source=localhost;Initial Catalog=Conference_Management;Integrated Security=True");

        public Login() { }

        // Return true if user & pass are found in DB or false otherwise.
        // Params :
        //   @user = username
        //   @pass = password
        public bool Auth(string user, string pass)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) from Users where username=@user and password=@pass", cs);
            cs.Open();
            sqlCommand.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            sqlCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            
            int userCount = (int)sqlCommand.ExecuteScalar();
            Console.WriteLine(userCount);
            if (userCount > 0)
                return true;
            return false;
        }
    }
}
