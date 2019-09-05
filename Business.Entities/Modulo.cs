using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private string _DescripcionModulo;
        public string DescripcionModulo { get => _DescripcionModulo; set => _DescripcionModulo = value; }
        
    }
}
