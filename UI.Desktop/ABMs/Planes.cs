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

namespace UI.Desktop.ABMs
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count != 0)
            {
                int ID = (int)this.dgvPlanes.SelectedRows[0].Cells["id"].Value;
                PlanesDesktop planDesktop = new PlanesDesktop(ID, ApplicationForm.ModoForm.Baja);
                planDesktop.ShowDialog();
                this.Listar();
            }
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count != 0)
            {
                int ID = (int)this.dgvPlanes.SelectedRows[0].Cells["id"].Value;
                PlanesDesktop planDesktop = new PlanesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                planDesktop.ShowDialog();
                this.Listar();
            }
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PlanesDesktop planDesktop = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
            planDesktop.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            this.dgvPlanes.DataSource = null;
            this.dgvPlanes.Refresh();

            PlanLogic pl = new PlanLogic();
            List<Plan> planes = pl.GetAll().Where(x => x.Habilitado == true).ToList();
            if (planes.Count() == 0)
            {
                MessageBox.Show("No hay planes");
            }
            else
            {
                this.dgvPlanes.DataSource = Lista(planes);
            }
        }

        private static EspecialidadLogic _EspLogic;
        private static EspecialidadLogic EspLogic
        {
            get
            {
                if (_EspLogic == null) _EspLogic = new EspecialidadLogic(); return _EspLogic;
            }
        }

        public static DataTable Lista(List<Plan> planes)
        {
            DataTable Listado = new DataTable();
            Listado.Columns.Add("ID", typeof(int));
            Listado.Columns.Add("Descripcion", typeof(string));
            Listado.Columns.Add("Especialidad", typeof(string));

            List<Especialidad> especialidades = EspLogic.GetAll();

            foreach (Plan plan in planes)
            {
                DataRow Linea = Listado.NewRow();

                Linea["ID"] = plan.ID;
                Linea["Descripcion"] = plan.DescripcionPlan;

                Especialidad esp = especialidades.FirstOrDefault(x => x.ID == plan.IDEspecialidad);
                Linea["Especialidad"] = esp.DescripcionEspecialidad;

                Listado.Rows.Add(Linea);
            }
            return Listado;
        }
    }
    }
