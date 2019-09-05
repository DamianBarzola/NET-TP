using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class Especialidad : BusinessEntity
    {
        private string _DescripcionEspecialidad;
        public string DescripcionEspecialidad { get => _DescripcionEspecialidad; set => _DescripcionEspecialidad = value; }

    }
}
