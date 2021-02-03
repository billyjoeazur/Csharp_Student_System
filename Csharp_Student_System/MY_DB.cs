using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Csharp_Student_System
{
    class MY_DB
    {
        //connection
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=billyjaoo;database=csharp_student_db");

        //function to get the connection
        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //function to open the connection
        public void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //function to close the connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
