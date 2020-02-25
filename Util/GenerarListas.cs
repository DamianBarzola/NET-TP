using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Business.Entities;
using Business.Logic;


namespace Util
{
    public class GenerarListas
    {
        private static EspecialidadLogic _EspLogic;
        private static UsuarioLogic _UserLogic;
        private static PlanLogic _PlanLogic;
        private static MateriaLogic _MatLogic;
        private static ComisionLogic _ComLogic;
        private static AlumnoInscripcionLogic _AILogic;
        private static PersonaLogic _persona;

        private static EspecialidadLogic EspLogic { get { if (_EspLogic == null) _EspLogic = new EspecialidadLogic(); return _EspLogic; } }
        private static UsuarioLogic UserLogic { get { if (_UserLogic == null) _UserLogic = new UsuarioLogic(); return _UserLogic; } }
        private static PlanLogic PlanLogic { get { if (_PlanLogic == null) _PlanLogic = new PlanLogic(); return _PlanLogic; } }
        private static MateriaLogic MatLogic { get { if (_MatLogic == null) _MatLogic = new MateriaLogic(); return _MatLogic; } }
        private static ComisionLogic ComLogic { get { if (_ComLogic == null) _ComLogic = new ComisionLogic(); return _ComLogic; } }
        private static AlumnoInscripcionLogic AILogic { get { if (_AILogic == null) _AILogic = new AlumnoInscripcionLogic(); return _AILogic; } }
        private static PersonaLogic PerLogic { get { if (_persona == null) _persona = new PersonaLogic(); return _persona; } }

        public static DataTable GenerarPlan(List<Plan> planes)
        {
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("DescripcionPlan", typeof(string));
            Listado.Columns.Add("IDEspecialidad", typeof(string)); //se muestra descripcion pero no cambiamos el nombre para no tener que modificar todo

            List<Especialidad> especialidades = EspLogic.GetAll();

            foreach (Plan plan in planes)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = plan.ID;
                Linea["DescripcionPlan"] = plan.DescripcionPlan;

                Especialidad esp = especialidades.FirstOrDefault(x => x.ID == plan.IDEspecialidad);
                Linea["IDEspecialidad"] = esp.DescripcionEspecialidad;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }

        
        public static DataTable GenerarUsu(List<Usuario> users)
        {

            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("NombreUsuario", typeof(string));           
            Listado.Columns.Add("Id_persona", typeof(string));////se muestra AyN pero no cambiamos el nombre para no tener que modificar todo
            Listado.Columns.Add("Email", typeof(string));
           

            foreach (Usuario user in users)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = user.ID;
                Linea["NombreUsuario"] = user.NombreUsuario;                
                Linea["Email"] = user.Email;

                Persona per = PerLogic.GetOne(user.Id_persona);
                Linea["Id_persona"] = per.Apellido+"-" +per.Nombre;


                Listado.Rows.Add(Linea);
            }

            return Listado;
        }


        public static DataTable GenerarMateria(List<Materia> materias)
        {
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Descripcion", typeof(string));    
            Listado.Columns.Add("IDPlan", typeof(string));//se muestra descripcion pero no cambiamos el nombre para no tener que modificar todo

            List<Plan> planes = PlanLogic.GetAll();
           
            foreach (Materia mat in materias)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = mat.ID;
                Linea["Descripcion"] = mat.Descripcion;
               
                Plan plan = PlanLogic.GetOne(mat.IDPlan);
               
                Linea["IDPlan"] = plan.DescripcionPlan;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }



        public static DataTable GenerarComision(List<Comision> comisiones)
        {
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("AnioEspecialidad", typeof(int));
            Listado.Columns.Add("IDMateria", typeof(string));//se muestra descripcion pero no cambiamos el nombre para no tener que modificar todo
            Listado.Columns.Add("IdProfesor", typeof(string));//se muestra AyN pero no cambiamos el nombre para no tener que modificar todo
            List<Plan> planes = PlanLogic.GetAll();
            List<Especialidad> especialidades = EspLogic.GetAll();

            foreach (Comision com in comisiones)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = com.ID;
                Linea["AnioEspecialidad"] = com.AnioEspecialidad;

                Persona pers = PerLogic.GetOne(com.IdProfesor);
                Linea["IdProfesor"] = pers.Nombre+" " + pers.Apellido;
                Materia mat = MatLogic.GetOne(com.IDMateria);
                Linea["IDMateria"] = mat.Descripcion;


                Listado.Rows.Add(Linea);
            }

            return Listado;
        }
        



        public static DataTable GenerarPersona(List<Persona> pers)
        {

            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Legajo", typeof(string));
            Listado.Columns.Add("Tipo", typeof(string));
            Listado.Columns.Add("Apellido", typeof(string));
            Listado.Columns.Add("Nombre", typeof(string));
            Listado.Columns.Add("Direccion", typeof(string));
            Listado.Columns.Add("Telefono", typeof(string));
            Listado.Columns.Add("FechaNacimiento", typeof(string));
            Listado.Columns.Add("Id_especialidad", typeof(string));//se muestra descripcion pero no cambiamos el nombre para no tener que modificar todo


            foreach (Persona per in pers)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = per.ID;
                Linea["Legajo"] = per.Legajo;
                Linea["Tipo"] = per.Tipo.ToString();
                Linea["Apellido"] = per.Apellido;
                Linea["Nombre"] = per.Nombre;
                Linea["Direccion"] = per.Direccion;
                Linea["Telefono"] = per.Telefono;
                Linea["FechaNacimiento"] = per.FechaNacimiento.ToString("dd/MM/yyyy");
               

                Especialidad esp = EspLogic.GetOne(per.Id_especialidad);
                Linea["Id_especialidad"] = esp.DescripcionEspecialidad;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }

        public static DataTable GenerarAlumnoCom(List<AlumnoInscripcion> alcom)
        {
            DataTable Listado = new DataTable();
            Listado.Columns.Add("IDAlumno", typeof(int));
            Listado.Columns.Add("IDComision", typeof(int));
            Listado.Columns.Add("Parcial1", typeof(int));
            Listado.Columns.Add("Parcial2", typeof(int));
            Listado.Columns.Add("Parcial3", typeof(int));
            Listado.Columns.Add("Notafinal", typeof(int));
          
            List<Persona> per = PerLogic.GetAll();
            foreach (AlumnoInscripcion ac in alcom)
            {
                DataRow Linea = Listado.NewRow();

                Linea["Parcial1"] = ac.Parcial1;
                Linea["Parcial2"] = ac.Parcial1;
                Linea["Parcial3"] = ac.Parcial3;
                Linea["Notafinal"] = ac.Notafinal;

                Persona pers = PerLogic.GetOne(ac.IDAlumno);
                Linea["IDAlumno"] = pers.Nombre + " " + pers.Apellido;
                
                Linea["IDComision"] = ac.IDComision;


                Listado.Rows.Add(Linea);
            }

            return Listado;
        }
    }
}
