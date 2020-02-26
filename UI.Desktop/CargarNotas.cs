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
    public partial class CargaNotas : ApplicationForm
    {
        Comision_Alumno comal;
        Comision_Alumno comalNueva = new Comision_Alumno();

        public CargaNotas()
        {
            InitializeComponent();
        }
        public CargaNotas(Comision_Alumno com) : this()
        {
            comal = com;
            MapearDeDatos();
        }


        public override void MapearADatos()
        {
            comalNueva.ID = Convert.ToInt32(lblComision.Text);
            comalNueva.IDPersona = Convert.ToInt32(lblAlumno.Text);
            comalNueva.NotaFinal = Convert.ToInt32(nNotaFinal.Value);
            comalNueva.Parcial1 = Convert.ToInt32(nParcial1.Value);
            comalNueva.Parcial2 = Convert.ToInt32(nParcial2.Value);
            comalNueva.Parcial3 = Convert.ToInt32(nParcial3.Value);
        }

        public override void MapearDeDatos()
        {
            lblComision.Text = comal.ID.ToString();
            lblAlumno.Text = comal.IDPersona.ToString();
            nParcial1.Value = comal.Parcial1;
            nParcial2.Value = comal.Parcial2;
            nParcial3.Value = comal.Parcial3;
            nNotaFinal.Value = comal.NotaFinal;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MapearADatos();
            Comision_AlumnoLogic caLogic = new Comision_AlumnoLogic();
            caLogic.Update(comalNueva);
            MessageBox.Show("Modificado.");
        }
    }
}
