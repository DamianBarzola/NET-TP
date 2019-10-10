namespace UI.Desktop.ABMs
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tsCursos = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio_calendario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tsCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvCursos);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsCursos);
            // 
            // tsCursos
            // 
            this.tsCursos.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCursos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tsCursos.Location = new System.Drawing.Point(3, 0);
            this.tsCursos.Name = "tsCursos";
            this.tsCursos.Size = new System.Drawing.Size(81, 25);
            this.tsCursos.TabIndex = 0;
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
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.plan,
            this.anio_calendario,
            this.id_comision,
            this.id_materia,
            this.cupo});
            this.dgvCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCursos.Location = new System.Drawing.Point(0, 0);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.Size = new System.Drawing.Size(800, 425);
            this.dgvCursos.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "ID";
            this.id.Frozen = true;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plan
            // 
            this.plan.DataPropertyName = "Plan";
            this.plan.Frozen = true;
            this.plan.HeaderText = "Plan";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            // 
            // anio_calendario
            // 
            this.anio_calendario.DataPropertyName = "AnioCalendario";
            this.anio_calendario.Frozen = true;
            this.anio_calendario.HeaderText = "Año";
            this.anio_calendario.Name = "anio_calendario";
            this.anio_calendario.ReadOnly = true;
            // 
            // id_comision
            // 
            this.id_comision.DataPropertyName = "Comision";
            this.id_comision.Frozen = true;
            this.id_comision.HeaderText = "Comision";
            this.id_comision.Name = "id_comision";
            this.id_comision.ReadOnly = true;
            // 
            // id_materia
            // 
            this.id_materia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_materia.DataPropertyName = "Materia";
            this.id_materia.HeaderText = "Materia";
            this.id_materia.Name = "id_materia";
            this.id_materia.ReadOnly = true;
            // 
            // cupo
            // 
            this.cupo.DataPropertyName = "Cupo";
            this.cupo.HeaderText = "Cupo";
            this.cupo.Name = "cupo";
            this.cupo.ReadOnly = true;
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tsCursos.ResumeLayout(false);
            this.tsCursos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio_calendario;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupo;
        private System.Windows.Forms.ToolStrip tsCursos;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}