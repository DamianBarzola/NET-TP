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
    public partial class ComisionDesktop : ApplicationForm
    {
        ModoForm modoform;
        Comision comisionActual;
        ComisionLogic cLogic = new ComisionLogic();

        #region Constructores
        public ComisionDesktop()
        {
            InitializeComponent();
        }
        //alta
        public ComisionDesktop(ModoForm modo)
        {
            InitializeComponent();
            modoform = modo;
            lblID.Visible = false;

        }

        //baja y modificacion
        public ComisionDesktop(int id, ModoForm modo)
        {
            InitializeComponent();
            lblID.Visible = true;
            comisionActual = cLogic.GetOne(id);
            MapearDeDatos();

        }

        #endregion

        #region Mapeos
        public override void MapearDeDatos()
        {
            lblID.Text = comisionActual.ID.ToString();
            txtanio.Text = comisionActual.AnioEspecialidad.ToString();
            txtid_materia.Text = comisionActual.IDMateria.ToString();
            txtid_profesor.Text = comisionActual.IdProfesor.ToString();

            switch (Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    comisionActual.State = BusinessEntity.States.New;
                    ; break;

                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    comisionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    comisionActual.State = BusinessEntity.States.Deleted;
                    break;
            }

        }

        public override void MapearADatos()
        {
            comisionActual = new Comision();
            switch (this.Modo)
            {
                case ModoForm.Baja:
                    comisionActual.State = Usuario.States.Deleted;
                    break;
                case ModoForm.Consulta:
                    comisionActual.State = Usuario.States.Unmodified;
                    break;
                case ModoForm.Alta:
                    comisionActual.State = Usuario.States.New;
                    break;
                case ModoForm.Modificacion:
                    comisionActual.State = Usuario.States.Modified;
                    break;
            }
            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                this.comisionActual.AnioEspecialidad = Convert.ToInt32(txtanio.Text) ;
                this.comisionActual.IDMateria = Convert.ToInt32(txtid_materia.Text);
                this.comisionActual.IdProfesor = Convert.ToInt32(txtid_materia.Text);
                if (Modo == ModoForm.Modificacion)
                {
                    this.comisionActual.ID = Convert.ToInt32(lblID.Text);
                }
            }
        }




        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
        }

        public override void GuardarCambios()
        {
            if (Validar())
            {
                this.MapearADatos();
                switch (this.modoform)
                {
                    case ModoForm.Alta:
                        comisionActual.State = BusinessEntity.States.New;
                        break;
                    case ModoForm.Baja:
                        comisionActual.State = BusinessEntity.States.Deleted;
                        break;
                    case ModoForm.Modificacion:
                        comisionActual.State = BusinessEntity.States.Modified;
                        break;
                }
                cLogic.Save(comisionActual);
                this.Close();
            }
        }

        public override bool Validar()
        {
            string mensaje = "";
            bool valid = true;
            MateriaLogic materiaLogic = new MateriaLogic();
            PersonaLogic personaLogic = new PersonaLogic();

            if (txtanio.Text.Length == 0){
                mensaje += "/n Debe ingresar un anio";
                valid = false;
            }
            else
            {
                try
                {
                    int.Parse(txtanio.Text);
                }
                catch (FormatException ef)
                {
                    valid = false;
                    mensaje += "\nEl anio debe ser un número entero.";
                }
            }
            if (materiaLogic.GetOne(Convert.ToInt32(txtid_materia.Text)) == null || txtid_materia.Text.Length == 0)
            {
                mensaje += "/n Debe ingresar una materia valida";
                valid = false;
            }

            if (txtid_profesor.Text.Length == 0)
            {
                mensaje += "/n Debe ingresar un profesor ";
                valid = false;
            }
                    else
                    {
                        if (personaLogic.GetOne(Convert.ToInt32(txtid_profesor.Text)) == null)
                        {
                            mensaje += "/n Debe ingresar una persona valida ";
                            valid = false;
                        }
                                else if (personaLogic.GetOne(Convert.ToInt32(txtid_profesor.Text)).Tipo != Persona.TipoPersona.Docente)
                                {
                                    mensaje += "/n Debe ingresar una persona que sea profesor ";
                                    valid = false;
                                }
                    }

            if (!valid)
            {
                MessageBox.Show(mensaje);
            }

            return valid;
        }
    }
}
