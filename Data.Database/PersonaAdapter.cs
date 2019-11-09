using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmPErsona = new SqlCommand(" select * from personas", SqlConn);
                SqlDataReader drPersona = cmPErsona.ExecuteReader();

                while (drPersona.Read())
                {
                    Persona pers = new Persona();
                    pers.ID = (int)drPersona["id_persona"];
                    pers.Nombre = (string)drPersona["nombre"];
                    pers.Apellido = (string)drPersona["apellido"];
                    pers.Direccion = (string)drPersona["direccion"];
                    pers.Telefono = (string)drPersona["telefono"];
                    pers.FechaNacimiento = (DateTime)drPersona["fecha_nac"];
                    pers.Legajo = (int)drPersona["legajo"];
                    pers.Tipo = (Persona.TipoPersona)drPersona["tipo_persona"];
                    personas.Add(pers);
                }
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public Persona GetOne(int ID)
        {

            Persona pers = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmPErs = new SqlCommand(" select * from personas WHERE id_persona=@id", SqlConn);
                cmPErs.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersona = cmPErs.ExecuteReader();

                if (drPersona.Read())
                {
                    pers.ID = (int)drPersona["id_persona"];
                    pers.Nombre = (string)drPersona["nombre"];
                    pers.Apellido = (string)drPersona["apellido"];
                    pers.Direccion = (string)drPersona["direccion"];
                    pers.Telefono = (string)drPersona["telefono"];
                    pers.FechaNacimiento = (DateTime)drPersona["fecha_nac"];
                    pers.Legajo = (int)drPersona["legajo"];
                    pers.Tipo = (Persona.TipoPersona)drPersona["tipo_persona"];
                }
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return pers;
        }
       
        public void Delete(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE from personas WHERE id_persona=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar persona", ex);
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
                SqlCommand cmdDelete = new SqlCommand("DELETE from personas WHERE id_persona=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar persona", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE personas SET nombre=@nombre,apellido=@apellido,direccion=@direccion," +
                    "telefono=@telefono,fecha_nac=@fecha_nac," +
                    "tipo_persona=@tipo_persona WHERE id_persona=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmUpd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmUpd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmUpd.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmUpd.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmUpd.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmUpd.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = (int)persona.Tipo;
                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Persona persona)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO personas(nombre,apellido,direccion,telefono,fecha_nac,legajo," +
                    "tipo_persona) " +
                    "values(@nombre,@apellido,@direccion,@telefono,@fecha_nac,@legajo,@tipo_persona) SELECT @@identity", SqlConn);

                cmIns.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmIns.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmIns.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmIns.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmIns.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = persona.FechaNacimiento;
                cmIns.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmIns.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = (int)persona.Tipo;
                persona.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }

        public List<Persona> GetPersonasSinUsuario()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                this.OpenConnection();
                SqlCommand cmPErsona = new SqlCommand("select p.id_persona , p.nombre, " + 
               " p.apellido from personas p where p.id_persona not in " + 
               " ( select distinct p.id_persona from personas p inner join usuarios u " + 
               " on u.id_persona = p.id_persona) ", SqlConn);
                SqlDataReader drPersona = cmPErsona.ExecuteReader();

                while (drPersona.Read())
                {
                    Persona pers = new Persona();
                    pers.ID = (int)drPersona["id_persona"];
                    pers.Nombre = (string)drPersona["nombre"];
                    pers.Apellido = (string)drPersona["apellido"];
                    personas.Add(pers);
                }
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }
    }
}
