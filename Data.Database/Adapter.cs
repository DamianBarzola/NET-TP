using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Business.Entities;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    { 
        //Yo puse express vos lo vas a tener que cambiar a local
        //const string consKeyDefaultCnnString = "ConnStringExpress2";
        //const string consKeyDefaultCnnString = "ConnStringLocal";
       const string consKeyDefaultCnnString = "ConnStringExpress2"; 

        private SqlConnection sqlConn;
          public SqlConnection SqlConn { get => sqlConn; set => sqlConn = value; }
               

        protected void OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connectionString ;
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;  
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }

       
    }
}
