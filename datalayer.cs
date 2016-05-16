using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SimpleMVC.Core
{
    public class CollegeDAO
    {
        private dbConnection conn;
        public CollegeDAO()
        {
            conn = new dbConnection();
        }
        public DataTable searchByName(string _collegename)
        {
            string query = string.Format("select * from [t01_college] 
		where t01_collegename like @t01_collegename or t01_email 
		like @t01_email");
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@t01_collegename", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_collegename);
            sqlParameters[1] = new SqlParameter("@t01_email", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(_email);
            return conn.executeSelectQuery(query, sqlParameters);
        }
        public DataTable searchById(string _id)
        {
            string query = "select * from [t01_id] where t01_id = @t01_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@t01_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}