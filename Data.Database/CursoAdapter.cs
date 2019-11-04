﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        
             public List<Curso> GetPorAnio(int a)
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos where anio_calendario=@a ", SqlConn);
                cmdCursos.Parameters.Add("@a", SqlDbType.Int).Value = a;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso curso = new Curso();

                    curso.ID = (int)drCursos["id_curso"];
                    curso.Cupo = (int)drCursos["cupo"];
                    curso.AnioCalendario = (int)drCursos["anio_calendario"];
                    curso.IDComision = (int)drCursos["id_comision"];
                    curso.IDMateria = (int)drCursos["id_materia"];
                    cursos.Add(curso);
                }
                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }


        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso curso = new Curso();

                    curso.ID = (int)drCursos["id_curso"];
                    curso.Cupo = (int)drCursos["cupo"];
                    curso.AnioCalendario = (int)drCursos["anio_calendario"];
                    curso.IDComision = (int)drCursos["id_comision"];
                    curso.IDMateria = (int)drCursos["id_materia"];
                    cursos.Add(curso);
                }
                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Business.Entities.Curso GetOne(int ID)
        {
            Curso curso = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos WHERE id_curso=@id", SqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                if (drCursos.Read())
                {
                    curso.ID = (int)drCursos["id_curso"];
                    curso.Cupo = (int)drCursos["cupo"];
                    curso.AnioCalendario = (int)drCursos["anio_calendario"];
                    curso.IDComision = (int)drCursos["id_comision"];
                    curso.IDMateria = (int)drCursos["id_materia"];


                }
                drCursos.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return curso;
        }

        public void Delete(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("Delete from cursos  WHERE id_curso=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar curso", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE cursos SET " +
                    "cupo = @cupo, anio_calendario = @anio_calendario, id_comision = @id_comision, " +
                    "id_materia = @id_materia WHERE id_curso=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmUpd.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmUpd.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmUpd.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmUpd.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso curso)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO cursos(cupo, anio_calendario,id_comision,id_materia) " +
                    "values(@cupo, @anio_calendario, @id_comision,@id_materia) SELECT @@identity", SqlConn);
                cmIns.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmIns.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmIns.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmIns.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmIns.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;

                curso.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
