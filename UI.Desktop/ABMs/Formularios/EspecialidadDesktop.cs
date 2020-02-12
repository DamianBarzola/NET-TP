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
using Util;

namespace UI.Desktop.ABMs
{
    public partial class EspecialidadDesktop : ApplicationForm
    {

        private Especialidad _EspecialidadActual;
        public Especialidad EspecActual { get => _EspecialidadActual; set => _EspecialidadActual = value; }

        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        //baja y modificacion
        public EspecialidadDesktop(int ID, ModoForm modo)
        {
            InitializeComponent();
            Modo = modo;
            EspecialidadLogic Espec = new EspecialidadLogic();
            EspecActual = Espec.GetOne(ID);
            MapearDeDatos();
            lblID.Visible = true;

        }

        //alta
        public EspecialidadDesktop(ModoForm modo)
        {
            Modo = modo;
            InitializeComponent();
            lblID.Visible = false;

        }
        //falta mapear a datos
        #region mapeos
        public override void MapearDeDatos()
        {
            lblID.Text = EspecActual.ID.ToString();
            txtDescripcion.Text = EspecActual.DescripcionEspecialidad;

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";

                    EspecActual.DescripcionEspecialidad = txtDescripcion.Text;
                    EspecActual.Habilitado = true;
                    EspecActual.State = BusinessEntity.States.New;
                    ;break;

                case ModoForm.Modificacion:          
                    btnAceptar.Text = "Guardar";
                    EspecActual.DescripcionEspecialidad = txtDescripcion.Text;
                    EspecActual.State = BusinessEntity.States.Modified;
                    
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtDescripcion.ReadOnly = true;
                    EspecActual.State = BusinessEntity.States.Deleted;
                    break;
            }

        }

        public override void MapearADatos()
        {
            EspecActual = new Especialidad();
            switch (this.Modo)
            {
                case ModoForm.Baja:
                    EspecActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    EspecActual.State = Usuario.States.Unmodified;
                    break;
                case ModoForm.Alta:
                    EspecActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    EspecActual.State = Usuario.States.Modified;
                    break;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.EspecActual.DescripcionEspecialidad = txtDescripcion.Text;
                if(Modo == ModoForm.Modificacion)
                {
                    this.EspecActual.ID = Convert.ToInt32(lblID.Text);
                }
            }
        }
        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValTexto(txtDescripcion.Text))
            {
                GuardarCambios();
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete todos los casilleros.");
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic auxEspecialidad = new EspecialidadLogic();
            auxEspecialidad.Save(EspecActual);
        }
    }
}
