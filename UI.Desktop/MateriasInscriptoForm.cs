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
    public partial class MateriasInscriptoForm : Form
    {
        public MateriasInscriptoForm()
        {
            InitializeComponent();
            lblIngrese.Visible = false;
            txtIDpersona.Visible = false;
            btnBuscar.Visible = false;
            
        }

        public MateriasInscriptoForm(int id) : this()
        {

            PersonaLogic pLogic = new PersonaLogic();
            Persona per = pLogic.GetOne(id);
            switch (per.Tipo)
            {
                case Persona.TipoPersona.Alumno:
                    this.DataTable1TableAdapter.Fill(this.Reporte.DataTable1, id);
                    this.reportViewer1.RefreshReport();
                    break;
                case Persona.TipoPersona.Administrador:
                    lblIngrese.Visible = true;
                    txtIDpersona.Visible = true;
                    btnBuscar.Visible = true;
                    break;

            }

        }

        private void MateriasInscriptoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDpersona.Text);
            this.DataTable1TableAdapter.Fill(this.Reporte.DataTable1, ID);
            this.reportViewer1.RefreshReport();
        }
    }
}
