namespace UI.Desktop
{
    partial class MisInscripciones
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
            this.msMisInscrip = new System.Windows.Forms.MenuStrip();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).BeginInit();
            this.tcAlumnoInscripciones.ContentPanel.SuspendLayout();
            this.tcAlumnoInscripciones.TopToolStripPanel.SuspendLayout();
            this.tcAlumnoInscripciones.SuspendLayout();
            this.tlAlumnoInscripciones.SuspendLayout();
            this.msMisInscrip.SuspendLayout();
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
            this.dgvAlumnoInscripciones.Size = new System.Drawing.Size(794, 391);
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
            this.tcAlumnoInscripciones.ContentPanel.Size = new System.Drawing.Size(800, 426);
            this.tcAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAlumnoInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tcAlumnoInscripciones.Name = "tcAlumnoInscripciones";
            this.tcAlumnoInscripciones.Size = new System.Drawing.Size(800, 450);
            this.tcAlumnoInscripciones.TabIndex = 4;
            this.tcAlumnoInscripciones.Text = "toolStripContainer1";
            // 
            // tcAlumnoInscripciones.TopToolStripPanel
            // 
            this.tcAlumnoInscripciones.TopToolStripPanel.Controls.Add(this.msMisInscrip);
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
            this.tlAlumnoInscripciones.Size = new System.Drawing.Size(800, 426);
            this.tlAlumnoInscripciones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 400);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // msMisInscrip
            // 
            this.msMisInscrip.Dock = System.Windows.Forms.DockStyle.None;
            this.msMisInscrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpciones});
            this.msMisInscrip.Location = new System.Drawing.Point(0, 0);
            this.msMisInscrip.Name = "msMisInscrip";
            this.msMisInscrip.Size = new System.Drawing.Size(800, 24);
            this.msMisInscrip.TabIndex = 0;
            this.msMisInscrip.Text = "menuStrip1";
            // 
            // tsOpciones
            // 
            this.tsOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEditar,
            this.tsNuevo,
            this.tsEliminar});
            this.tsOpciones.Name = "tsOpciones";
            this.tsOpciones.Size = new System.Drawing.Size(69, 20);
            this.tsOpciones.Text = "Opciones";
            // 
            // tsEditar
            // 
            this.tsEditar.Name = "tsEditar";
            this.tsEditar.Size = new System.Drawing.Size(180, 22);
            this.tsEditar.Text = "Editar";
            // 
            // tsNuevo
            // 
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsNuevo.Text = "Nuevo";
            // 
            // tsEliminar
            // 
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsEliminar.Text = "Eliminar";
            // 
            // MisInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAlumnoInscripciones);
            this.MainMenuStrip = this.msMisInscrip;
            this.Name = "MisInscripciones";
            this.Text = "MisInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).EndInit();
            this.tcAlumnoInscripciones.ContentPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.PerformLayout();
            this.tcAlumnoInscripciones.ResumeLayout(false);
            this.tcAlumnoInscripciones.PerformLayout();
            this.tlAlumnoInscripciones.ResumeLayout(false);
            this.msMisInscrip.ResumeLayout(false);
            this.msMisInscrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip msMisInscrip;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}