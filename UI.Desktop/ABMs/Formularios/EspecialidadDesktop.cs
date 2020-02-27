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

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {

        private Especialidad _EspecialidadActual;
        public Especialidad EspecActual { get => _EspecialidadActual; set => _EspecialidadActual = value; }

        #region constructores
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
        #endregion

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
            switch (this.Modo)
            {
                case ModoForm.Baja:
                    EspecActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Alta:
                    EspecActual = new Especialidad()
                    {
                        DescripcionEspecialidad = txtDescripcion.Text
                    };
                    EspecActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    EspecActual.DescripcionEspecialidad = txtDescripcion.Text;
                    EspecActual.ID = Convert.ToInt32(lblID.Text);
                    EspecActual.State = Usuario.States.Modified;
                    break;
            }

        }
        #endregion
        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";
            if (Validaciones.ValTexto(txtDescripcion.Text))
            {
                valid = false;
                mensaje += "Debe ingresar una descripcion";
            }
            if (!valid)
            {
                MessageBox.Show(mensaje);
            }
            return valid;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
                GuardarCambios();
                this.Close();
        }
        public override void GuardarCambios()
        {
            if (Validar())
            {
                try
                {
                    MapearADatos();
                    EspecialidadLogic auxEspecialidad = new EspecialidadLogic();
                    auxEspecialidad.Save(EspecActual);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error modificando la especialidad");
                }
            }

        }
    }
}
