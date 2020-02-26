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
    public partial class ComisionesList : ApplicationForm
    {
        ComisionLogic cLogic = new ComisionLogic();

        public ComisionesList()
        {
            InitializeComponent();
            dgvComisiones.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            dgvComisiones.DataSource = null;
            dgvComisiones.Refresh();
            List<Comision> comisiones = cLogic.GetAll();
            if (comisiones.Count == 0)
            {
                MessageBox.Show("No hay comisiones cargadas!");
            }
            else
            {
                this.dgvComisiones.DataSource = GenerarListas.GenerarComision(comisiones);
            }
        }

        #region botones simples y listar


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void ComisionesList_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        #endregion

        #region Botones opciones
        private void tsNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop comisionDesktop = new ComisionDesktop(ModoForm.Alta);
            comisionDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            int ID = (int)this.dgvComisiones.SelectedRows[0].Cells["id"].Value;
            ComisionDesktop comisionDesktop = new ComisionDesktop(ID, ModoForm.Modificacion);
            comisionDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvComisiones.SelectedRows.Count != 0)
            {
                DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar la comision?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (confirm == DialogResult.Yes)
                {
                    int ID = (int)this.dgvComisiones.SelectedRows[0].Cells["id"].Value;
                    try
                    {
                        cLogic.Delete(ID);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se ha podido eliminar el elemento", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    }
                    finally
                    {
                        Listar();
                    }
                }
            }
        }
        #endregion
    }
}
