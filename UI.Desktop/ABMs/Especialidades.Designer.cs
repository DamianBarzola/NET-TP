namespace UI.Desktop.ABMs
{
    partial class Especialidades
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
            this.dgvEspecialidades = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.msEspecialidades = new System.Windows.Forms.MenuStrip();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).BeginInit();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tlEspecialidades.SuspendLayout();
            this.msEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEspecialidades
            // 
            this.dgvEspecialidades.AllowUserToAddRows = false;
            this.dgvEspecialidades.AllowUserToDeleteRows = false;
            this.dgvEspecialidades.AllowUserToResizeColumns = false;
            this.dgvEspecialidades.AllowUserToResizeRows = false;
            this.dgvEspecialidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEspecialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion});
            this.tlEspecialidades.SetColumnSpan(this.dgvEspecialidades, 2);
            this.dgvEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEspecialidades.Location = new System.Drawing.Point(3, 3);
            this.dgvEspecialidades.MultiSelect = false;
            this.dgvEspecialidades.Name = "dgvEspecialidades";
            this.dgvEspecialidades.ReadOnly = true;
            this.dgvEspecialidades.RowHeadersVisible = false;
            this.dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEspecialidades.Size = new System.Drawing.Size(712, 168);
            this.dgvEspecialidades.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 65;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 65;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlEspecialidades);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(718, 203);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(718, 227);
            this.tcUsuarios.TabIndex = 2;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.msEspecialidades);
            // 
            // tlEspecialidades
            // 
            this.tlEspecialidades.ColumnCount = 2;
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlEspecialidades.Controls.Add(this.dgvEspecialidades, 0, 0);
            this.tlEspecialidades.Controls.Add(this.btnActualizar, 0, 1);
            this.tlEspecialidades.Controls.Add(this.btnSalir, 1, 1);
            this.tlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.tlEspecialidades.Name = "tlEspecialidades";
            this.tlEspecialidades.RowCount = 2;
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlEspecialidades.Size = new System.Drawing.Size(718, 203);
            this.tlEspecialidades.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(559, 177);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(640, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // msEspecialidades
            // 
            this.msEspecialidades.Dock = System.Windows.Forms.DockStyle.None;
            this.msEspecialidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpciones});
            this.msEspecialidades.Location = new System.Drawing.Point(0, 0);
            this.msEspecialidades.Name = "msEspecialidades";
            this.msEspecialidades.Size = new System.Drawing.Size(718, 24);
            this.msEspecialidades.TabIndex = 1;
            this.msEspecialidades.Text = "menuStrip1";
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
            this.tsEditar.Click += new System.EventHandler(this.tsEditar_Click);
            // 
            // tsNuevo
            // 
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsNuevo.Text = "Nuevo";
            this.tsNuevo.Click += new System.EventHandler(this.tsNuevo_Click);
            // 
            // tsEliminar
            // 
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsEliminar.Text = "Eliminar";
            this.tsEliminar.Click += new System.EventHandler(this.tsEliminar_Click);
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 227);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEspecialidades)).EndInit();
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tlEspecialidades.ResumeLayout(false);
            this.msEspecialidades.ResumeLayout(false);
            this.msEspecialidades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.TableLayoutPanel tlEspecialidades;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.MenuStrip msEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}