using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;
using System.Data;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter AlumnoInscr;
        public AlumnoInscripcionAdapter AlumnoInscA { get => AlumnoInscr; set => AlumnoInscr = value; }

        public AlumnoInscripcionLogic()
        {
            AlumnoInscA = new AlumnoInscripcionAdapter();
        }

        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscA.GetAll();
        }

      /*  public List<AlumnoInscripcion> GetAllFromUser(int IDUsuario)
        {
            return AlumnoInscA.GetAllFromUser(IDUsuario);
        }
        public List<AlumnoInscripcion> GetAllFromCurso(int IDCurso)
        {
            return AlumnoInscA.GetAllFromCurso(IDCurso);
        }*/

        public AlumnoInscripcion GetOne(AlumnoInscripcion id)
        {
            return AlumnoInscA.GetOne(id);
        }/*
        public int GetCantCupo(int IDCurso)
        {
            return AlumnoInscA.GetCupo(IDCurso);
        }*/

        public void Insert(AlumnoInscripcion insc)
        {
            AlumnoInscA.Insert(insc);
        }


            public void Save(AlumnoInscripcion insc)
        {
            AlumnoInscA.Save(insc);
        }
        public void Delete(AlumnoInscripcion insc)
        {
            AlumnoInscA.Delete(insc);
        }

        public DataTable GetListado()
        {
            List<AlumnoInscripcion> inscripciones = AlumnoInscA.GetAll().Where(x => x.Habilitado == true).ToList(); ;

            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Alumno", typeof(string));
            Listado.Columns.Add("Curso", typeof(string));
            Listado.Columns.Add("Nota", typeof(string));
            Listado.Columns.Add("Condicion", typeof(string));

            UsuarioLogic ul = new UsuarioLogic();
            List<Usuario> usuarios = ul.GetAll();
            CursoLogic curl = new CursoLogic();
            List<Curso> cursos = curl.GetAll();
            MateriaLogic matl = new MateriaLogic();
            List<Materia> materias = matl.GetAll();
            ComisionLogic coml = new ComisionLogic();
            List<Comision> comisiones = coml.GetAll();

            foreach (AlumnoInscripcion ai in inscripciones)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = ai.ID;
               // Linea["Nota"] = (ai.Nota == 0) ? "-" : ai.Nota.ToString();
  //              Linea["Condicion"] = ai.Condicion.ToString();

                Usuario user = usuarios.FirstOrDefault(x => x.ID == ai.IDAlumno);
                Linea["Alumno"] = user.ID + " - " + user.Persona.Apellido + ", " + user.Persona.Nombre;
                
    //            Curso curso = cursos.FirstOrDefault(x => x.ID == ai.IDCurso);
              //  Materia materia = materias.FirstOrDefault(x => x.ID == curso.IDMateria);
                //Comision comision = comisiones.FirstOrDefault(x => x.ID == curso.IDComision);
                //Linea["Curso"] = comision.Descripcion + " - " + materia.Descripcion;
                //dami te comente esto para q me corra sin errores (le saque  comision.Descripcion + " - " )
            //    Linea["Curso"] =  materia.Descripcion;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }
    }
}
