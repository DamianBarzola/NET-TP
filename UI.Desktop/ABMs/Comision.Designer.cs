namespace UI.Desktop.ABMs
{
    partial class Comision
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
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.tlComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.msComision = new System.Windows.Forms.MenuStrip();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.tlComisiones.SuspendLayout();
            this.msComision.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AllowUserToAddRows = false;
            this.dgvComisiones.AllowUserToDeleteRows = false;
            this.dgvComisiones.AllowUserToResizeColumns = false;
            this.dgvComisiones.AllowUserToResizeRows = false;
            this.dgvComisiones.BackgroundColor = System.Drawing.Color.White;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.anio,
            this.plan});
            this.tlComisiones.SetColumnSpan(this.dgvComisiones, 2);
            this.dgvComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisiones.Location = new System.Drawing.Point(3, 3);
            this.dgvComisiones.MultiSelect = false;
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersVisible = false;
            this.dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComisiones.Size = new System.Drawing.Size(794, 391);
            this.dgvComisiones.TabIndex = 0;
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
            // anio
            // 
            this.anio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.anio.DataPropertyName = "AnioEspecialidad";
            this.anio.HeaderText = "Año";
            this.anio.MinimumWidth = 65;
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.anio.Width = 65;
            // 
            // plan
            // 
            this.plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.plan.DataPropertyName = "Plan";
            this.plan.HeaderText = "Plan";
            this.plan.MinimumWidth = 65;
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            this.plan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.plan.Width = 65;
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlComisiones);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(800, 426);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(800, 450);
            this.tcUsuarios.TabIndex = 2;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.msComision);
            // 
            // tlComisiones
            // 
            this.tlComisiones.ColumnCount = 2;
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComisiones.Controls.Add(this.dgvComisiones, 0, 0);
            this.tlComisiones.Controls.Add(this.btnSalir, 1, 1);
            this.tlComisiones.Controls.Add(this.btnActualizar, 0, 1);
            this.tlComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlComisiones.Name = "tlComisiones";
            this.tlComisiones.RowCount = 2;
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComisiones.Size = new System.Drawing.Size(800, 426);
            this.tlComisiones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 400);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 400);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // msComision
            // 
            this.msComision.Dock = System.Windows.Forms.DockStyle.None;
            this.msComision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpciones});
            this.msComision.Location = new System.Drawing.Point(0, 0);
            this.msComision.Name = "msComision";
            this.msComision.Size = new System.Drawing.Size(800, 24);
            this.msComision.TabIndex = 1;
            this.msComision.Text = "menuStrip1";
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
            this.tsEditar.Size = new System.Drawing.Size(117, 22);
            this.tsEditar.Text = "Editar";
            // 
            // tsNuevo
            // 
            this.tsNuevo.Name = "tsNuevo";
            this.tsNuevo.Size = new System.Drawing.Size(117, 22);
            this.tsNuevo.Text = "Nuevo";
            // 
            // tsEliminar
            // 
            this.tsEliminar.Name = "tsEliminar";
            this.tsEliminar.Size = new System.Drawing.Size(117, 22);
            this.tsEliminar.Text = "Eliminar";
            // 
            // Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "Comision";
            this.Text = "Comision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.tlComisiones.ResumeLayout(false);
            this.msComision.ResumeLayout(false);
            this.msComision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.TableLayoutPanel tlComisiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.MenuStrip msComision;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}