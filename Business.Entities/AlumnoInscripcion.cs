using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
       // private Condiciones _Condicion;
        private int _IDAlumno,parcial1,parcial2,parcial3,notafinal;
        private int _IDComision;
        //private int _Nota;

      //  public enum Condiciones { Regular = 1, Aprobado = 2, Cursando = 3, Libre = 4 }

        //public Condiciones Condicion { get => _Condicion; set => _Condicion = value; }
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDComision { get => _IDComision; set => _IDComision = value; }
        public int Parcial1 { get => parcial1; set => parcial1 = value; }
        public int Parcial2 { get => parcial2; set => parcial2 = value; }
        public int Parcial3 { get => parcial3; set => parcial3 = value; }
        public int Notafinal { get => notafinal; set => notafinal = value; }

        // public int Nota { get => _Nota; set => _Nota = value; }
    }
}
