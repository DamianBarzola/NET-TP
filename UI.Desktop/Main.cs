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
    public partial class Main : Form
    {
        private Usuario _UsuarioActual;
        public Usuario UsuarioActual { get => _UsuarioActual; set => _UsuarioActual = value; }

        public Main()
        {
            InitializeComponent();
        }
        public Main(Usuario user)
        {
            UsuarioActual = user;
            
        }

        private void MapearDeDatos()
        {
            tbNombre.Text = UsuarioActual.Nombre;
            tbApellido.Text = UsuarioActual.Apellido;
            tbUsuario.Text = UsuarioActual.NombreUsuario;
            tbEmail.Text = UsuarioActual.Email;
            //falta conexion con bd
            //tbFechaNacimiento.Text = UsuarioActual.FechaNacimiento.ToString("dd/MM/yyyy");
            //tbDireccion.Text = UsuarioActual.Direccion;
            //tbTelefono.Text = UsuarioActual.Telefono;
           


        }



        private void Main_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiarPass_Click(object sender, EventArgs e)
        {
            CambiarPass aux = new CambiarPass();
            aux.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           /* if (tbDireccion.Text = UsuarioActual.direccion || tbTelefono.Text = UsuarioActual.telefono 
                || tbEmail.Text = UsuarioActual.Email)
            {
                if (Validar() == true)
                {

                }
                else
                {
                    MessageBox.Show("Datos no validos");
                }
            }
            else
            {
                MessageBox.Show("No ha realizado cambios");
            }*/

        }
        
         private Boolean Validar()
        {
           // if
                return true;
        }





        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Quiero sacar estos 4 pero cuando los borro tira error
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //hasta aca

    }
}
