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
        public MateriaDesktop(ModoForm modo)
        {
            InitializeComponent();
            this.modoform = modo;
            labelID.Visible = false;
        }
        //baja y modif
        public MateriaDesktop(int id, ModoForm modo)
        {
            InitializeComponent();
            this.modoform = modo;
            labelID.Visible = true;
            materiaActual = mlogic.GetOne(id);
            MapearDeDatos();

        }



        #endregion

        #region Mapeos
        override public void MapearADatos()
        {
            materiaActual = new Materia();
            switch (this.modoform)
            {
                case ModoForm.Baja:
                    materiaActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    materiaActual.State = Usuario.States.Unmodified;
                    break;
                case ModoForm.Alta:
                    materiaActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    materiaActual.State = Usuario.States.Modified;
                    break;
            }
            if (modoform == ModoForm.Alta || modoform == ModoForm.Modificacion)
            {
                if (_Modo == ModoForm.Modificacion)
                {
                    materiaActual.ID = Convert.ToInt32(this.labelID.Text);
                }
                materiaActual.Descripcion = this.txtDescripcion.Text;
                materiaActual.IDPlan = Convert.ToInt32(this.txtIDPlan.Text);
            }

        }

        public override void MapearDeDatos()
        {
            
            txtIDPlan.Text = materiaActual.IDPlan.ToString();
            txtDescripcion.Text = materiaActual.Descripcion;

            if (modoform == ModoForm.Modificacion || modoform == ModoForm.Baja)
            {
                labelID.Text = materiaActual.ID.ToString();
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
            PlanLogic plogic = new PlanLogic();
            Plan p = new Plan();
            p = plogic.GetOne(Convert.ToInt32(txtIDPlan.Text));
            if ( p.DescripcionPlan == null || txtIDPlan.Text.Length == 0)
            {
                valid = false;
                mensaje += "/Plan no existente";
            }
            if (txtDescripcion.Text.Length == 0)
            {
                valid = false;
                mensaje += "/nDebe ingresar una descripcion de plan";
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
    }
}
