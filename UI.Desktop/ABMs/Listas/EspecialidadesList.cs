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
    public partial class EspecialidadesList : ApplicationForm
    {
        EspecialidadLogic eLogic = new EspecialidadLogic();
        public EspecialidadesList()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Listar
        public void Listar()
        {
            dgvEspecialidades.DataSource = null;
            dgvEspecialidades.Refresh();
         // EspecialidadLogic eLogic = new EspecialidadLogic();
            List<Especialidad> especialidades = eLogic.GetAll();
            if (especialidades.Count == 0)
            {
                MessageBox.Show("No hay especialidades cargadas!");
            }
            else
            {
                this.dgvEspecialidades.DataSource = especialidades;
            }
        }
        private void EspecialidadesList_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion

        #region Botones opciones
        private void tsNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            especialidadDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            especialidadDesktop.ShowDialog();
            this.Listar();
        }

       private void tsEliminar_Click(object sender, EventArgs e)
       {
            if (this.dgvEspecialidades.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
                EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
                especialidadDesktop.ShowDialog();
                this.Listar();
            }
       }
        #endregion


 
        
    }
}
