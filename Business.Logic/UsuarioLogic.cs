using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        public UsuarioAdapter UsuarioData { get; set; }

        public UsuarioLogic() {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll() {
            return UsuarioData.GetAll();
        }

        public Business.Entities.Usuario GetOne(int ID) {
            return UsuarioData.GetOne(ID);
        }

        public void Delete(int ID) {
            UsuarioData.Delete(ID);
        }

        public void Save(Usuario usuario) {
            UsuarioData.Save(usuario);
        }

        
    }
}
