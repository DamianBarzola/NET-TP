using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter : Adapter
    {
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", SqlConn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario user = new Usuario();
                    user.ID = (int)drUsuarios["id_usuario"];
                    user.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    user.Clave = (string)drUsuarios["clave"];
                    user.Nombre = (string)drUsuarios["nombre"];
                    user.Apellido = (string)drUsuarios["apellido"];
                    user.Email = (string)drUsuarios["email"];
                    user.Habilitado = (bool)drUsuarios["habilitado"];
                    user.CambiaClave = (bool)drUsuarios["cambia_clave"];
                    user.IDPersona = (int)drUsuarios["id_persona"];
                    usuarios.Add(user);
                }
                drUsuarios.Close();
                return usuarios;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            
        }

        public Usuario GetOne(int ID)
        {

            Usuario user = new Usuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario=@id", SqlConn);
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                if (drUsuarios.Read())
                {
                    user.ID = (int)drUsuarios["id_usuario"];
                    user.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    user.Clave = (string)drUsuarios["clave"];
                    user.Nombre = (string)drUsuarios["nombre"];
                    user.Apellido = (string)drUsuarios["apellido"];
                    user.Email = (string)drUsuarios["email"];
                    user.Habilitado = (bool)drUsuarios["habilitado"];
                    user.CambiaClave = (bool)drUsuarios["cambia_clave"];
                    user.IDPersona = (int)drUsuarios["id_persona"];
                }
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                new Exception("Error al recuperar usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return user;
        }
        public Usuario GetOne(String username)
        {
            Usuario user = new Usuario();

            try
            { 
            this.OpenConnection();
            SqlCommand cmdUsuarios = new SqlCommand(" select * from usuarios where u.nombre_usuario = @username ", SqlConn);
            cmdUsuarios.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                if (drUsuarios.Read())
                {
                user.ID = (int)drUsuarios["id_usuario"];
                user.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                user.Clave = (string)drUsuarios["clave"];
                user.Nombre = (string)drUsuarios["nombre"];
                user.Apellido = (string)drUsuarios["apellido"];
                user.Email = (string)drUsuarios["email"];
                user.Habilitado = (bool)drUsuarios["habilitado"];
                user.CambiaClave = (bool)drUsuarios["cambia_clave"];
                user.IDPersona = (int)drUsuarios["id_persona"];
                }
            drUsuarios.Close();
                }
    
            catch (Exception Ex)
            {
              Exception ExcepcionManejada =
              new Exception("Error al recuperar usuario", Ex);
              throw Ex;
            }

            finally
            {
                this.CloseConnection();
            }
            return user;
        }

       

        public void Delete(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("UPDATE usuarios SET habilitado=@false WHERE id_usuario=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmdDelete.Parameters.Add("@false", SqlDbType.Bit).Value = false;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al eliminar usuario", ex);
                throw excepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmUpd = new SqlCommand("UPDATE usuarios SET nombre=@nombre,apellido=@apellido,email=@email," +
                    "nombre_usuario=@nombre_usuario," +
                    "habilitado=@habilitado,cambia_clave=@cambia_clave,id_plan=@id_plan WHERE id_usuario=@id", SqlConn);

                cmUpd.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmUpd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmUpd.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmUpd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmUpd.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmUpd.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmUpd.Parameters.Add("@cambia_clave", SqlDbType.Bit).Value = false;
                cmUpd.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

       
        protected void Insert(Usuario usuario)
        {

            try
            {
                this.OpenConnection();
                SqlCommand cmIns = new SqlCommand("INSERT INTO usuarios(nombre,apellido,email," +
                    "nombre_usuario,clave,habilitado,cambia_clave) " +
                    "values(@nombre,@apellido,@email,@nombre_usuario," +
                    "@clave,@habilitado,@cambia_clave) SELECT @@identity", SqlConn);

                cmIns.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmIns.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmIns.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmIns.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmIns.Parameters.Add("@clave", SqlDbType.Char, 60).Value = usuario.Clave;
                cmIns.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmIns.Parameters.Add("@cambia_clave", SqlDbType.Bit).Value = false;
                usuario.ID = Decimal.ToInt32((decimal)cmIns.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

       public void UpdatePassword(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmCambiarPass = new SqlCommand("UPDATE usuarios SET clave=@clave WHERE id_usuario=@id", SqlConn);

                cmCambiarPass.Parameters.Add("@id", SqlDbType.Int).Value = usuario.ID;
                cmCambiarPass.Parameters.Add("@clave", SqlDbType.Char, 60).Value = usuario.Clave;
                cmCambiarPass.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

      

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario);
            }
            else if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }
      
    }
}
