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
namespace UI.Desktop.ABMs
{
    public partial class PersonaDesktop : ApplicationForm
    {
        ModoForm modoform;
        Persona personaActual;
        PersonaLogic plogic = new PersonaLogic();

        #region Constructores
        public PersonaDesktop()
        {
            InitializeComponent();
        }
        public PersonaDesktop(ModoForm modo)
        {
            InitializeComponent();
            this.modoform = modo;
        }
        public PersonaDesktop(int id, ModoForm modo)
        {
            InitializeComponent();
            this.personaActual = plogic.GetOne(id);
            this.modoform = modo;
            this.MapearDeDatos();
        }

        #endregion

        #region Mapeos
       override public void  MapearADatos()
        {

        }

       override public void  MapearDeDatos()
       {
            cargarCombo();  
            txtID.Text = personaActual.ID.ToString();
            txtLegajo.Text = personaActual.Legajo.ToString();   
            txtNombre.Text= personaActual.Nombre;
            txtApellido.Text = personaActual.Apellido;
            txtTelef.Text = personaActual.Telefono;
            dtpFechaNacimiento.Value = personaActual.FechaNacimiento;
       }


        #endregion






        private void cargarCombo()
        {
            cbxTipo.DataSource = Enum.GetValues(typeof(Persona.TipoPersona));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            switch (this.modoform)
            {
                case ModoForm.Alta:
                    this.Text = "Nueva Persona";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar Persona";
                    break;
            }
        }


        #region no usado
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
