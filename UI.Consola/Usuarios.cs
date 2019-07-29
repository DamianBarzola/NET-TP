using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;
using static System.Console;

namespace UI.Consola
{
    public class Usuarios
    {
        public UsuarioLogic UsuarioNegocio { get; set; }

        public Usuarios()
        {
            UsuarioNegocio = new UsuarioLogic();
        }

        public void Menu()
        {

            int op;
            op = 0;


            Console.WriteLine("---Menu de Opciones---");
            Console.WriteLine();
            Console.WriteLine("1.Listado General");
            Console.WriteLine("2.Consulta");
            Console.WriteLine("3.Agregar");
            Console.WriteLine("4.Modificar");
            Console. WriteLine("5.Eliminar");
            Console.WriteLine("6.Salir");

            do
            {
                WriteLine("Ingrese opción");
                op = int.Parse(ReadLine());
                switch (op)
                {
                    case 1:
                        ListadoGeneral();
                        Console.ReadLine();
                        break;
                    case 2:
                          Consultar();
                        Console.ReadLine();
                        break;                   
                    case 3:
                       Agregar();
                        Console.ReadLine();
                        break;
                   case 4:
                       Modificar();
                        Console.ReadLine();
                        break;
                    case 5:
                     Eliminar();
                        Console.ReadLine();
                        break;
                    case 6:
                        break;

                    default:
                        WriteLine("Ingresar una de las opciones");
                        break;
                }
            } while ((op < 0) & (op > 6));
        }
    
        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: ", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese el ID del usuario a consultar");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }

            catch (FormatException fe)
            {
          
             Console.WriteLine();
             Console.WriteLine("La ID ingresada debe ser un número entero");
    
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }

        }


        public void Modificar()
        {
            try
            {

                Console.Clear();
                Console.Write("Ingrese el ID del usuairo a modificar:");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.Write("Ingrese Nombre:");
                usuario.Nombre = Console.ReadLine();
                Console.Write("Ingrese Apellido:");
                usuario.Apellido = Console.ReadLine();
                Console.Write("Ingrese Nombre de Usuario:");
                usuario.NombreUsuario = Console.ReadLine();
                Console.Write("Ingrese Clave:");
                usuario.Clave = Console.ReadLine();
                Console.Write("Ingrese Email:");
                usuario.Email = Console.ReadLine();
                Console.Write("Ingrese Habilitacion del Usuario (1- Si / 2- No)");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser u número entero");

            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Write("Ingrese el ID del usurio a eliminar: ");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);
            }

            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser u número entero");

            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Usuario usuario = new Usuario();

            Console.Clear();
            Console.Write("Ingrese Nombre:");
            usuario.Nombre = Console.ReadLine();
            Console.Write("Ingrese Apellido:");
            usuario.Apellido = Console.ReadLine();
            Console.Write("Ingrese Nombre de Usuario:");
            usuario.NombreUsuario = Console.ReadLine();
            Console.Write("Ingrese Clave:");
            usuario.Clave = Console.ReadLine();
            Console.Write("Ingrese Email:");
            usuario.Email = Console.ReadLine();
            Console.Write("Ingrese Habilitación de Usuario (1-Si / 2-No):");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New;
            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("ID: (0)", usuario.ID);
        }
    }
}
