namespace UI.Desktop
{
    partial class PlanDesktop
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.EspecialidadIDLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.especialidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(113, 43);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(182, 20);
            this.txtDescripcion.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.64557F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.8481F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EspecialidadIDLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DescLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEspecialidad, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 146);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Location = new System.Drawing.Point(12, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(86, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EspecialidadIDLabel
            // 
            this.EspecialidadIDLabel.AutoSize = true;
            this.EspecialidadIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EspecialidadIDLabel.Location = new System.Drawing.Point(12, 65);
            this.EspecialidadIDLabel.Name = "EspecialidadIDLabel";
            this.EspecialidadIDLabel.Size = new System.Drawing.Size(86, 25);
            this.EspecialidadIDLabel.TabIndex = 19;
            this.EspecialidadIDLabel.Text = "Especialidad";
            this.EspecialidadIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescLabel.Location = new System.Drawing.Point(12, 40);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(86, 25);
            this.DescLabel.TabIndex = 21;
            this.DescLabel.Text = "Descripcion";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(213, 108);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 24);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(113, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 25);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "lblID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(113, 68);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(94, 20);
            this.txtEspecialidad.TabIndex = 34;
            // 
            // PlanDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 146);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlanDesktop";
            this.Text = "PlanesDesktop";
            this.Load += new System.EventHandler(this.PlanDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label EspecialidadIDLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.BindingSource especialidadBindingSource;
        private System.Windows.Forms.TextBox txtEspecialidad;
    }
}