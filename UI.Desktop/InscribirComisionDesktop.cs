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
    public partial class InscribirComisionDesktop : ApplicationForm
    {
        //Comision_Alumno comision_alumno;
        //Comision_AlumnoLogic calLogic = new Comision_AlumnoLogic();

        AlumnoInscripcion al ;
        AlumnoInscripcionLogic alogic = new AlumnoInscripcionLogic();

        public InscribirComisionDesktop()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        public override void MapearADatos()
        {
            al = new AlumnoInscripcion();
            al.IDAlumno = Convert.ToInt32(txtIDPersona.Text);
            al.IDComision = Convert.ToInt32(txtIDComision.Text);
        }

        public override bool Validar()
        {
            bool valid= true;
            /*string mensaje = "";
            Comision com = new Comision();
            ComisionLogic cLogic = new ComisionLogic();
            com = cLogic.GetOne(Convert.ToInt32(txtIDComision));
            if (com.ID !=)
            //{

            }

            if (!valid)
            {
                MessageBox.Show(mensaje);
            }*/

            return valid;
        }

        public override void GuardarCambios()
        {
            if (Validar())
            {
                this.MapearADatos();
                alogic.Insert(al);
                this.Close();
            }
        }




    }
}
