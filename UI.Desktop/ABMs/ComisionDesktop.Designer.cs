namespace UI.Desktop.ABMs
{
    partial class ComisionDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DescLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.DescLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbEsp, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbPlan, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudAnio, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(368, 173);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescLabel.Location = new System.Drawing.Point(14, 40);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(78, 25);
            this.DescLabel.TabIndex = 12;
            this.DescLabel.Text = "Descripcion";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Location = new System.Drawing.Point(14, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(78, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(14, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(109, 43);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(236, 20);
            this.txtDescripcion.TabIndex = 13;
            // 
            // cbEsp
            // 
            this.cbEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsp.FormattingEnabled = true;
            this.cbEsp.Location = new System.Drawing.Point(109, 93);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(115, 21);
            this.cbEsp.TabIndex = 18;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(230, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 24);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(11, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Año";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPlan
            // 
            this.cbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(230, 93);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(115, 21);
            this.cbPlan.TabIndex = 22;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(109, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(115, 25);
            this.labelID.TabIndex = 23;
            this.labelID.Text = "-";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAnio
            // 
            this.nudAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAnio.Location = new System.Drawing.Point(109, 68);
            this.nudAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(115, 20);
            this.nudAnio.TabIndex = 14;
            this.nudAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // ComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 173);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ComisionDesktop";
            this.Text = "ComisionDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbEsp;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.NumericUpDown nudAnio;
    }
}