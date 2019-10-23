using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    { 
   private string _Nombre, _Apellido, _Email, _NombreUsuario, _Clave;
        private bool _CambiaClave;
        private int _IDPersona;


        public string Nombre { get => _Nombre; set => _Nombre = value; }
    public string Apellido { get => _Apellido; set => _Apellido = value; }
    public string Email { get => _Email; set => _Email = value; }
    public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
    public string Clave { get => _Clave; set => _Clave = value; }
    public bool CambiaClave { get => _CambiaClave; set => _CambiaClave = value; }
        public int IDPersona { get => _IDPersona; set => _IDPersona = value; }
    }
}
