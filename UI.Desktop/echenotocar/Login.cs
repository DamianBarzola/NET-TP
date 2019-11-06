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
{
    public partial class Login : Form
    {
        #region constructor
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        public Boolean logueado = false;
        public Usuario usuariologueado;

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            try
            {
                UsuarioLogic ul = new UsuarioLogic();
                Usuario user = ul.GetOne(txtUsuario.Text);
                if (txtUsuario.Text.Equals(user.NombreUsuario) && txtPass.Text.Equals(user.Clave))
                {
                    this.Visible = false;
                    Main Menu = new Main(user);
                    Menu.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Error del servidor. /n" + ex.Message);
             }


            txtPass.Text = string.Empty;
            this.Enabled = true;
        }

        

        private void txtUsuario_TextChanged(object sender, EventArgs e) {}

        private void LnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
