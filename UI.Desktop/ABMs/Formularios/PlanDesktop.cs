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
        }
        //alta
        public PlanDesktop(ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            lblID.Visible = false;
            
        }

        //baja y modificacion
        public PlanDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            PlanLogic pLogic = new PlanLogic();
            PlanActual = pLogic.GetOne(ID);
            MapearDeDatos();
            lblID.Visible = true;
        }
        #endregion

        #region Mapeos
        public override void MapearDeDatos()
        {
            lblID.Text = PlanActual.ID.ToString();
            txtDescripcion.Text = PlanActual.DescripcionPlan;
            txtEspecialidad.Text = PlanActual.IDEspecialidad.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    PlanActual.DescripcionPlan = txtDescripcion.Text;
                    PlanActual.State = BusinessEntity.States.New;
                    ; break;

                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    PlanActual.DescripcionPlan = txtDescripcion.Text;
                    PlanActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtDescripcion.ReadOnly = true;
                    PlanActual.State = BusinessEntity.States.Deleted;
                    break;
            }

        }

        public override void MapearADatos()
        {
            PlanActual = new Plan();
            PlanActual.IDEspecialidad = Convert.ToInt32(txtEspecialidad.Text);
            switch (this.Modo)
            {
                case ModoForm.Baja:
                    PlanActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    PlanActual.State = Usuario.States.Unmodified;
                    break;
                case ModoForm.Alta:
                    PlanActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    PlanActual.State = Usuario.States.Modified;
                    break;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.PlanActual.DescripcionPlan = txtDescripcion.Text;
                if (Modo == ModoForm.Modificacion)
                {
                    this.PlanActual.ID = Convert.ToInt32(lblID.Text);
                }
            }
        }

        public override bool Validar()
        {
            bool valida = true;
            string mensaje = "";
            EspecialidadLogic elogic = new EspecialidadLogic();
            Especialidad e = new Especialidad();
            e = elogic.GetOne(Convert.ToInt32(txtEspecialidad.Text));
            if ( e.DescripcionEspecialidad == null || txtEspecialidad.Text.Length == 0)
            {
                valida = false;
                mensaje += "/nEspecialidad no existente";      
            }
            if (txtDescripcion.Text.Length == 0)
            {
                valida = false;
                mensaje += "/nDebe ingresar una descripcion de plan";
            }
            if (!valida)
            {
                MessageBox.Show(mensaje);
            }
            return valida;
        }

        public override void GuardarCambios()
        {
            if (Validar())
            {
                this.MapearADatos();
                switch (this.Modo)
                {
                    case ModoForm.Alta:
                        PlanActual.State = BusinessEntity.States.New;
                        break;
                    case ModoForm.Baja:
                        PlanActual.State = BusinessEntity.States.Deleted;
                        break;
                    case ModoForm.Modificacion:
                        PlanActual.State = BusinessEntity.States.Modified;
                        break;
                }
                plogic.Save(PlanActual);
                this.Close();
            }
        }





        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }


        private void PlanDesktop_Load(object sender, EventArgs e)
        {
        }

        private void cbEsp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
