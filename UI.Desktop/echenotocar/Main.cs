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
        }
        public Main(Usuario user)
        {
            InitializeComponent();
            UsuarioLogueado = user;
            ActualizarVista();

        }
        #endregion


        public void ActualizarVista()
        {
            if(UsuarioLogueado ==null)
            {
                
                this.tsmAlumnos.Visible = false;
                this.tsmDocentes.Visible = false;
                this.tsmCerrarSesion.Visible = false;
                this.tsmIniciarSesion.Visible = true;

                this.tsmAdministrar.Visible = false;
                this.tsmAdministrarDocentes.Visible = false;
            }
            else
            {
                this.tsmIniciarSesion.Visible = false;
                this.tsmCerrarSesion.Visible = true;
                if (UsuarioLogueado != null)
                {
                    /*
                   switch (UsuarioLogueado.Persona.Tipo)
                    {
                        case Persona.TipoPersona.Alumno:
                            MenuAlumno();
                            break;
                        case Persona.TipoPersona.Docente:
                            MenuAlumno();
                            break;
                        case Persona.TipoPersona.Administrador:
                            MenuAlumno();
                            break;

                    }*/

                }

            }
           



        }


        #region Menu
        private void MenuAlumno()
        {
            tsmAlumnos.Visible = true;
        }
        private void MenuPersona()
        {
            tsmDocentes.Visible = true;
            tsmAdministrar.Visible = true;
        }

        private void MenuAdministrador()
        {
            tsmAdministrar.Visible = true;
            tsmAdministrarDocentes.Visible = true;
                
        }
        #endregion

        public void Login()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public void Logout()
        {
            UsuarioLogueado = null;
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

        }

        private void tsmInscribirseAMateria_Click(object sender, EventArgs e)
        {

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





        //no

        private void administrarCursadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
