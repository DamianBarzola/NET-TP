using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    { 
        //falta borrar atributos repetidos de persona en usuario en todas las clases (entities y adapter y en la bd)
         private string  _Email, _NombreUsuario, _Clave;
        

        public string Email { get => _Email; set => _Email = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public string Clave { get => _Clave; set => _Clave = value; }

        public virtual Persona Persona { get; set; }

        public bool Habilitado1 { get ; set ; }
    }
}
