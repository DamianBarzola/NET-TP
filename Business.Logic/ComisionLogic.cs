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

        public ComisionLogic()
        {
            ComisionA = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            return ComisionA.GetAll();
        }

        public Comision GetOne(int id)
        {
            return ComisionA.GetOne(id);
        }
        public void Delete(Comision a)
        {
            ComisionA.Delete(a);
        }

        public void Save(Comision com)
        {
            ComisionA.Save(com);
        }

       
    }
}
