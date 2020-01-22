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
    public class DocenteCursoLogic : BusinessLogic
    {

        private DocenteCursoAdapter DocenteCurso;
        public DocenteCursoAdapter DocenteCursoA { get => DocenteCurso; set => DocenteCurso = value; }

        public DocenteCursoLogic()
        {
            DocenteCursoA = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> GetAll()
        {
            return DocenteCursoA.GetAll();
        }
        public List<DocenteCurso> GetAllFromUser(int id)
        {
            return DocenteCursoA.GetAllFromUser(id);
        }

        public DocenteCurso GetOne(int id)
        {
            return DocenteCursoA.GetOne(id);
        }
        public DocenteCurso GetOne(int IDDocente, int IDCurso)
        {
            return DocenteCursoA.GetOne(IDDocente, IDCurso);
        }

        public void Save(DocenteCurso dc)
        {
            DocenteCursoA.Save(dc);
        }
        public void Delete(DocenteCurso dc)
        {
            DocenteCursoA.Delete(dc);
        }

        public DataTable GetListado()
        {

            UsuarioLogic ul = new UsuarioLogic();
            List<Usuario> usuarios = ul.GetAll();
            CursoLogic cursol = new CursoLogic();
            List<Curso> cursos = cursol.GetAll();
            ComisionLogic comisionl = new ComisionLogic();
            List<Comision> comisiones = comisionl.GetAll();
            MateriaLogic matl = new MateriaLogic();
            List<Materia> materias = matl.GetAll();

            List<DocenteCurso> dclist = DocenteCursoA.GetAll().Where(x => x.Habilitado == true).ToList();

            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Curso", typeof(string));
            Listado.Columns.Add("Docente", typeof(string));
            Listado.Columns.Add("Cargo", typeof(string));

            foreach (DocenteCurso dc in dclist)
            {
                DataRow Linea = Listado.NewRow();
                Linea["ID"] = dc.ID;
                Linea["Cargo"] = dc.Cargo.ToString();

                Curso curso = cursos.FirstOrDefault(x => x.ID == dc.IDCurso);
                Materia materia = materias.FirstOrDefault(x => x.ID == curso.IDMateria);
                Comision comision = comisiones.FirstOrDefault(x => x.ID == curso.IDComision);
                Usuario docente = usuarios.FirstOrDefault(x => x.ID == dc.IDDocente);
                Linea["Curso"] = comision.Descripcion + " - " + materia.Descripcion;
                Linea["Docente"] = docente.ID.ToString() + " - " + docente.Persona.Apellido + " " + docente.Persona.Nombre;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }

    }
}
