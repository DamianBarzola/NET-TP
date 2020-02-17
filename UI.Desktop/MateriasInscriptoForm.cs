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
    public partial class MateriasInscriptoForm : Form
    {
        public MateriasInscriptoForm()
        {
            InitializeComponent();
        }

        private void MateriasInscriptoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Reporte.DataTable1' table. You can move, or remove it, as needed.
            int id = Convert.ToInt32(txtIDpersona.Text);
            this.DataTable1TableAdapter.Fill(this.Reporte.DataTable1, id);

            this.reportViewer1.RefreshReport();
        }
    }
}
