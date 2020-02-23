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
            this.rvDocentes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblIDProfesor = new System.Windows.Forms.Label();
            this.txtIDProfesor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Reporte = new UI.Desktop.Reporte();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new UI.Desktop.ReporteTableAdapters.DataTable1TableAdapter();
            this.DSReporteDocentes = new UI.Desktop.DSReporteDocentes();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // rvDocentes
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.rvDocentes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvDocentes.LocalReport.ReportEmbeddedResource = "UI.Desktop.ReporteDocentes.rdlc";
            this.rvDocentes.Location = new System.Drawing.Point(12, 53);
            this.rvDocentes.Name = "rvDocentes";
            this.rvDocentes.ServerReport.BearerToken = null;
            this.rvDocentes.Size = new System.Drawing.Size(710, 327);
            this.rvDocentes.TabIndex = 0;
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
            // Reporte
            // 
            this.Reporte.DataSetName = "Reporte";
            this.Reporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Reporte;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DSReporteDocentes
            // 
            this.DSReporteDocentes.DataSetName = "DSReporteDocentes";
            this.DSReporteDocentes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ComisionesProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 405);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDProfesor);
            this.Controls.Add(this.lblIDProfesor);
            this.Controls.Add(this.rvDocentes);
            this.Name = "ComisionesProfesorForm";
            this.Text = "ComisionesProfesorForm";
            this.Load += new System.EventHandler(this.ComisionesProfesorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteDocentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvDocentes;
        private System.Windows.Forms.Label lblIDProfesor;
        private System.Windows.Forms.TextBox txtIDProfesor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Reporte Reporte;
        private ReporteTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private DSReporteDocentes DSReporteDocentes;
    }
}