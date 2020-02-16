using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comision", SqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                while (drComisiones.Read())
                {
                    Comision com = new Comision();

                    com.ID = (int)drComisiones["id_comision"];                   
                    com.AnioEspecialidad = (int)drComisiones["anio"];
                    com.IDMateria = (int)drComisiones["id_materia"];
                    com.IdProfesor = (int)drComisiones["id_profesor"];
                    //com.Habilitado = (bool)drComisiones["com_hab"];
                    // com.Descripcion = (string)drComisiones["desc_comision"];
                    comisiones.Add(com);
                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comisiones;
        }
        public Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("SELECT * FROM comision WHERE id_comision=@id", SqlConn);
                cmdComisiones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();

                if (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio"];
                    com.IDMateria = (int)drComisiones["id_materia"];
                    com.IdProfesor = (int)drComisiones["id_profesor"];

                }
                drComisiones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }
        /*public void Delete(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("UPDATE comision SET com_hab=@false WHERE id_comision=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                cmdDelete.Parameters.Add("@false", SqlDbType.Bit).Value = false;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar comision", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }*/
        public void Delete(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM comision WHERE id_comision=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar Comision", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE comision SET anio = @an, id_profesor = @profesor, id_materia = @materia  " +                    
                    "WHERE id_comision=@id", SqlConn);
                /*
                com.ID = (int)drComisiones["id_comision"];
                com.AnioEspecialidad = (int)drComisiones["anio"];
                com.IDMateria = (int)drComisiones["id_materia"];
                com.IdProfesor = (int)drComisiones["id_profesor"];
                */

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                cmUpd.Parameters.Add("@profesor", SqlDbType.Int).Value = com.IdProfesor;                
                cmUpd.Parameters.Add("@materia", SqlDbType.Int).Value = com.IDMateria;
                cmUpd.Parameters.Add("@an", SqlDbType.Int).Value = com.AnioEspecialidad;

                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Comision com)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO comision(id_profesor, id_materia, anio) " +
                    "values(@profesor, @materia, @an) SELECT @@identity", SqlConn);
                /* cmIns.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = com.Descripcion;
                 cmIns.Parameters.Add("@anio", SqlDbType.Int).Value = com.AnioEspecialidad;
                 cmIns.Parameters.Add("@idplan", SqlDbType.Int).Value = com.IDPlan;
                 cmIns.Parameters.Add("@com_hab", SqlDbType.Bit).Value = com.Habilitado;
                 */
                cmIns.Parameters.Add("@profesor", SqlDbType.Int).Value = com.IdProfesor;
                cmIns.Parameters.Add("@materia", SqlDbType.Int).Value = com.IDMateria;
                cmIns.Parameters.Add("@an", SqlDbType.Int).Value = com.AnioEspecialidad;

                com.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
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
        public void Save(Comision com)
        {
            if (com.State == BusinessEntity.States.Deleted)
            {
                this.Delete(com);
            }
            else if (com.State == BusinessEntity.States.New)
            {
                this.Insert(com);
            }
            else if (com.State == BusinessEntity.States.Modified)
            {
                this.Update(com);
            }
            com.State = BusinessEntity.States.Unmodified;
        }


    }
}
