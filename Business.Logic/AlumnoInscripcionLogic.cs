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
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter AlumnoInscr;
        public AlumnoInscripcionAdapter AlumnoInscA { get => AlumnoInscr; set => AlumnoInscr = value; }

        public AlumnoInscripcionLogic()
        {
            AlumnoInscA = new AlumnoInscripcionAdapter();
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscA.GetAll();
        }

        public List<AlumnoInscripcion> GetAllFromUser(int IDUsuario)
        {
            return AlumnoInscA.GetAllFromUser(IDUsuario);
        }
        public List<AlumnoInscripcion> GetAllFromCurso(int IDCurso)
        {
            return AlumnoInscA.GetAllFromCurso(IDCurso);
        }
        public AlumnoInscripcion GetOne(int id)
        {
            return AlumnoInscA.GetOne(id);
        }
        public void Delete(AlumnoInscripcion a)
        {
            AlumnoInscA.Delete(a);
        }
        public int GetCantCupo(int IDCurso)
        {
            return AlumnoInscA.GetCupo(IDCurso);
        }

        public void Save(AlumnoInscripcion insc)
        {
            AlumnoInscA.Save(insc);
        }

        
    }
}
