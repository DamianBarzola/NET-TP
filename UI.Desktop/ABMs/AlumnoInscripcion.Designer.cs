﻿namespace UI.Desktop.ABMs
{
    partial class AlumnoInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoInscripcion));
            this.dgvAlumnoInscripciones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAlumnoInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tlAlumnoInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tsAlumnoInscripciones = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).BeginInit();
            this.tcAlumnoInscripciones.ContentPanel.SuspendLayout();
            this.tcAlumnoInscripciones.TopToolStripPanel.SuspendLayout();
            this.tcAlumnoInscripciones.SuspendLayout();
            this.tlAlumnoInscripciones.SuspendLayout();
            this.tsAlumnoInscripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlumnoInscripciones
            // 
            this.dgvAlumnoInscripciones.AllowUserToAddRows = false;
            this.dgvAlumnoInscripciones.AllowUserToDeleteRows = false;
            this.dgvAlumnoInscripciones.AllowUserToResizeRows = false;
            this.dgvAlumnoInscripciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnoInscripciones.ColumnHeadersHeight = 21;
            this.dgvAlumnoInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAlumnoInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.alumno,
            this.id_curso,
            this.nota,
            this.condicion});
            this.tlAlumnoInscripciones.SetColumnSpan(this.dgvAlumnoInscripciones, 2);
            this.dgvAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnoInscripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnoInscripciones.MultiSelect = false;
            this.dgvAlumnoInscripciones.Name = "dgvAlumnoInscripciones";
            this.dgvAlumnoInscripciones.ReadOnly = true;
            this.dgvAlumnoInscripciones.RowHeadersVisible = false;
            this.dgvAlumnoInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoInscripciones.Size = new System.Drawing.Size(794, 390);
            this.dgvAlumnoInscripciones.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID Inscripcion";
            this.id.MinimumWidth = 100;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // alumno
            // 
            this.alumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alumno.DataPropertyName = "Alumno";
            this.alumno.HeaderText = "Alumno";
            this.alumno.MinimumWidth = 130;
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            // 
            // id_curso
            // 
            this.id_curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_curso.DataPropertyName = "Curso";
            this.id_curso.HeaderText = "Curso";
            this.id_curso.MinimumWidth = 130;
            this.id_curso.Name = "id_curso";
            this.id_curso.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.MinimumWidth = 50;
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            this.nota.Width = 50;
            // 
            // condicion
            // 
            this.condicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.condicion.DataPropertyName = "Condicion";
            this.condicion.HeaderText = "Condicion";
            this.condicion.MinimumWidth = 100;
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // tcAlumnoInscripciones
            // 
            // 
            // tcAlumnoInscripciones.ContentPanel
            // 
            this.tcAlumnoInscripciones.ContentPanel.Controls.Add(this.tlAlumnoInscripciones);
            this.tcAlumnoInscripciones.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlumnoInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tcAlumnoInscripciones.Name = "tcAlumnoInscripciones";
            this.tcAlumnoInscripciones.Size = new System.Drawing.Size(800, 450);
            this.tcAlumnoInscripciones.TabIndex = 4;
            this.tcAlumnoInscripciones.Text = "toolStripContainer1";
            // 
            // tcAlumnoInscripciones.TopToolStripPanel
            // 
            this.tcAlumnoInscripciones.TopToolStripPanel.Controls.Add(this.tsAlumnoInscripciones);
            // 
            // tlAlumnoInscripciones
            // 
            this.tlAlumnoInscripciones.ColumnCount = 2;
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnoInscripciones.Controls.Add(this.dgvAlumnoInscripciones, 0, 0);
            this.tlAlumnoInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlAlumnoInscripciones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnoInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlAlumnoInscripciones.Name = "tlAlumnoInscripciones";
            this.tlAlumnoInscripciones.RowCount = 2;
            this.tlAlumnoInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnoInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlumnoInscripciones.Size = new System.Drawing.Size(800, 425);
            this.tlAlumnoInscripciones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // tsAlumnoInscripciones
            // 
            this.tsAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlumnoInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.tsAlumnoInscripciones.Location = new System.Drawing.Point(3, 0);
            this.tsAlumnoInscripciones.Name = "tsAlumnoInscripciones";
            this.tsAlumnoInscripciones.Size = new System.Drawing.Size(58, 25);
            this.tsAlumnoInscripciones.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // AlumnoInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAlumnoInscripciones);
            this.Name = "AlumnoInscripcion";
            this.Text = "AlumnoInscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).EndInit();
            this.tcAlumnoInscripciones.ContentPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.PerformLayout();
            this.tcAlumnoInscripciones.ResumeLayout(false);
            this.tcAlumnoInscripciones.PerformLayout();
            this.tlAlumnoInscripciones.ResumeLayout(false);
            this.tsAlumnoInscripciones.ResumeLayout(false);
            this.tsAlumnoInscripciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnoInscripciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.TableLayoutPanel tlAlumnoInscripciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripContainer tcAlumnoInscripciones;
        private System.Windows.Forms.ToolStrip tsAlumnoInscripciones;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}