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
                SqlCommand cmIns = new SqlCommand("INSERT INTO comision_alumnos (id_persona, id_comision, parcial1, parcial2, parcial3, notafinal) values (@alumno, @comision, @p1, @p2, @p3, @nf)", SqlConn);
                cmIns.Parameters.Add("@alumno", SqlDbType.Int).Value = comal.IDPersona;
                cmIns.Parameters.Add("@comision", SqlDbType.Int).Value = comal.ID;
                cmIns.Parameters.Add("@p1", SqlDbType.Int).Value = 0;
                cmIns.Parameters.Add("@p2", SqlDbType.Int).Value = 0;
                cmIns.Parameters.Add("@p3", SqlDbType.Int).Value = 0;
                cmIns.Parameters.Add("@nf", SqlDbType.Int).Value = 0;


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

        public void Update(Comision_Alumno comal)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("Update comision_alumnos set parcial1=@p1, parcial2=@p2, parcial3=@p3, notafinal=@nf where id_persona=@alumno and id_comision=@comision", SqlConn);
                cmIns.Parameters.Add("@alumno", SqlDbType.Int).Value = comal.IDPersona;
                cmIns.Parameters.Add("@comision", SqlDbType.Int).Value = comal.ID;
                cmIns.Parameters.Add("@p1", SqlDbType.Int).Value = comal.Parcial1;
                cmIns.Parameters.Add("@p2", SqlDbType.Int).Value = comal.Parcial2;
                cmIns.Parameters.Add("@p3", SqlDbType.Int).Value = comal.Parcial3;
                cmIns.Parameters.Add("@nf", SqlDbType.Int).Value = comal.NotaFinal;
                cmIns.ExecuteNonQuery();
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

        public List<Comision_Alumno> GetAll()
        {
            List<Comision_Alumno> alumnos = new List<Comision_Alumno>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAl = new SqlCommand(" SELECT * FROM comision_alumnos", SqlConn);
                SqlDataReader drAl = cmdAl.ExecuteReader();

                while (drAl.Read())
                {
                    Comision_Alumno comal = new Comision_Alumno();
                    comal.IDPersona = (int)drAl["id_persona"];
                    comal.ID = (int)drAl["id_comision"];
                    comal.Parcial1 = (int)drAl["parcial1"];
                    comal.Parcial2 = (int)drAl["parcial2"];
                    comal.Parcial3 = (int)drAl["parcial3"];
                    comal.NotaFinal = (int)drAl["notafinal"];

                    alumnos.Add(comal);
                }
                drAl.Close();
                return alumnos;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos para este profesor", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public Comision_Alumno GetOne(int idalumno, int idcomision)
        {
            Comision_Alumno comal = new Comision_Alumno();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAl = new SqlCommand(" SELECT * FROM comision_alumnos where id_persona = @idalumno and id_comision = @idcomision", SqlConn);
                cmdAl.Parameters.Add("@idalumno", SqlDbType.Int).Value = idalumno;
                cmdAl.Parameters.Add("@idcomision", SqlDbType.Int).Value = idcomision;

                SqlDataReader drAl = cmdAl.ExecuteReader();

                while (drAl.Read())
                {
                    comal.IDPersona = (int)drAl["id_persona"];
                    comal.ID = (int)drAl["id_comision"];
                    comal.Parcial1 = (int)drAl["parcial1"];
                    comal.Parcial2 = (int)drAl["parcial2"];
                    comal.Parcial3 = (int)drAl["parcial3"];
                    comal.NotaFinal = (int)drAl["notafinal"];
                }
                drAl.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de alumnos para este profesor", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return comal;
        }



        /*
                public List<Comision_Alumno> GetAlumnosParaNotas(int idprofesor)
                {
                    List<Comision_Alumno> alumnos = new List<Comision_Alumno>();
                    try
                    {
                        this.OpenConnection();
                        SqlCommand cmdAl = new SqlCommand(" SELECT * FROM comision_alumnos   inner join comision_alumnos on comision_alumnos.id_comision = comision.id_comision where comision.id_profesor = @idprofesor", SqlConn);
                        cmdAl.Parameters.Add("@idprofesor", SqlDbType.Int).Value = idprofesor;
                        SqlDataReader drAl = cmdAl.ExecuteReader();

                        while (drAl.Read())
                        {
                            Comision_Alumno comal = new Comision_Alumno();
                            comal.IDPersona = (int)drAl["id_persona"];
                            comal.ID = (int)drAl["id_comision"];
                            comal.Parcial1 = (int)drAl["parcial1"];
                            comal.Parcial2 = (int)drAl["parcial2"];
                            comal.Parcial3 = (int)drAl["parcial3"];
                            comal.NotaFinal = (int)drAl["notafinal"];

                            alumnos.Add(comal);
                        }
                        drAl.Close();
                        return alumnos;
                    }
                    catch (Exception Ex)
                    {
                        Exception ExcepcionManejada =
                        new Exception("Error al recuperar lista de alumnos para este profesor", Ex);
                        throw ExcepcionManejada;
                    }
                    finally
                    {
                        this.CloseConnection();
                    }

                }*/



    }
}
