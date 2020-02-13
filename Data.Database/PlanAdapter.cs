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
    public class PlanAdapter : Adapter
    {

        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand(" SELECT * FROM [plan] ", SqlConn);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan plan = new Plan();
                    plan.ID = (int)drPlanes["id_plan"];
                    plan.DescripcionPlan = (string)drPlanes["descripcion"];
                    plan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    planes.Add(plan);
                }
                drPlanes.Close();
                return planes;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }




        public Business.Entities.Plan GetOne(int ID)
        {
            Plan plan = new Plan();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("SELECT * FROM [plan] WHERE id_plan=@id", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {
                    plan.ID = (int)drPlanes["id_plan"];
                    plan.DescripcionPlan = (string)drPlanes["descripcion"];
                    plan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return plan;
        }

        public void Delete(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE from [plan] WHERE id_plan=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar plan", ex);
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
                SqlCommand cmdDelete = new SqlCommand("DELETE from [plan] WHERE id_plan=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar plan", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpd = new SqlCommand("UPDATE [plan] SET descripcion = @desc, id_especialidad = @id_e " +
                    "WHERE id_plan=@id", SqlConn);

                cmdUpd.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdUpd.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.DescripcionPlan;
                cmdUpd.Parameters.Add("@id_e", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Plan plan)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmAgregar = new SqlCommand("INSERT INTO [plan] (descripcion,id_especialidad) " +
                    "values(@desc, @id_e) SELECT @@identity", SqlConn);
                cmAgregar.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = plan.DescripcionPlan;
                cmAgregar.Parameters.Add("@id_e", SqlDbType.Int).Value = plan.IDEspecialidad;
                plan.ID = Decimal.ToInt32((decimal)cmAgregar.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }
    }
}
