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
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";

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
