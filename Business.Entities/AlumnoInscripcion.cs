﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
       // private Condiciones _Condicion;
        private int _IDAlumno;
        private int _IDComision;
        //private int _Nota;

      //  public enum Condiciones { Regular = 1, Aprobado = 2, Cursando = 3, Libre = 4 }

        //public Condiciones Condicion { get => _Condicion; set => _Condicion = value; }
        public int IDAlumno { get => _IDAlumno; set => _IDAlumno = value; }
        public int IDComision { get => _IDComision; set => _IDComision = value; }
       // public int Nota { get => _Nota; set => _Nota = value; }
    }
}
