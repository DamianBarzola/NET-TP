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

namespace UI.Desktop
{//Como extra podriamos actualizar las vistas dependiendo si esta logueado o no
 //  Para eso tenemos que modificar los metodo login y logout
    public partial class Main : Form
    {
        private Usuario _UsuarioLogueado;
        public Usuario UsuarioLogueado { get => _UsuarioLogueado; set => _UsuarioLogueado = value; }

        #region constructor
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
                this.tsmAdministrar.Visible = false;
                this.tsmAlumnos.Visible = false;
                this.tsmDocentes.Visible = false;
                this.tsmCerrarSesion.Visible = false;
                this.tsmIniciarSesion.Visible = true;
            }
            else
            {
                this.tsmIniciarSesion.Visible = false;
                this.tsmCerrarSesion.Visible = true;
                if (UsuarioLogueado != null)
                {
                    
                }

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
    }
}
