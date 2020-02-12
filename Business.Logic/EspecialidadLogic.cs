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
    public class EspecialidadLogic : BusinessLogic
    {

        private EspecialidadAdapter especialidad;
        public EspecialidadAdapter EspecA { get => especialidad; set => especialidad = value; }

        public EspecialidadLogic()
        {
            EspecA = new EspecialidadAdapter();
        }

        public List<Especialidad> GetAll()
        {
            return EspecA.GetAll();
        }

        public Especialidad GetOne(int id)
        {
            return EspecA.GetOne(id);
        }

        public void Delete(Especialidad esp)
        {
            EspecA.Delete(esp);
        }

        public void Delete(int id)
        {
            EspecA.Delete(id);
        }

        public void Save(Especialidad esp)
        {
            EspecA.Save(esp);
        }

        public DataTable GetListado()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Descripcion", typeof(string));

            List<Especialidad> especialidades = EspecA.GetAll();

            foreach (Especialidad esp in especialidades)
            {
                dt.Rows.Add(new object[] { esp.ID, esp.DescripcionEspecialidad });
            }
            return dt;
        }
    }
}
