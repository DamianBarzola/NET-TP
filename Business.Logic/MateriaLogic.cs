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
    public class MateriaLogic : BusinessLogic
    {
        private MateriaAdapter materiaa;

        public MateriaAdapter MateriaA
        {
            get { return materiaa; }
            set { materiaa = value; }
        }

        public MateriaLogic()
        {
            MateriaA = new MateriaAdapter();
        }

        public List<Materia> GetAll()
        {
            return MateriaA.GetAll();

        }
        public void Delete(Materia m)
        {
            MateriaA.Delete(m);
        }

        public Materia GetOne(int id)
        {
            return MateriaA.GetOne(id);
        }

        public void Save(Materia mat)
        {
            MateriaA.Save(mat);
        }
        

    }
}
