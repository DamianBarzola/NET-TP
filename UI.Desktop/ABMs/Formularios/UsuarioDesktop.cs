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
using Util;

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
        }
        #endregion

        #region mapeos
        public override void MapearDeDatos()
        {
            txtEmailV2.Text = UsuarioActual.Email;
            txtUsuarioV2.Text = UsuarioActual.NombreUsuario;
            txtClaveV2.Text = UsuarioActual.Clave;
            txtConfirmarClaveV2.Text = UsuarioActual.Clave;
            chkHabilitadoV2.Checked = UsuarioActual.Habilitado;
            txtID.Text = UsuarioActual.ID.ToString();
            switch (_Modo)
            {
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtClaveV2.ReadOnly = true;
                    txtConfirmarClaveV2.ReadOnly = true;
                    txtEmailV2.ReadOnly = true;
                    txtID.ReadOnly = true;
                    txtUsuarioV2.ReadOnly = true;
                    chkHabilitadoV2.Enabled = false;
                    break;
            }
        }

        public override void MapearADatos()
        {
            switch (this._Modo)
            {
                case ModoForm.Alta:

                    UsuarioActual = new Usuario()
                    {
                        State = Usuario.States.New,
                        Email = txtEmailV2.Text,
                        NombreUsuario = txtUsuarioV2.Text,
                        Clave = txtClaveV2.Text,
                        Habilitado = chkHabilitadoV2.Checked
                    };
                    break;

                case ModoForm.Modificacion:
                    UsuarioActual.State = Usuario.States.Modified;
                    UsuarioActual.Email = this.txtEmailV2.Text;
                    UsuarioActual.NombreUsuario = this.txtUsuarioV2.Text;
                    UsuarioActual.Clave = this.txtClaveV2.Text;
                    UsuarioActual.Habilitado = this.chkHabilitadoV2.Checked;
                    UsuarioActual.ID = Convert.ToInt32(this.txtID.Text);
                    break;

                case ModoForm.Baja:
                    UsuarioActual.State = Usuario.States.Deleted;
                    break;
            }
        }
        #endregion

        #region Validar y guardar
        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";

            if (!Validaciones.ValClave(txtClaveV2.Text))
            {
                valid = false;
                mensaje += "/nDebe ingresar una clave";
            }

            if (!(txtConfirmarClaveV2.Text.Equals(txtClaveV2.Text)) )
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
                try
                {
                    this.MapearADatos();
                    usuarioLogic.Save(UsuarioActual);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error modificando el usuario");
                }
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                GuardarCambios();
                this.Close();
        }
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
                GuardarCambios();
                this.Close();
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

