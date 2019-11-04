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
        public List<Curso> GetPorAnio(int a)
        {
            return CursoA.GetPorAnio(a);

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

        
    }
}
