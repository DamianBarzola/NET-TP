namespace UI.Desktop.ABMs
{
    partial class Personas
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tlUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcUsuarios = new System.Windows.Forms.ToolStripContainer();
            this.msPersonas = new System.Windows.Forms.MenuStrip();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tcUsuarios.ContentPanel.SuspendLayout();
            this.tcUsuarios.TopToolStripPanel.SuspendLayout();
            this.tcUsuarios.SuspendLayout();
            this.msPersonas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(706, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(625, 273);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // tlUsuario
            // 
            this.tlUsuario.ColumnCount = 2;
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuario.Controls.Add(this.dgvUsuarios, 0, 0);
            this.tlUsuario.Controls.Add(this.btnSalir, 1, 1);
            this.tlUsuario.Controls.Add(this.btnActualizar, 0, 1);
            this.tlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlUsuario.Name = "tlUsuario";
            this.tlUsuario.RowCount = 2;
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuario.Size = new System.Drawing.Size(784, 299);
            this.tlUsuario.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_persona,
            this.legajo,
            this.nombre,
            this.apellido,
            this.fecha_nac,
            this.tipo_persona,
            this.direccion,
            this.email,
            this.telefono,
            this.plan});
            this.tlUsuario.SetColumnSpan(this.dgvUsuarios, 2);
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(778, 264);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // id_persona
            // 
            this.id_persona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_persona.DataPropertyName = "ID";
            this.id_persona.HeaderText = "ID";
            this.id_persona.MinimumWidth = 35;
            this.id_persona.Name = "id_persona";
            this.id_persona.ReadOnly = true;
            this.id_persona.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id_persona.Width = 35;
            // 
            // legajo
            // 
            this.legajo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.MinimumWidth = 45;
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            this.legajo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.legajo.Width = 45;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 70;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 70;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 70;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 70;
            // 
            // fecha_nac
            // 
            this.fecha_nac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.fecha_nac.DataPropertyName = "FechaNac";
            this.fecha_nac.HeaderText = "Fecha Nac";
            this.fecha_nac.MinimumWidth = 70;
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.ReadOnly = true;
            // 
            // tipo_persona
            // 
            this.tipo_persona.DataPropertyName = "Tipo_Persona";
            this.tipo_persona.HeaderText = "Tipo de Persona";
            this.tipo_persona.Name = "tipo_persona";
            this.tipo_persona.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 70;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 70;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 120;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 70;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // plan
            // 
            this.plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.plan.DataPropertyName = "Plan";
            this.plan.HeaderText = "Plan";
            this.plan.MinimumWidth = 40;
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            // 
            // tcUsuarios
            // 
            // 
            // tcUsuarios.ContentPanel
            // 
            this.tcUsuarios.ContentPanel.Controls.Add(this.tlUsuario);
            this.tcUsuarios.ContentPanel.Size = new System.Drawing.Size(784, 299);
            this.tcUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.Size = new System.Drawing.Size(784, 323);
            this.tcUsuarios.TabIndex = 1;
            this.tcUsuarios.Text = "toolStripContainer1";
            // 
            // tcUsuarios.TopToolStripPanel
            // 
            this.tcUsuarios.TopToolStripPanel.Controls.Add(this.msPersonas);
            // 
            // msPersonas
            // 
            this.msPersonas.Dock = System.Windows.Forms.DockStyle.None;
            this.msPersonas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpciones});
            this.msPersonas.Location = new System.Drawing.Point(0, 0);
            this.msPersonas.Name = "msPersonas";
            this.msPersonas.Size = new System.Drawing.Size(784, 24);
            this.msPersonas.TabIndex = 1;
            this.msPersonas.Text = "menuStrip1";
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
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 323);
            this.Controls.Add(this.tcUsuarios);
            this.Name = "Personas";
            this.Text = "Personas";
            this.tlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tcUsuarios.ContentPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.ResumeLayout(false);
            this.tcUsuarios.TopToolStripPanel.PerformLayout();
            this.tcUsuarios.ResumeLayout(false);
            this.tcUsuarios.PerformLayout();
            this.msPersonas.ResumeLayout(false);
            this.msPersonas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TableLayoutPanel tlUsuario;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nac;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.ToolStripContainer tcUsuarios;
        private System.Windows.Forms.MenuStrip msPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem tsEditar;
        private System.Windows.Forms.ToolStripMenuItem tsNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsEliminar;
    }
}