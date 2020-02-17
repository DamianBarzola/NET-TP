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

    }
}
