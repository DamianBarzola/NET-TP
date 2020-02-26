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
    public partial class MateriaDesktop : ApplicationForm
    {
        ModoForm modoform;
        Materia materiaActual;
        MateriaLogic mlogic = new MateriaLogic();

        #region Constructores
        public MateriaDesktop()
        {
            InitializeComponent();
        }
        //alta
        public MateriaDesktop(ModoForm modo) : this()
        {
            this.modoform = modo;
            labelID.Visible = false;
            CargarCombo();
        }
        //baja y modif
        public MateriaDesktop(int id, ModoForm modo) : this()
        {
            this.modoform = modo;
            labelID.Visible = true;
            materiaActual = mlogic.GetOne(id);
            CargarCombo();
            MapearDeDatos();
        }
        #endregion

        #region Mapeos
        override public void MapearADatos()
        { 
            switch (this.modoform)
            {
                case ModoForm.Alta:
                    materiaActual = new Materia()
                    {
                        IDPlan = (int)cbPlanes.SelectedValue,
                        Descripcion = txtDescripcion.Text,
                        State = Usuario.States.New,
                    };
                    
                    break;

                case ModoForm.Modificacion:
                    materiaActual.IDPlan = (int)cbPlanes.SelectedValue;
                    materiaActual.Descripcion = txtDescripcion.Text;
                    materiaActual.ID = Convert.ToInt32(this.labelID.Text);
                    materiaActual.State = Usuario.States.Modified;
                    break;

                case ModoForm.Baja:
                    materiaActual.State = Usuario.States.Deleted;
                    break;
            }
        }

        public override void MapearDeDatos()
        {
            cbPlanes.SelectedValue = materiaActual.IDPlan;
            txtDescripcion.Text = materiaActual.Descripcion;
            labelID.Text = materiaActual.ID.ToString();
            switch (modoform)
            {
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtDescripcion.ReadOnly = true;
                    cbPlanes.Enabled = false;
                    break;
            }
        }
        #endregion

        #region Guardar cambios y validar
        public override void GuardarCambios()
        {
            if (Validar())
            {
                MapearADatos();
                mlogic.Save(materiaActual);
                this.Close();
            }
        }

        public override bool Validar()
        {
            bool valid = true ;
            string mensaje = "";

            if (!Validaciones.ValTexto(txtDescripcion.Text))
            {
                valid = false;
                mensaje += "/Debe ingresar una descripcion";
            }
            if (cbPlanes.SelectedValue == null || (int)cbPlanes.SelectedValue == 0)
            {
                valid = false;
                mensaje += "/nDebe ingresar un plan";
            }
                if (!valid)
            {
                MessageBox.Show(mensaje);
            }

            return valid;
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        public void CargarCombo()
        {
            cbPlanes.ValueMember = "id_plan";
            cbPlanes.DisplayMember = "descripcion";
            cbPlanes.DataSource = GenerarCombo.getPlanes();
        }
    }
}
