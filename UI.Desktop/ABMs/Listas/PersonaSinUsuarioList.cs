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
    public partial class PersonaSinUsuarioList : ApplicationForm
    {
        private PersonaLogic personas = new PersonaLogic();

        public PersonaSinUsuarioList()
        {
            InitializeComponent();
            dvgPersonasSinUsuario.AutoGenerateColumns = false;
            Listar();
        }

        public void Listar()
        {
            this.dvgPersonasSinUsuario.DataSource = personas.GetPersonasSinUsuario();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.dvgPersonasSinUsuario.SelectedRows.Count != 0)
            { 
        
                int ID = ((Persona)this.dvgPersonasSinUsuario.SelectedRows[0].DataBoundItem).ID;
                UsuarioDesktop ud = new UsuarioDesktop(ID, ModoForm.Alta);
                ud.ShowDialog();
                Listar();
            }

            else
            {
                MessageBox.Show("Seleccione una persona a la que crearle un usuario");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
