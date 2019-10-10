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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tsComision = new System.Windows.Forms.ToolStrip();
            this.dvgComision = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComision)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dvgComision);
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
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsComision);
            // 
            // tsComision
            // 
            this.tsComision.Dock = System.Windows.Forms.DockStyle.None;
            this.tsComision.Location = new System.Drawing.Point(3, 0);
            this.tsComision.Name = "tsComision";
            this.tsComision.Size = new System.Drawing.Size(111, 25);
            this.tsComision.TabIndex = 0;
            // 
            // dvgComision
            // 
            this.dvgComision.AllowUserToAddRows = false;
            this.dvgComision.AllowUserToDeleteRows = false;
            this.dvgComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.anio,
            this.plan});
            this.dvgComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgComision.Location = new System.Drawing.Point(0, 0);
            this.dvgComision.Name = "dvgComision";
            this.dvgComision.ReadOnly = true;
            this.dvgComision.Size = new System.Drawing.Size(800, 425);
            this.dvgComision.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // plan
            // 
            this.plan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.plan.DataPropertyName = "Plan";
            this.plan.HeaderText = "Plan";
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            this.plan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Comision";
            this.Text = "Comision";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip tsComision;
        private System.Windows.Forms.DataGridView dvgComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn plan;
    }
}