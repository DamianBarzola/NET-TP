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
    public class DocenteCursoAdapter : Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> docenteCursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("SELECT * FROM docentes_cursos", SqlConn);
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                while (drDocenteCurso.Read())
                {
                    DocenteCurso dc = new DocenteCurso
                    {
                        ID = (int)drDocenteCurso["id_dictado"],
                        IDCurso = (int)drDocenteCurso["id_curso"],
                        IDDocente = (int)drDocenteCurso["id_docente"],
                        Cargo = (DocenteCurso.TipoCargos)drDocenteCurso["cargo"]
                    };

                    docenteCursos.Add(dc);
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de DocenteCursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docenteCursos;
        }
        public List<DocenteCurso> GetAllFromUser(int IDUsuario)
        {
            List<DocenteCurso> docenteCursos = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_docente = @ID ", SqlConn);
                cmdDocenteCurso.Parameters.Add("@ID", SqlDbType.Int).Value = IDUsuario;
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                while (drDocenteCurso.Read())
                {
                    DocenteCurso dc = new DocenteCurso
                    {
                        ID = (int)drDocenteCurso["id_dictado"],
                        IDCurso = (int)drDocenteCurso["id_curso"],
                        IDDocente = (int)drDocenteCurso["id_docente"],
                        Cargo = (DocenteCurso.TipoCargos)drDocenteCurso["cargo"]
                    };

                    docenteCursos.Add(dc);
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de DocenteCursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return docenteCursos;
        }
        public DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_dictado=@id", SqlConn);
                cmdDocenteCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                if (drDocenteCurso.Read())
                {
                    dc.ID = (int)drDocenteCurso["id_dictado"];
                    dc.IDCurso = (int)drDocenteCurso["id_curso"];
                    dc.IDDocente = (int)drDocenteCurso["id_docente"];
                    dc.Cargo = (DocenteCurso.TipoCargos)drDocenteCurso["cargo"];
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar DocenteCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }
        public DocenteCurso GetOne(int IDDocente, int IDCurso)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocenteCurso = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_docente=@iddocente AND id_curso=@idcurso", SqlConn);
                cmdDocenteCurso.Parameters.Add("@iddocente", SqlDbType.Int).Value = IDDocente;
                cmdDocenteCurso.Parameters.Add("@idcurso", SqlDbType.Int).Value = IDCurso;
                SqlDataReader drDocenteCurso = cmdDocenteCurso.ExecuteReader();

                if (drDocenteCurso.Read())
                {
                    dc.ID = (int)drDocenteCurso["id_dictado"];
                    dc.IDCurso = (int)drDocenteCurso["id_curso"];
                    dc.IDDocente = (int)drDocenteCurso["id_docente"];
                    dc.Cargo = (DocenteCurso.TipoCargos)drDocenteCurso["cargo"];
                }
                drDocenteCurso.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar DocenteCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }

        public void Delete(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from docentes_cursos WHERE id_dictado=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar DocenteCurso", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE docentes_cursos SET id_docente = @id_docente, " +
                    "id_curso = @id_curso, cargo = @cargo " +
                    "WHERE id_dictado=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmUpd.Parameters.Add("@id_docente", SqlDbType.Int).Value = dc.IDDocente;
                cmUpd.Parameters.Add("@id_curso", SqlDbType.Int).Value = dc.IDCurso;
                cmUpd.Parameters.Add("@cargo", SqlDbType.Int).Value = (int)dc.Cargo;
                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de DocenteCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO docentes_cursos(id_docente, id_curso, cargo) " +
                    "values(@id_docente, @id_curso, @cargo) SELECT @@identity", SqlConn);

                cmIns.Parameters.Add("@id_docente", SqlDbType.Int).Value = dc.IDDocente;
                cmIns.Parameters.Add("@id_curso", SqlDbType.Int).Value = dc.IDCurso;
                cmIns.Parameters.Add("@cargo", SqlDbType.Int, 50).Value = dc.Cargo;

                dc.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear DocenteCurso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(DocenteCurso dc)
        {
            if (dc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(dc);
            }
            else if (dc.State == BusinessEntity.States.New)
            {
                this.Insert(dc);
            }
            else if (dc.State == BusinessEntity.States.Modified)
            {
                this.Update(dc);
            }
            dc.State = BusinessEntity.States.Unmodified;
        }
    }

}

