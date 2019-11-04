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

        public void Delete(Especialidad a) { EspecA.Delete(a); }

        public void Save(Especialidad esp)
        {
            EspecA.Save(esp);
        }

       
    }
}
