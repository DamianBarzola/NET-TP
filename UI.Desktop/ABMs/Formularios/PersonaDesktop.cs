using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
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
        //alta
        public PersonaDesktop(ModoForm modo) : this()
        {
            this.modoform = modo;
            cargarCombo();
        }
        //baja y modif
        public PersonaDesktop(int id, ModoForm modo) : this()
        {
            this.personaActual = plogic.GetOne(id);
            this.modoform = modo;
            this.MapearDeDatos();
        }

        #endregion

        #region Mapeos
       override public void  MapearADatos()
        {
            switch (this.modoform)
            {
                case ModoForm.Alta:
                    personaActual = new Persona
                    {
                        Tipo = (Persona.TipoPersona)cbxTipo.SelectedValue,
                        Legajo = int.Parse(txtLegajo.Text),
                        Apellido = txtApellido.Text,
                        Nombre = txtNombre.Text,
                        Telefono = txtTelef.Text,
                        Direccion = txtDireccion.Text,
                        FechaNacimiento = dtpFechaNacimiento.Value.Date,
                        State = Usuario.States.New
                    };
            break;
                case ModoForm.Modificacion:
                    personaActual.Tipo = (Persona.TipoPersona)cbxTipo.SelectedValue;
                    personaActual.Legajo = int.Parse(txtLegajo.Text);
                    personaActual.Apellido = txtApellido.Text;
                    personaActual.Nombre = txtNombre.Text;
                    personaActual.Telefono = txtTelef.Text;
                    personaActual.Direccion = txtDireccion.Text;
                    personaActual.FechaNacimiento = dtpFechaNacimiento.Value.Date;
                    personaActual.State = Usuario.States.Modified;
                    break;
                case ModoForm.Baja:
                    personaActual.State = Usuario.States.Deleted;
                    break;
            }

        }

        override public void  MapearDeDatos()
       {
            cargarCombo();  
            txtID.Text = personaActual.ID.ToString();
            txtLegajo.Text = personaActual.Legajo.ToString();   
            txtNombre.Text= personaActual.Nombre;
            txtApellido.Text = personaActual.Apellido;
            txtTelef.Text = personaActual.Telefono;
            txtDireccion.Text = personaActual.Direccion;
            dtpFechaNacimiento.Value = personaActual.FechaNacimiento;
            switch (this.modoform)
            {
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtID.ReadOnly = true;
                    txtLegajo.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    txtApellido.ReadOnly = true;
                    txtTelef.ReadOnly = true;
                    txtDireccion.ReadOnly = true;
                    dtpFechaNacimiento.Enabled = false;
                    cbxTipo.Enabled = false;
                    break;
            }
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        public override void GuardarCambios()
        {
            if (Validar())
            {
                try
                {
                    this.MapearADatos();
                    switch (this.modoform)
                    {
                        case ModoForm.Alta:
                            personaActual.State = BusinessEntity.States.New;
                            break;
                        case ModoForm.Baja:
                            personaActual.State = BusinessEntity.States.Deleted;

                            break;
                        case ModoForm.Modificacion:
                            personaActual.State = BusinessEntity.States.Modified;
                            break;
                    }
                    plogic.Save(personaActual);
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error modificando la persona");
                }

            }


        }

        override public bool Validar()
        {
            bool valid = true;
            string message = "";
            if (txtLegajo.Text.Length == 0)
            {
                valid = false;
                message += "\nEl campo Legajo es obligatorio.";
            }
            else
            {
                try
                {
                    int.Parse(txtLegajo.Text);
                }
                catch (FormatException ef)
                {
                    valid = false;
                    message += "\nEl legajo debe ser un número entero.";
                }
            }

            if (txtNombre.Text.Length == 0)
            {
                valid = false;
                message += "\nEl campo Nombre es obligatorio.";
            }
            else if (!Regex.IsMatch(txtNombre.Text, "^[A-ZÁ-ÚÑ][a-zá-úñ]+( [A-ZÁ-ÚÑ][a-zá-úñ]+)*$"))
            {
                valid = false;
                message += "\nNombre inválido.";
            }

            if (txtApellido.Text.Length == 0)
            {
                valid = false;
                message += "\nEl campo Apellido es obligatorio.";
            }
            else if (!Regex.IsMatch(txtApellido.Text, "^[A-ZÁ-ÚÑ][a-zá-úñ]+( [A-ZÁ-ÚÑ][a-zá-úñ]+)*$"))
            {
                valid = false;
                message += "\nApellido inválido.";
            }

            if (txtTelef.Text.Length == 0)
            {
                valid = false;
                message += "\nEl campo Telefono es obligatorio.";
            }
            else if (!Regex.IsMatch(txtTelef.Text, "^[0-9]+$"))
            {
                valid = false;
                message += "\nEl teléfono sólo puede contener números.";
            }

            if (txtDireccion.Text.Length == 0)
            {
                valid = false;
                message += "\nEl campo Dirección es obligatorio.";
            }
            if (!valid)
            {
                MessageBox.Show("Error:" + message, "Usuario inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return valid;
        }

        #region no usado
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
