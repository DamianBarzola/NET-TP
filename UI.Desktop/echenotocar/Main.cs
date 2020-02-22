using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using UI.Desktop.ABMs;

namespace UI.Desktop
{//Como extra podriamos actualizar las vistas dependiendo si esta logueado o no
 //  Para eso tenemos que modificar los metodo login y logout
    public partial class Main : Form
    {
        private Usuario _UsuarioLogueado;
        public Usuario UsuarioLogueado { get => _UsuarioLogueado; set => _UsuarioLogueado = value; }

        #region constructores
        public Main()
        {
            InitializeComponent();
            SetearVistas();
        }
        public Main(Usuario user) : this()
        {
            UsuarioLogueado = user;
            ActualizarVista();
        }

        #endregion

        //pone todas las vistas en true
        public void SetearVistas()
        {
            tsmAdministrar.Visible = true;
            tsmDocentes.Visible = true;
            tsmAlumnos.Visible = true;

        }
        public void ActualizarVista()
        {
            Persona per = new Persona();
            PersonaLogic pLogic = new PersonaLogic();
            per = pLogic.GetOne(UsuarioLogueado.Id_persona);
            lblNombrePersona.Text = per.Nombre + "-" + per.Apellido;

            switch (per.Tipo)
            {
                case Persona.TipoPersona.Alumno:
                    lblTipoPersona.Text = "Alumno";
                    tsmAdministrar.Visible = false;
                    tsmDocentes.Visible = false;
                    break;

                case Persona.TipoPersona.Docente:
                    lblTipoPersona.Text = "Docente";
                    tsmAdministrar.Visible = false;
                    tsmAlumnos.Visible = false;
                    break;

                case Persona.TipoPersona.Administrador:
                    lblTipoPersona.Text = "Administrador";
                    tsmAlumnos.Visible = false;
                    tsmDocentes.Visible = false;
                    break;
            }


        }

        public void Login()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public void Logout()
        {
            UsuarioLogueado = null;
            this.Close();
            Login();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Logout();
        }

        private void tsmMateriasInscripto_Click(object sender, EventArgs e)
        {
            MateriasInscriptoForm materiasInscriptoForm = new MateriasInscriptoForm();
            materiasInscriptoForm.ShowDialog();
        }

        private void tsmInscribirseAMateria_Click(object sender, EventArgs e)
        {
            InscribirComisionDesktop inscribirComisionDesktop = new InscribirComisionDesktop();
            inscribirComisionDesktop.ShowDialog();
        }

       private void tsmUsuarios_Click(object sender, EventArgs e)
       {
                UsuariosList ul = new UsuariosList();
                ul.ShowDialog();
       }


 

        private void tsmAdministrarPersonas_Click(object sender, EventArgs e)
        {
            PersonasList personasList = new PersonasList();
            personasList.ShowDialog();
        }

        private void aBMEspecialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EspecialidadesList especialidadeslist = new EspecialidadesList();
            especialidadeslist.ShowDialog();
        }

        private void aBMPlanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlanesList planesList = new PlanesList();
            planesList.ShowDialog();
        }

        private void aBMMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriasList materiasList = new MateriasList();
            materiasList.ShowDialog();
        }

        private void aBMCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComisionesList comisionList = new ComisionesList();
            comisionList.ShowDialog();
        }


        //no

        private void administrarCursadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
