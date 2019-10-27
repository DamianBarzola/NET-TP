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
            Modo = modo;
            EspecialidadLogic Espec = new EspecialidadLogic();
            EspecActual = Espec.GetOne(ID);
            MapearDeDatos();
        }

        //alta
        public EspecialidadDesktop(ModoForm modo)
        {
            Modo = modo;
        }

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
