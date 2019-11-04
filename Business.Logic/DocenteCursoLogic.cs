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
    public class DocenteCursoLogic : BusinessLogic
    {

        private DocenteCursoAdapter DocenteCurso;
        public DocenteCursoAdapter DocenteCursoA { get => DocenteCurso; set => DocenteCurso = value; }

        public DocenteCursoLogic()
        {
            DocenteCursoA = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoA.GetAll();
        }
        public List<DocenteCurso> GetAllFromUser(int id)
        {
            return DocenteCursoA.GetAllFromUser(id);
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoA.GetOne(id);
        }
        public DocenteCurso GetOne(int IDDocente, int IDCurso)
        {
            return DocenteCursoA.GetOne(IDDocente, IDCurso);
        }

        public void Save(DocenteCurso dc)
        {
            DocenteCursoA.Save(dc);
        }


    }
}
