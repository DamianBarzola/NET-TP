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
        public InscribirComisionDesktop(int id) : this()
        {
            PersonaLogic pl = new PersonaLogic();
            Persona personaAct = pl.GetOne(id);
            CargarComboPersona();
            CargarComboComision(personaAct.ID);
            switch (personaAct.Tipo)
            {
                case Persona.TipoPersona.Alumno:
                    cbPersona.SelectedValue = personaAct.ID;
                    cbPersona.Enabled = false;
                    break;

                case Persona.TipoPersona.Administrador:
                    cbPersona.Enabled = true;
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
            }
        }

        public override void MapearADatos()
        {
            al = new AlumnoInscripcion
            {
                IDAlumno = (int)cbPersona.SelectedValue,
                IDComision = (int)cbComision.SelectedValue
            };
        }

        public void CargarComboPersona()
        {
            cbPersona.ValueMember = "id_persona";
            cbPersona.DisplayMember = "apellido";
            cbPersona.DataSource = GenerarCombo.getAlumno();
        }
        public void CargarComboComision(int id)
        {
            cbComision.ValueMember = "id_comision";
            cbComision.DisplayMember = "id_materia";
            cbComision.DataSource = GenerarCombo.getComisiones(id);
        }
        private void cbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbPersona.SelectedValue;
            CargarComboComision(id);
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            alogic.Insert(al);
            this.Close();
        }

        public override bool Validar()
        {
            bool valid = true;
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


    }
}
