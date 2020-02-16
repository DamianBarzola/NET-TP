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
                    AlumnoInscripcion insc = new AlumnoInscripcion
                    {
                        //ID = (int)drAlumnoInscripciones["id_inscripcion"],
                        IDAlumno = (int)drAlumnoInscripciones["id_persona"],
                        IDComision = (int)drAlumnoInscripciones["id_comision"],
                       // Habilitado = (bool)drAlumnoInscripciones["ai_hab"],
                        //Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"],
                        //Condicion = (AlumnoInscripcion.Condiciones)System.Enum.Parse(typeof(AlumnoInscripcion.Condiciones), (string)drAlumnoInscripciones["condicion"])
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
        public List<AlumnoInscripcion> GetAllFromUser(int IDUsuario)
        {
            List<AlumnoInscripcion> alumnoInscripciones = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnoInscripciones = new SqlCommand("SELECT * FROM comision_alumnos WHERE id_persona = @ID AND ai_hab = @ai_hab", SqlConn);
                cmdAlumnoInscripciones.Parameters.Add("@ID", SqlDbType.Int).Value = IDUsuario;
                cmdAlumnoInscripciones.Parameters.Add("@ai_hab", SqlDbType.Bit).Value = true;
                SqlDataReader drAlumnoInscripciones = cmdAlumnoInscripciones.ExecuteReader();

                while (drAlumnoInscripciones.Read())
                {
                    AlumnoInscripcion insc = new AlumnoInscripcion
                    {
                        IDAlumno = (int)drAlumnoInscripciones["id_persona"],
                        IDComision = (int)drAlumnoInscripciones["id_comision"],
                        /* ID = (int)drAlumnoInscripciones["id_inscripcion"],
                         IDAlumno = (int)drAlumnoInscripciones["id_alumno"],
                         IDCurso = (int)drAlumnoInscripciones["id_curso"],
                         Habilitado = (bool)drAlumnoInscripciones["ai_hab"],
                         Nota = (drAlumnoInscripciones["nota"] == DBNull.Value) ? 0 : (int)drAlumnoInscripciones["nota"]
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
        }

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
      /*  protected void Update(AlumnoInscripcion insc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE alumnos_inscripciones SET id_alumno = @id_alumno, " +
                    "id_curso = @id_curso, nota = @nota, condicion = @condicion, ai_hab = @ai_hab " +
                    "WHERE id_inscripcion=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = insc.ID;
                cmUpd.Parameters.Add("@id_alumno", SqlDbType.Int).Value = insc.IDAlumno;
                cmUpd.Parameters.Add("@id_curso", SqlDbType.Int).Value = insc.IDCurso;
                cmUpd.Parameters.Add("@nota", SqlDbType.Int).Value = insc.Nota;
                cmUpd.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = insc.Condicion.ToString();
                cmUpd.Parameters.Add("@ai_hab", SqlDbType.Bit).Value = insc.Habilitado;
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
        }*/

        //Hay que modificar a nueva base
       /*
        protected void Insert(AlumnoInscripcion insc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO alumnos_inscripciones(id_alumno, id_curso, condicion, ai_hab) " +
                    "values(@id_alumno, @id_curso, @condicion, @ai_hab) SELECT @@identity", SqlConn);

                cmIns.Parameters.Add("@id_alumno", SqlDbType.Int).Value = insc.IDAlumno;
                cmIns.Parameters.Add("@id_curso", SqlDbType.Int).Value = insc.IDCurso;
                cmIns.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = insc.Condicion.ToString();
                cmIns.Parameters.Add("@ai_hab", SqlDbType.Bit).Value = insc.Habilitado;

                insc.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
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
        }*/
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
                //this.Update(insc);
            }
            insc.State = BusinessEntity.States.Unmodified;
        }
    }

}

