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
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter comision;
        public ComisionAdapter ComisionA { get => comision; set => comision = value; }

        public List<Comision> GetPorAnio()
        {
            return ComisionA.GetPorAnio();
        }
        public ComisionLogic()
        {
            ComisionA = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionA.GetAll();
        }
        public List<Comision> GetAll(int a)
        {
            return ComisionA.GetAll(a);
        }
        public List<Comision> GetActuales(int id)
        {
            return ComisionA.GetActuales(id);
        }

        public Comision GetOne(int id)
        {
            return ComisionA.GetOne(id);
        }

        public void Delete(Comision com)
        {
            ComisionA.Delete(com);
        }
        public void Delete(int id)
        {
            ComisionA.Delete(id);
        }

        public void Save(Comision com)
        {
            ComisionA.Save(com);
        }
/*
        public DataTable GetListado()
        {
            List<Comision> comisiones = ComisionA.GetAll();

            //creo el DataTable que va a ser el DataSource del dgv
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Descripcion", typeof(string));
            Listado.Columns.Add("AnioEspecialidad", typeof(int));
            Listado.Columns.Add("Plan", typeof(string));

            //La columna plan mostrara especialidad.Descripcion + plan.Descripcion
            //En vez de mostrar los ID's que aportan poca informacion
            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll();
            EspecialidadLogic el = new EspecialidadLogic();
            List<Especialidad> especialidades = el.GetAll();

            foreach (Comision com in comisiones)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = com.ID;
               // Linea["Descripcion"] = com.Descripcion;
                Linea["AnioEspecialidad"] = com.AnioEspecialidad;

                Plan plan = planes.FirstOrDefault(x => x.ID == com.IDPlan);
                Especialidad esp = especialidades.FirstOrDefault(x => x.ID == plan.IDEspecialidad);
                Linea["Plan"] = esp.DescripcionEspecialidad + " - " + plan.DescripcionPlan;

                Listado.Rows.Add(Linea);
            }

            return Listado;
        }*/
    }
}
