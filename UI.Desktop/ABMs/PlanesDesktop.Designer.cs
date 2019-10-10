namespace UI.Desktop.ABMs
{
    partial class PlanesDesktop
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IDLabel = new System.Windows.Forms.Label();
            this.EspecialidadIDLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(112, 43);
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.EspecialidadIDLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.DescLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbEsp, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 3, 1);
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
            this.IDLabel.Size = new System.Drawing.Size(85, 25);
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
            this.EspecialidadIDLabel.Size = new System.Drawing.Size(85, 25);
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
            this.DescLabel.Size = new System.Drawing.Size(85, 25);
            this.DescLabel.TabIndex = 21;
            this.DescLabel.Text = "Descripcion";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEsp
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cbEsp, 2);
            this.cbEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsp.FormattingEnabled = true;
            this.cbEsp.Location = new System.Drawing.Point(112, 68);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(182, 21);
            this.cbEsp.TabIndex = 22;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(206, 108);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 24);
            this.btnAceptar.TabIndex = 30;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(112, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 25);
            this.lblID.TabIndex = 33;
            this.lblID.Text = "lblID";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlanesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 146);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PlanesDesktop";
            this.Text = "PlanesDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label EspecialidadIDLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.ComboBox cbEsp;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblID;
    }
}