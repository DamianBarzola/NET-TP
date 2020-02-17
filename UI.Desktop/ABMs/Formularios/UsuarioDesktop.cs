using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;
using Business.Entities;

namespace UI.Desktop
{
   
    public partial class UsuarioDesktop : ApplicationForm
    {

        //Propiedad

        Usuario _UsuarioActual;
        public Usuario UsuarioActual { get => _UsuarioActual; set => _UsuarioActual = value; }

        UsuarioLogic usuarioLogic = new UsuarioLogic();

        #region constructores

        public UsuarioDesktop()
        {
            InitializeComponent();
        }
        //Constructor: Recibe ID PERSONA y el modo (que seria alta siempre)
        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            InitializeComponent();
            this.UsuarioActual = new Usuario();
            _Modo = modo;
            UsuarioActual.Id_persona = ID;
        }
        
          //Constructor: Recibe Usuario y modo de formulario.
          public UsuarioDesktop(Usuario user, ModoForm modo) : this()
          {
            _Modo = modo;
             UsuarioActual = user;
            MapearDeDatos();
            InitializeComponent();
        }
        #endregion

        #region mapeos
        public override void MapearDeDatos()
        {
            txtEmail.Text = UsuarioActual.Email;
            txtUsuario.Text = UsuarioActual.NombreUsuario;
            txtClave.Text = UsuarioActual.Clave;
            txtConfirmarClave.Text = UsuarioActual.Clave;
            chkHabilitado.Checked = UsuarioActual.Habilitado;
            if(_Modo == ModoForm.Modificacion || _Modo == ModoForm.Baja) { txtID.Text = UsuarioActual.ID.ToString(); }
        }

        public override void MapearADatos()
        {
            Usuario UsuarioActual = new Usuario();
            switch (this._Modo)
            {
                case ModoForm.Baja:
                    UsuarioActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    UsuarioActual.State = Usuario.States.Unmodified;
                    break;
                case ModoForm.Alta:
                    UsuarioActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    UsuarioActual.State = Usuario.States.Modified;
                    break;
            }
            if (_Modo == ModoForm.Alta || _Modo == ModoForm.Modificacion)
            {
                if (_Modo == ModoForm.Modificacion) { UsuarioActual.ID = Convert.ToInt32(this.txtID.Text); }
                UsuarioActual.Email = this.txtEmail.Text;
                UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                UsuarioActual.Clave = this.txtClave.Text;
                UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            }

        }
        #endregion

        #region Validar y guardar
        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";
        //   mensaje += txtClave.Text;

            if (txtClave.Text.Length == 0)
            {
                valid = false;
                mensaje += "/nDebe ingresar una clave";
            }

            if (!(txtConfirmarClave.Text.Equals(txtClave)) )
            {
                valid = false;
                mensaje += "/nLas claves deben ser iguales";
            }
            if (!valid)
            {
                MessageBox.Show(mensaje);
            }

            return valid;
        }

        public override void GuardarCambios()
        {
            if (Validar())
            { 
                this.MapearADatos();
                usuarioLogic.Save(UsuarioActual);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                GuardarCambios();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            GuardarCambios();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }


    }




}

