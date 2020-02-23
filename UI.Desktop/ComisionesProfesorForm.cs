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
    public partial class ComisionesProfesorForm : Form
    {
        public ComisionesProfesorForm()
        {
            InitializeComponent();
            lblIDProfesor.Visible = false;
            txtIDProfesor.Visible = false;
            btnBuscar.Visible = false;
        }

        public ComisionesProfesorForm(int id) : this()
        {
            PersonaLogic pLogic = new PersonaLogic();
            Persona per = pLogic.GetOne(id);
            switch (per.Tipo)
            {
                case Persona.TipoPersona.Alumno:
                    this.DataTable1TableAdapter.Fill(this.Reporte.DataTable1, id);
                    this.rvDocentes.RefreshReport();
                    break;
                case Persona.TipoPersona.Administrador:
                    lblIDProfesor.Visible = true;
                    txtIDProfesor.Visible = true;
                    btnBuscar.Visible = true;
                    break;

            }
        }


        private void ComisionesProfesorForm_Load(object sender, EventArgs e)
        {
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtIDProfesor.Text);
            this.DataTable1TableAdapter.Fill(this.Reporte.DataTable1, ID);
            this.rvDocentes.RefreshReport();
        }
    }
}
