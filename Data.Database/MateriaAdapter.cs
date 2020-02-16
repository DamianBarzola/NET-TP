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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materia", SqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia mat = new Materia();

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["descripcion"];
                   mat.IDPlan = (int)drMaterias["id_plan"];
                   /* mat.Habilitado = (bool)drMaterias["mat_hab"];
                     mat.HSSemanales = (int)drMaterias["hs_semanales"];
                    mat.HSTotales = (int)drMaterias["hs_totales"];*/
                    materias.Add(mat);
                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Business.Entities.Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materia WHERE id_materia=@id", SqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                if (drMaterias.Read())
                {
                  
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.Descripcion = (string)drMaterias["descripcion"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                }
                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }

        public void Delete(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM materia WHERE id_materia=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = mat.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar Materia", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM materia WHERE id_materia=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar Materia", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE materia SET id_plan = @id_plan, " +
                    "descripcion = @descripcion " +
                    "WHERE id_materia=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmUpd.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                cmUpd.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                
                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Materia materia)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmInsert = new SqlCommand("INSERT INTO materia(id_plan, descripcion) " +
                    "values(@id_plan, @descripcion) SELECT @@identity", SqlConn);
                // cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                cmInsert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                materia.ID = Decimal.ToInt32((decimal)cmInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
