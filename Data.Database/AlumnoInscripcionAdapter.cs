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
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM comision_alumnos", SqlConn);
                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                while (drAlumnoInscripciones.Read())
                {
                    AlumnoInscripcion insc = new AlumnoInscripcion();

                    insc.IDAlumno = (int)drAlumnoInscripciones["id_persona"];
                    insc.IDComision = (int)drAlumnoInscripciones["id_comision"];
                    insc.Parcial1 = (drAlumnoInscripciones["parcial1"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial1"];
                    insc.Parcial2 = (drAlumnoInscripciones["parcial2"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial2"];
                    insc.Parcial3 = (drAlumnoInscripciones["parcial3"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial3"];
                    insc.Notafinal = (drAlumnoInscripciones["notafinal"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["notafinal"];                       
                        //Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"],                     
                    alumnoInscripciones.Add(insc);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Inscripciones", Ex);
                //throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnoInscripciones;
        }
        
        public List<AlumnoInscripcion> GetAllFromUser(int IDUsuario)
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM comision_alumnos WHERE id_persona = @ID ", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@ID", SqlDbType.Int).Value = IDUsuario;
               
                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                while (drAlumnoInscripciones.Read())
                {
                    AlumnoInscripcion insc = new AlumnoInscripcion
                    {
                        IDAlumno = (int)drAlumnoInscripciones["id_persona"],
                        IDComision = (int)drAlumnoInscripciones["id_comision"],
                        Parcial1 = (int)drAlumnoInscripciones["parcial1"],
                        Parcial2 = (int)drAlumnoInscripciones["parcial2"],
                        Parcial3 = (int)drAlumnoInscripciones["parcial3"],
                        Notafinal = (int)drAlumnoInscripciones["notafinal"],
                    };
                    alumnoInscripciones.Add(insc);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnoInscripciones;
        }
        public List<AlumnoInscripcion> GetAllProf(int IDProf)
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("select c.id_comision,c.id_persona,c.parcial1,c.parcial2,c.parcial2,c.parcial3,c.notafinal from comision co inner join comision_alumnos c on c.id_comision=co.id_comision where co.id_profesor= @ID ", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@ID", SqlDbType.Int).Value = IDProf;

                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                while (drAlumnoInscripciones.Read())
                {
                    AlumnoInscripcion insc = new AlumnoInscripcion
                    {
                        IDAlumno = (int)drAlumnoInscripciones["id_persona"],
                        IDComision = (int)drAlumnoInscripciones["id_comision"],
                        Parcial1 = (drAlumnoInscripciones["parcial1"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial1"],
                        Parcial2 = (drAlumnoInscripciones["parcial2"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial2"],
                        Parcial3 = (drAlumnoInscripciones["parcial3"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial3"],
                        Notafinal = (drAlumnoInscripciones["notafinal"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["notafinal"],

                    };
                    alumnoInscripciones.Add(insc);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnoInscripciones;
        }
        /*
        public List<AlumnoInscripcion> GetAllFromCurso(int IDCurso)
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_curso = @ID AND ai_hab = @ai_hab", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@ID", SqlDbType.Int).Value = IDCurso;
                cmdAlumnoInscripciones.Parameters.Add("@ai_hab", SqlDbType.Bit).Value = true;
                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                while (drAlumnoInscripciones.Read())
                {
                    AlumnoInscripcion insc = new AlumnoInscripcion
                    {
                        ID = (int)drAlumnoInscripciones["id_inscripcion"],
                        IDAlumno = (int)drAlumnoInscripciones["id_alumno"],
                        IDCurso = (int)drAlumnoInscripciones["id_curso"],
                        Habilitado = (bool)drAlumnoInscripciones["ai_hab"],
                        Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"],
                        Condicion = (AlumnoInscripcion.Condiciones)System.Enum.Parse(typeof(AlumnoInscripcion.Condiciones), (string)drAlumnoInscripciones["condicion"])
                    };
                    alumnoInscripciones.Add(insc);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de Inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnoInscripciones;
        }*/
        public AlumnoInscripcion GetOne(AlumnoInscripcion alumnocom)
        {
            AlumnoInscripcion insc = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM comision_alumnos WHERE id_persona =@idAlumn and id_comision=@idcom", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@idAlumn", SqlDbType.Int).Value = alumnocom.IDAlumno;
                cmdAlumnoInscripciones.Parameters.Add("@idcom", SqlDbType.Int).Value = alumnocom.IDComision;

                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                if (drAlumnoInscripciones.Read())
                {

                    //insc.ID = (int)drAlumnoInscripciones["id_inscripcion"];
                    insc.IDAlumno = (int)drAlumnoInscripciones["id_persona"];
                    insc.IDComision = (int)drAlumnoInscripciones["id_comision"];
                    insc.Parcial1 = (int)drAlumnoInscripciones["parcial1"];
                    insc.Parcial2 = (int)drAlumnoInscripciones["parcial2"];
                    insc.Parcial3 = (int)drAlumnoInscripciones["parcial3"];
                    insc.Notafinal = (int)drAlumnoInscripciones["notafinal"];
                    //insc.Habilitado = (bool)drAlumnoInscripciones["ai_hab"];
                    //insc.Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"];
                    //insc.Condicion = (AlumnoInscripcion.Condiciones)System.Enum.Parse(typeof(AlumnoInscripcion.Condiciones), (string)drAlumnoInscripciones["condicion"]);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar Inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return insc;
        }
        public AlumnoInscripcion GetOne(int a,int b)
        {
            AlumnoInscripcion insc = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM comision_alumnos WHERE id_persona =@idAlumn and id_comision=@idcom", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@idAlumn", SqlDbType.Int).Value = a;
                cmdAlumnoInscripciones.Parameters.Add("@idcom", SqlDbType.Int).Value = b;

                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                if (drAlumnoInscripciones.Read())
                {

                    //insc.ID = (int)drAlumnoInscripciones["id_inscripcion"];
                    insc.IDAlumno = (int)drAlumnoInscripciones["id_persona"];
                    insc.IDComision = (int)drAlumnoInscripciones["id_comision"];
                    insc.Parcial1 = (drAlumnoInscripciones["parcial1"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial1"];
                    insc.Parcial2 = (drAlumnoInscripciones["parcial2"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial2"];
                    insc.Parcial3 = (drAlumnoInscripciones["parcial3"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["parcial3"];
                    insc.Notafinal = (drAlumnoInscripciones["notafinal"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["notafinal"];

                    //insc.Habilitado = (bool)drAlumnoInscripciones["ai_hab"];
                    //insc.Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"];
                    //insc.Condicion = (AlumnoInscripcion.Condiciones)System.Enum.Parse(typeof(AlumnoInscripcion.Condiciones), (string)drAlumnoInscripciones["condicion"]);
                }
                drAlumnoInscripciones.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar Inscripciones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return insc;
        }
        /*
        public int GetCupo(int IDCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCountCupo = new SqlCommand("SELECT COUNT(id_alumno) FROM alumnos_inscripciones WHERE id_curso = @idcurso", SqlConn);
                cmdCountCupo.Parameters.Add("@idcurso", SqlDbType.Int).Value = IDCurso;
                int cant = (int)cmdCountCupo.ExecuteScalar();

                return cant;
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al obtener cupo", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }*/

        public void Delete(AlumnoInscripcion alumcom)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM comision_alumnos WHERE id_persona = @ida and id_comision=@idcom", SqlConn);
                cmdDelete.Parameters.Add("@ida", SqlDbType.Int).Value = alumcom.IDAlumno;
                cmdDelete.Parameters.Add("@idcom", SqlDbType.Bit).Value = alumcom.IDComision;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar alumnoInscripcion", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        //Hay que modificar a nueva base
         protected void Update(AlumnoInscripcion insc)
          {
              try
              {
                  this.OpenConnection();
                  SqlCommand cmUpd = new SqlCommand("UPDATE comision_alumnos SET " +
                      " parcial1 = @p1, parcial2 = @p2, parcial3 = @p3,notafinal=@nf " +
                      "WHERE id_persona=@idp and id_comision=@asd", SqlConn);

                  cmUpd.Parameters.Add("@idp", SqlDbType.Int).Value = insc.IDAlumno;
                cmUpd.Parameters.Add("@asd", SqlDbType.Int).Value = insc.IDComision;
                cmUpd.Parameters.Add("@p1", SqlDbType.Int).Value = insc.Parcial1;
                  cmUpd.Parameters.Add("@p2", SqlDbType.Int).Value = insc.Parcial2;
                  cmUpd.Parameters.Add("@p3", SqlDbType.Int).Value = insc.Parcial3;
                  cmUpd.Parameters.Add("@nf", SqlDbType.Int).Value = insc.Notafinal;
                  cmUpd.ExecuteNonQuery();
              }
              catch (Exception Ex)
              {
                  Exception ExcepcionManejada = new Exception("Error al modificar datos de Inscripcion", Ex);
                  throw ExcepcionManejada;
              }
              finally
              {
                  this.CloseConnection();
              }
          }

        //Hay que modificar a nueva base

        public void Insert(AlumnoInscripcion insc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO comision_alumnos(id_persona, id_comision) " +
                    "values(@a, @asd ) ", SqlConn);

                cmIns.Parameters.Add("@a", SqlDbType.Int).Value = insc.IDAlumno;
                cmIns.Parameters.Add("@asd", SqlDbType.Int).Value = insc.IDComision;

                cmIns.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear Inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(AlumnoInscripcion insc)
        {
            if (insc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(insc);
            }
            else if (insc.State == BusinessEntity.States.New)
            {
               // this.Insert(insc);
            }
            else if (insc.State == BusinessEntity.States.Modified)
            {
                this.Update(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }
    }

}

