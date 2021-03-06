﻿using System;
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
            dgvMaterias.DataSource = null;
            dgvMaterias.Refresh();
            List<Materia> materias = mLogic.GetAll();
            if (materias.Count == 0)
            {
                MessageBox.Show("No hay materias cargadas!");
            }
            else
            {

                this.dgvMaterias.DataSource = GenerarListas.GenerarMateria(materias);
            }
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
                int ID = (int)this.dgvMaterias.SelectedRows[0].Cells["id"].Value;
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
            if (this.dgvMaterias.SelectedRows.Count != 0)
            {
                int ID = (int)this.dgvMaterias.SelectedRows[0].Cells["id"].Value;
                MateriaDesktop materiaDesktop = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
                materiaDesktop.ShowDialog();
                this.Listar();
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
