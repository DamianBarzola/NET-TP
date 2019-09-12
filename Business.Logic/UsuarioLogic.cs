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
        private UsuarioAdapter _UsuarioData;
        public UsuarioAdapter UsuarioData { get=> _UsuarioData; set=> _UsuarioData = value; }

        public UsuarioLogic() {
            UsuarioData = new UsuarioAdapter();
        }

        public List<Usuario> GetAll() {
            return UsuarioData.GetAll();
        }

        public Usuario GetOne(int ID) {
            return UsuarioData.GetOne(ID);
        }
        public Usuario GetOne (string username)
        {
            try
            {
                return UsuarioData.GetOne(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int ID) {
            UsuarioData.Delete(ID);
        }

        public void Save(Usuario usuario) {
            UsuarioData.Save(usuario);
        }

        
    }
}
