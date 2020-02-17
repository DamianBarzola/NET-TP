using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;
using System.Data;


namespace Data.Database
{
    public class Comision_AlumnoAdapter : Adapter
    {


        public void Insert(Comision_Alumno comal)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO comision_alumnos (id_persona, id_comision) values (@alumno, @comision)", SqlConn);
                cmIns.Parameters.Add("@alumno", SqlDbType.Int).Value = comal.IDPersona;
                cmIns.Parameters.Add("@comision", SqlDbType.Int).Value = comal.ID;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
