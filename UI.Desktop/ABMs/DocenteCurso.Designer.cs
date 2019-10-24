namespace UI.Desktop.ABMs
{
    partial class DocenteCurso
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
            this.dgvDocenteCurso = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAlumnoInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tlAlumnoInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.msDocenteCurso = new System.Windows.Forms.MenuStrip();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).BeginInit();
            this.tcAlumnoInscripciones.ContentPanel.SuspendLayout();
            this.tcAlumnoInscripciones.TopToolStripPanel.SuspendLayout();
            this.tcAlumnoInscripciones.SuspendLayout();
            this.tlAlumnoInscripciones.SuspendLayout();
            this.msDocenteCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDocenteCurso
            // 
            this.dgvDocenteCurso.AllowUserToAddRows = false;
            this.dgvDocenteCurso.AllowUserToDeleteRows = false;
            this.dgvDocenteCurso.AllowUserToResizeRows = false;
            this.dgvDocenteCurso.BackgroundColor = System.Drawing.Color.White;
            this.dgvDocenteCurso.ColumnHeadersHeight = 21;
            this.dgvDocenteCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDocenteCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Curso,
            this.Docente,
            this.Cargo});
            this.tlAlumnoInscripciones.SetColumnSpan(this.dgvDocenteCurso, 2);
            this.dgvDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocenteCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvDocenteCurso.MultiSelect = false;
            this.dgvDocenteCurso.Name = "dgvDocenteCurso";
            this.dgvDocenteCurso.ReadOnly = true;
            this.dgvDocenteCurso.RowHeadersVisible = false;
            this.dgvDocenteCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocenteCurso.Size = new System.Drawing.Size(794, 391);
            this.dgvDocenteCurso.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID Dictado";
            this.id.MinimumWidth = 100;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Curso
            // 
            this.Curso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Curso.DataPropertyName = "Curso";
            this.Curso.HeaderText = "Curso";
            this.Curso.MinimumWidth = 130;
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Docente
            // 
            this.Docente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Docente.DataPropertyName = "Docente";
            this.Docente.HeaderText = "Docente";
            this.Docente.MinimumWidth = 130;
            this.Docente.Name = "Docente";
            this.Docente.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.DataPropertyName = "Cargo";
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 50;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            this.Cargo.Width = 50;
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
            this.tcAlumnoInscripciones.TopToolStripPanel.Controls.Add(this.msDocenteCurso);
            // 
            // tlAlumnoInscripciones
            // 
            this.tlAlumnoInscripciones.ColumnCount = 2;
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnoInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnoInscripciones.Controls.Add(this.dgvDocenteCurso, 0, 0);
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
            // msDocenteCurso
            // 
            this.msDocenteCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.msDocenteCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpciones});
            this.msDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.msDocenteCurso.Name = "msDocenteCurso";
            this.msDocenteCurso.Size = new System.Drawing.Size(800, 24);
            this.msDocenteCurso.TabIndex = 1;
            this.msDocenteCurso.Text = "menuStrip1";
            // 
            // tsOpciones
            // 
            this.tsOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNuevo,
            this.tsEliminar});
            this.tsOpciones.Name = "tsOpciones";
            this.tsOpciones.Size = new System.Drawing.Size(69, 20);
            this.tsOpciones.Text = "Opciones";
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
            // DocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAlumnoInscripciones);
            this.Name = "DocenteCurso";
            this.Text = "DocenteCurso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).EndInit();
            this.tcAlumnoInscripciones.ContentPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tcAlumnoInscripciones.TopToolStripPanel.PerformLayout();
            this.tcAlumnoInscripciones.ResumeLayout(false);
            this.tcAlumnoInscripciones.PerformLayout();
            this.tlAlumnoInscripciones.ResumeLayout(false);
            this.msDocenteCurso.ResumeLayout(false);
            this.msDocenteCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocenteCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.TableLayoutPanel tlAlumnoInscripciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripContainer tcAlumnoInscripciones;
        private System.Windows.Forms.MenuStrip msDocenteCurso;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}