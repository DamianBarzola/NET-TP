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
    public partial class PlanesList : ApplicationForm
    {
        public PlanesList()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
        }




        public void Listar()
        {
            dgvPlanes.DataSource = null;
            dgvPlanes.Refresh();
            PlanLogic pLogic = new PlanLogic();
            List<Plan> planes = pLogic.GetAll();
            if (planes.Count == 0)
            {
                MessageBox.Show("No hay planes cargados!");
            }
            else
            {
                this.dgvPlanes.DataSource = planes;
            }
        }


        #region Botones basicos

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void PlanesList_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion

        #region botones opciones

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop planDesktop = new PlanDesktop(ModoForm.Alta);
            planDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop planDesktop = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            planDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
           if (this.dgvPlanes.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
                PlanDesktop plandEsktop = new PlanDesktop(ID, ApplicationForm.ModoForm.Baja);
                plandEsktop.ShowDialog();
                this.Listar();
            }
        }


        #endregion


    }
}
