using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision_Alumno : BusinessEntity
    {
        private int _idpersona;
        public int IDPersona { get => _idpersona; set => _idpersona = value; }
        private int _parcial1;
        public int Parcial1 { get => _parcial1; set => _parcial1 = value; }
        private int _parcial2;
        public int Parcial2 { get => _parcial2; set => _parcial2 = value; }
        private int _parcial3;
        public int Parcial3 { get => _parcial3; set => _parcial3 = value; }
        private int _notafinal;
        public int NotaFinal { get => _notafinal; set => _notafinal = value; }

    }
}
