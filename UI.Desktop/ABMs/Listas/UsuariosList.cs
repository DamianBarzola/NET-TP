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

namespace UI.Desktop
{
    public partial class UsuariosList : Form
    {
        private UsuarioLogic ul = new UsuarioLogic();

        public UsuariosList()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
        }

        public void Listar()
        {            
            this.dgvUsuarios.DataSource = ul.GetAll();
        }
        #region Botones simples
        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Botones opciones
        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PersonaSinUsuarioList personaSinUsuarioList = new PersonaSinUsuarioList();
            personaSinUsuarioList.ShowDialog();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("¿Está seguro de que desea eliminar el usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (confirm == DialogResult.Yes)
            {
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                try
                {
                    ul.Delete(ID);
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
        private void tsEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count != 0)
            {
                Usuario usuarioaux = new Usuario();
                int ID = ((Usuario)this.dgvUsuarios.SelectedRows[0].DataBoundItem).ID;
                usuarioaux = ul.GetOne(ID);
                UsuarioDesktop ud = new UsuarioDesktop(usuarioaux, ApplicationForm.ModoForm.Modificacion);
                ud.ShowDialog();
                Listar();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a editar");
            }
        }

        #endregion

        //no 

        private void tsOpciones_Click(object sender, EventArgs e) {   }


        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
