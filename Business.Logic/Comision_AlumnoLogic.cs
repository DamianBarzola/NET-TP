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
    public class Comision_AlumnoLogic : BusinessLogic
    {
        private Comision_AlumnoAdapter comAdap;
        public Comision_AlumnoAdapter Com { get => comAdap; set => comAdap = value; }


        public Comision_AlumnoLogic()
        {
            Com = new Comision_AlumnoAdapter(); 
        }

        public void Insert(Comision_Alumno comal)
        {
            Com.Insert(comal);
        }
    }
}
