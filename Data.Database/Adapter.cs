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
        /*
        Si estamos trabajando con un MS Sql Server con una instancia sin nombre
        instalado en la misma PC en la que estamos desarrollando usaremos
        ConnStringLocal, en caso que hayamos instalado un Sql Express sin   
        modificar el nombre de instancia usaremos ConnStringExpress y si
        estamos usando el serverisi usaremos ConnStringServerISI.Estos los
        iremos cambiando en la medida que estemos trabajando en otros entornos
        */

        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringLocal";

        private SqlConnection sqlConn;

        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");

        protected void OpenConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(connectionString);
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

        protected SqlConnection SqlConn
        {
            get { return sqlConn; }
        }

    }
}
