using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private String _DescripcionPlan;
        private int _IDEspecialidad;

        public String DescripcionPlan { get => _DescripcionPlan; set => _DescripcionPlan = value; }
        public int IDEspecialidad { get => _IDEspecialidad; set => _IDEspecialidad = value; }
    }
}
