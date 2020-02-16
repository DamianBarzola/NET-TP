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
    public partial class MateriasList : Form
    {
        private MateriaLogic mLogic = new MateriaLogic();
        
        public MateriasList()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            dgvMaterias.DataSource = mLogic.GetAll();
        }

        #region botones opciones

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop materiaDesktop = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            materiaDesktop.ShowDialog();
            this.Listar();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                int ID = ((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                MateriaDesktop materiaDesktop = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                materiaDesktop.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a editar");
            }
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar la materia?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (confirm == DialogResult.Yes)
            {
                int ID = ((Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    mLogic.Delete(ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido eliminar el elemento ya que está referenciado por otro elemento", "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }
                finally
                {
                    Listar();
                }

            }
        }

            #endregion

        #region botones simples
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void MateriasList_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        #endregion

    } 

}
