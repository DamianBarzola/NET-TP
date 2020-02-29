using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Business.Logic;
using Business.Entities;

namespace Util
{
    public class GenerarCombo
    {

        public static DataTable getEspecialidades()
        {
            DataTable dtEspecialidades = new DataTable();
            dtEspecialidades.Columns.Add("id_especialidad", typeof(int));
            dtEspecialidades.Columns.Add("descripcion", typeof(string));
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();
            dtEspecialidades.Rows.Add(new object[] { 0, string.Empty });
            foreach (Especialidad esp in especialidades)
            {
                    dtEspecialidades.Rows.Add(new object[] { esp.ID, esp.DescripcionEspecialidad });
            }
            return dtEspecialidades;
        }


        public static DataTable getPlanes()
        {
            DataTable dtPlanes = new DataTable();
            dtPlanes.Columns.Add("id_plan", typeof(int));
            dtPlanes.Columns.Add("descripcion", typeof(string));
            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll();
            dtPlanes.Rows.Add(new object[] { 0, string.Empty });
            foreach (Plan plan in planes)
            {
                    dtPlanes.Rows.Add(new object[] { plan.ID, plan.DescripcionPlan });
            }
            return dtPlanes;
        }

        public static DataTable getMaterias()
        {
            DataTable dtMaterias = new DataTable();
            dtMaterias.Columns.Add("id_materia", typeof(int));
            dtMaterias.Columns.Add("descripcion", typeof(string));
            MateriaLogic ml = new MateriaLogic();
            List<Materia> materias = ml.GetAll();
            dtMaterias.Rows.Add(new object[] { 0, string.Empty });
            foreach (Materia m in materias)
            {
                dtMaterias.Rows.Add(new object[] { m.ID, m.Descripcion});
            }
            return dtMaterias;
        }

        public static DataTable getProfesores()
        {
            DataTable dtProfesores = new DataTable();
            dtProfesores.Columns.Add("id_persona", typeof(int));
            dtProfesores.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetProfesores();
            dtProfesores.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtProfesores.Rows.Add(new object[] { p.ID, p.Apellido });
            }
            return dtProfesores;
        }

        public static DataTable getPersona()
        {
            DataTable dtPersona = new DataTable();
            dtPersona.Columns.Add("id_persona", typeof(int));
            dtPersona.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetAll();
            dtPersona.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtPersona.Rows.Add(new object[] { p.ID, p.Apellido });
            }
            return dtPersona;
        }

        public static DataTable getAlumno()
        {
            DataTable dtAlumno = new DataTable();
            dtAlumno.Columns.Add("id_persona", typeof(int));
            dtAlumno.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetAlumnos();
            dtAlumno.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtAlumno.Rows.Add(new object[] { p.ID, p.Apellido });
            }
            return dtAlumno;
        }


        public static DataTable getComisiones()
        {
            DataTable dtcomisiones = new DataTable();
            dtcomisiones.Columns.Add("id_comision", typeof(int));          
            ComisionLogic cl = new ComisionLogic();
            List<Comision> comi = cl.GetAll();
            dtcomisiones.Rows.Add(new object[] { 0});

            foreach (Comision com in comi)
            {
                dtcomisiones.Rows.Add(new object[] {com.ID});
            }

            return dtcomisiones;
        }/*
        public static DataTable getPlanes()
        {
            DataTable dtPlanes = new DataTable();
            dtPlanes.Columns.Add("id_plan", typeof(int));
            dtPlanes.Columns.Add("descripcion", typeof(string));
            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll();
            dtPlanes.Rows.Add(new object[] { 0, string.Empty });
            foreach (Plan plan in planes)
            {
                dtPlanes.Rows.Add(new object[] { plan.ID, plan.DescripcionPlan });
            }
            return dtPlanes;
        }*/


        public static DataTable getComisiones(int id)
        {
            DataTable dtcomisiones = new DataTable();
            dtcomisiones.Columns.Add("id_comision", typeof(int));
            dtcomisiones.Columns.Add("id_materia", typeof(string));
            MateriaLogic ml = new MateriaLogic();
            ComisionLogic cl = new ComisionLogic();
            List <Comision>  comi = cl.GetActuales(id);
            dtcomisiones.Rows.Add(new object[] { 0, string.Empty });

            foreach (Comision com in comi)
            {
                DataRow linea = dtcomisiones.NewRow();
                linea["id_comision"] = com.ID;
                Materia mat = ml.GetOne(com.IDMateria);
                linea["id_materia"] = mat.Descripcion;
                dtcomisiones.Rows.Add(linea);
            }

            return dtcomisiones;
        }
        public static DataTable getAlumno(int a)
        {
            DataTable dtAlumno = new DataTable();
            dtAlumno.Columns.Add("id_persona", typeof(int));
            dtAlumno.Columns.Add("apellido", typeof(string));
            PersonaLogic pl = new PersonaLogic();
            List<Persona> personas = pl.GetAlumnos(a);
            dtAlumno.Rows.Add(new object[] { 0, string.Empty });
            foreach (Persona p in personas)
            {
                dtAlumno.Rows.Add(new object[] { p.ID,p.Apellido });
            }
            return dtAlumno;
        }

    }
}
