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
    public partial class IngresarAlumnoParaNotas : ApplicationForm
    {
        Comision_AlumnoLogic caLogic = new Comision_AlumnoLogic();
        Comision_Alumno comal = new Comision_Alumno();

        public IngresarAlumnoParaNotas()
        {
            InitializeComponent();
        }

        public override void MapearADatos()
        {
            comal.ID = Convert.ToInt32(txtIdComision.Text);
            comal.IDPersona = Convert.ToInt32(txtIdAlumno.Text);
        }
        
        public override bool Validar()
        {
            bool valid = true;
            string mensaje = "";

            if (!Validaciones.ValTexto(txtIdAlumno.Text))
            {
                valid = false;
                mensaje += "/n debe ingresar id alumno";

            }
            else
            {
                try
                {
                    int.Parse(txtIdAlumno.Text);
                }
                catch (FormatException ef)
                {
                    valid = false;
                    mensaje += "\nEl id debe ser un número entero.";
                }
            }

            if (!Validaciones.ValTexto(txtIdComision.Text))
            {
                valid = false;
                mensaje += "debe ingresar id comision";
            }
            else
            {
                try
                {
                    int.Parse(txtIdComision.Text);
                }
                catch (FormatException ef)
                {
                    valid = false;
                    mensaje += "\nEl id debe ser un número entero.";
                }
            }
            if (!valid)
            {
                MessageBox.Show(mensaje);
            }
            return valid;
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                MapearADatos();
                Comision_Alumno cAux = new Comision_Alumno();
                cAux = caLogic.GetOne(comal.IDPersona, comal.ID);
                if(cAux.IDPersona == comal.IDPersona && cAux.ID == comal.ID)
                {
                    CargaNotas cn = new CargaNotas(cAux);
                    cn.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No existe esa inscripcion de ese alumno para esa comision");
                }
            }

        }
    }
}
