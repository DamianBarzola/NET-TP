using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter Curso;

        public CursoAdapter CursoA
        {
            get { return Curso; }
            set { Curso = value; }
        }

        public CursoLogic()
        {
            CursoA = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            return CursoA.GetAll();

        }


        public Curso GetOne(int id)
        {
            return CursoA.GetOne(id);
        }

        public void Save(Curso crs)
        {
            CursoA.Save(crs);
        }

        public void Delete(Curso crs)
        {
            CursoA.Delete(crs);
        }
        public List<Curso> GetPorAnio(int a)
        {
            return CursoA.GetPorAnio(a);
        }

            public DataTable GetListado(Persona user)
        {

            List<Curso> cursos = new List<Curso>();
            if ((int)user.Tipo == 2)
            {
                DocenteCursoLogic dcl = new DocenteCursoLogic();
                List<DocenteCurso> dclist = dcl.GetAllFromUser(user.ID);

                foreach (DocenteCurso dc in dclist)
                {
                    cursos.Add(CursoA.GetOne(dc.IDCurso));
                }
            }
            else
            {
                cursos = CursoA.GetAll();
            }

            //Se crea el DataTable que va a ser el DataSource del dgv
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("AnioCalendario", typeof(int));
            Listado.Columns.Add("Cupo", typeof(int));
            Listado.Columns.Add("Materia", typeof(string));
            Listado.Columns.Add("Comision", typeof(string));
            Listado.Columns.Add("Plan", typeof(string));

            //La columna materia mostrara materia.Descripcion 
            //La columna comision mostrara comision.Descripcion
            //La columna plan mostrara especialidad.Descripcion + plan.Descripcion
            //En vez de mostrar los ID's que aportan poca informacion
            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll();
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();
            MateriaLogic ml = new MateriaLogic();
            List<Materia> materias = ml.GetAll();
            ComisionLogic coml = new ComisionLogic();
            List<Comision> comisiones = coml.GetAll();

            foreach (Curso cur in cursos)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = cur.ID;
                Linea["AnioCalendario"] = cur.AnioCalendario.ToString();
                Linea["Cupo"] = cur.Cupo;

                Comision com = comisiones.FirstOrDefault(x => x.ID == cur.IDComision);
                Linea["Comision"] = com.Descripcion;

                Materia materia = materias.FirstOrDefault(x => x.ID == cur.IDMateria);
                Plan plan = planes.FirstOrDefault(x => x.ID == materia.IDPlan);
                Especialidad esp = especialidades.FirstOrDefault(x => x.ID == plan.IDEspecialidad);
                Linea["Materia"] = materia.Descripcion;
                Linea["Plan"] = esp.DescripcionEspecialidad + " - " + plan.DescripcionPlan;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }
    }
}
