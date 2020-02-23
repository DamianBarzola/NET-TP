namespace UI.Desktop
{
    partial class ComisionesProfesorForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lblIDProfesor = new System.Windows.Forms.Label();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSReporteDocentes = new UI.Desktop.DSReporteDocentes();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new UI.Desktop.DSReporteDocentesTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDProfesor
            // 
            this.lblIDProfesor.AutoSize = true;
            this.lblIDProfesor.Location = new System.Drawing.Point(26, 20);
            this.lblIDProfesor.Name = "lblIDProfesor";
            this.lblIDProfesor.Size = new System.Drawing.Size(100, 13);
            this.lblIDProfesor.TabIndex = 1;
            this.lblIDProfesor.Text = "Ingrese ID profesor:";
            // 
            // txtIDProfesor
            // 
            this.txtIDProfesor.Location = new System.Drawing.Point(174, 17);
            this.txtIDProfesor.Name = "txtIDProfesor";
            this.txtIDProfesor.Size = new System.Drawing.Size(100, 20);
            this.txtIDProfesor.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(307, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReporteDocentes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 59);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(709, 323);
            this.reportViewer1.TabIndex = 4;
            // 
            // DSReporteDocentes
            // 
            this.DSReporteDocentes.DataSetName = "DSReporteDocentes";
            this.DSReporteDocentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DSReporteDocentes;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ComisionesProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 405);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDProfesor);
            this.Controls.Add(this.lblIDProfesor);
            this.Name = "ComisionesProfesorForm";
            this.Text = "ComisionesProfesorForm";
            this.Load += new System.EventHandler(this.ComisionesProfesorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIDProfesor;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DSReporteDocentes DSReporteDocentes;
        private DSReporteDocentesTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}