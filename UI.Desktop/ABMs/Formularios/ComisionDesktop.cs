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
    public partial class ComisionDesktop : ApplicationForm
    {
        ModoForm modoform;
        Comision comisionActual;
        ComisionLogic cLogic = new ComisionLogic();

        #region Constructores
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        //alta
        public ComisionDesktop(ModoForm modo) : this()
        {
            modoform = modo;
            lblID.Visible = false;
            CargarCombo();
        }

        //baja y modificacion
        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            modoform = modo;
            lblID.Visible = true;
            comisionActual = cLogic.GetOne(id);
            CargarCombo();
            MapearDeDatos();

        }

        #endregion

        #region Mapeos
        public override void MapearDeDatos()
        {
            lblID.Text = comisionActual.ID.ToString();
            txtanio.Text = comisionActual.AnioEspecialidad.ToString();
            cbProfesor.SelectedValue = comisionActual.IdProfesor;
            cbMateria.SelectedValue = comisionActual.IDMateria;

            switch (modoform)
            {
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    comisionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    comisionActual.State = BusinessEntity.States.Deleted;
                    break;
            }

        }

        public override void MapearADatos()
        {
            switch (modoform)
            {
                case ModoForm.Alta:
                    comisionActual = new Comision()
                    {
                        IDMateria = (int)cbMateria.SelectedValue,
                        IdProfesor = (int)cbProfesor.SelectedValue,
                        AnioEspecialidad = Convert.ToInt32(txtanio.Text),
                        State = Usuario.States.New,
                    };
                    break;

                case ModoForm.Modificacion:
                    comisionActual.AnioEspecialidad = Convert.ToInt32(txtanio.Text);
                    comisionActual.IDMateria = (int)cbMateria.SelectedValue;
                    comisionActual.IdProfesor = (int)cbProfesor.SelectedValue;
                    comisionActual.State = Usuario.States.Modified;
                    break;

                case ModoForm.Baja:
                    comisionActual.State = Usuario.States.Deleted;
                    break;

            }
        }

        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
            }
        }

        public override void GuardarCambios()
        {
            try
            {
                this.MapearADatos();
                cLogic.Save(comisionActual);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error modificando la comision");
            }

        }

        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";
            if (txtanio.Text.Length > 0)
            {
                if (!Validaciones.ValAnio(Convert.ToInt32(txtanio.Text)))
                {
                    valid = false;
                    mensaje += "/nIngrese un anio valido";
                }
            }
            else
            {
                mensaje += "/n debe ingresar un anio";
            }

            if (cbMateria.SelectedValue == null || (int)cbMateria.SelectedValue == 0)
            {
                valid = false;
                mensaje += "/nIngrese una materia valido";
            }

            if (cbProfesor.SelectedValue == null || (int)cbProfesor.SelectedValue == 0)
            {
                valid = false;
                mensaje += "/nIngrese un profesor valido";
            }
            if (!valid)
            {
                MessageBox.Show(mensaje);
            }

            return valid;
        }

        public void CargarComboMaterias()
        {
            cbMateria.ValueMember = "id_materia";
            cbMateria.DisplayMember = "descripcion";
            cbMateria.DataSource = GenerarCombo.getMaterias();
        }

        public void CargarComboProfesores()
        {
            cbProfesor.ValueMember = "id_persona";
            cbProfesor.DisplayMember = "apellido";
            cbProfesor.DataSource = GenerarCombo.getProfesores();
        }
        
        public void CargarCombo()
        {
            this.CargarComboMaterias();
            this.CargarComboProfesores();
        }

    }
}
