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
    public class PlanLogic : BusinessLogic
    {

        private PlanAdapter plan;

        public PlanAdapter PlanA
        {
            get { return plan; }
            set { plan = value; }
        }

        public PlanLogic()
        {
            PlanA = new PlanAdapter();
        }

        public List<Plan> GetAll()
        {
            return PlanA.GetAll();

        }

        public Plan GetOne(int id)
        {
            return PlanA.GetOne(id);
        }


        public void Save(Plan plan)
        {
            PlanA.Save(plan);
        }

        public DataTable GetListado()
        {

            List<Plan> planes = PlanA.GetAll();
            DataTable Listado = new DataTable(); //Este DataTable se va a utilizar como source del dgv
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Descripcion", typeof(string));
            Listado.Columns.Add("Especialidad", typeof(string));

            //Seobtiene la lista de especialidades para mostrar su descripcion en la columna conrrespondiente
            //en vez de ver el id que aporta poca informacion
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();

            foreach (Plan plan in planes)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = plan.ID;
                Linea["Descripcion"] = plan.DescripcionPlan;

                Especialidad esp = especialidades.FirstOrDefault(x => x.ID == plan.IDEspecialidad);
                Linea["Especialidad"] = esp.DescripcionEspecialidad;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }
    }
}
