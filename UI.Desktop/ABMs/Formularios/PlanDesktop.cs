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
using Util;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        //FALTA COMBOBOX
        private Plan _PlanActual;
        public Plan PlanActual { get => _PlanActual; set => _PlanActual = value; }

        PlanLogic plogic = new PlanLogic();

        #region Constructores
        public PlanDesktop()
        {
            InitializeComponent();
            lblcbespecialidad.Visible = false;
            lblDesc.Visible = false;
        }
        //alta
        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            lblID.Visible = false;
            CargarCombo();
        }

        //baja y modificacion
        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            PlanLogic pLogic = new PlanLogic();
            PlanActual = pLogic.GetOne(ID);
            CargarCombo();
            MapearDeDatos();
            lblID.Visible = true;
        }
        #endregion

        #region Mapeos
        public override void MapearDeDatos()
        {
            lblID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.DescripcionPlan;
            cbEspecialidades.SelectedValue = PlanActual.IDEspecialidad;
            switch (Modo)
            {
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtDescripcion.ReadOnly = true;
                    cbEspecialidades.Enabled = false;
                    break;
            }

        }

        public override void MapearADatos()
        {
            switch (this.Modo)
            {
                case ModoForm.Alta:
                    PlanActual = new Plan()
                    {
                       DescripcionPlan = txtDescripcion.Text,
                       IDEspecialidad = (int)cbEspecialidades.SelectedValue,
                       State = Usuario.States.New
                    };
                    break;

                case ModoForm.Modificacion:
                    PlanActual.DescripcionPlan = txtDescripcion.Text;
                    PlanActual.IDEspecialidad = (int)cbEspecialidades.SelectedValue;
                    PlanActual.State = Usuario.States.Modified;
                    break;

                case ModoForm.Baja:
                    PlanActual.State = Usuario.States.Deleted;
                    break;
            }
        }

        #endregion

        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";
            if (!Validaciones.ValTexto(txtDescripcion.Text))
            {
                valid = false;
                mensaje += "/n Ingrese descripcion";
            }
            if(cbEspecialidades.SelectedValue == null || (int)cbEspecialidades.SelectedValue == 0)
            {
                valid = false;
                mensaje += "/n Elija una especialidad";
            }
            if (!valid)
            {
                MessageBox.Show("Error" + mensaje);
            }
            return valid;
        }

        public override void GuardarCambios()
        {
                this.MapearADatos();
                plogic.Save(PlanActual);
                this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        public void CargarCombo()
        {
            cbEspecialidades.ValueMember = "id_especialidad";
            cbEspecialidades.DisplayMember = "descripcion";
            cbEspecialidades.DataSource = GenerarCombo.getPlanes();
        }


        private void PlanDesktop_Load(object sender, EventArgs e)
        {
        }

        private void cbEsp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
