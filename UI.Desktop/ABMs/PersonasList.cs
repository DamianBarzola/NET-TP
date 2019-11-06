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

namespace UI.Desktop.ABMs
{
    public partial class PersonasList : Form
    {
        private PersonaLogic personas = new PersonaLogic();


        public PersonasList()
        {
            InitializeComponent();
            dgvPersonas.AutoGenerateColumns = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Listar()
        {
            this.dgvPersonas.DataSource = personas.GetAll();
        }


        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pd.ShowDialog();
            Listar();

        }
        private void tsEditar_Click(object sender, EventArgs e)
        {
            if(this.dgvPersonas.SelectedRows.Count != 0)
            {
                int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                PersonaDesktop pd = new PersonaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                pd.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a editar");
            }

        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar la persona?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (confirm == DialogResult.Yes)
            {
                int ID = ((Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    personas.Delete(ID);
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




        //click actualizar (no se xq carajo no se le cambia el nombre)
        private void button1_Click(object sender, EventArgs e)
        {
            Listar();
        }


        





        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonasList_Load(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
