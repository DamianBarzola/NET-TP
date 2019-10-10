namespace UI.Desktop.ABMs
{
    partial class MateriaDesktop
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.PlanIDLabel = new System.Windows.Forms.Label();
            this.HSSemanalesLabel = new System.Windows.Forms.Label();
            this.HSTotalesLabel = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.nudHSSem = new System.Windows.Forms.NumericUpDown();
            this.nudHSTot = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSSem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSTot)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Location = new System.Drawing.Point(13, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(75, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescLabel.Location = new System.Drawing.Point(13, 40);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(75, 25);
            this.DescLabel.TabIndex = 21;
            this.DescLabel.Text = "Descripcion";
            this.DescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescripcion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescripcion, 2);
            this.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescripcion.Location = new System.Drawing.Point(104, 43);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(226, 20);
            this.txtDescripcion.TabIndex = 16;
            // 
            // PlanIDLabel
            // 
            this.PlanIDLabel.AutoSize = true;
            this.PlanIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlanIDLabel.Location = new System.Drawing.Point(13, 115);
            this.PlanIDLabel.Name = "PlanIDLabel";
            this.PlanIDLabel.Size = new System.Drawing.Size(75, 25);
            this.PlanIDLabel.TabIndex = 19;
            this.PlanIDLabel.Text = "Plan";
            this.PlanIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HSSemanalesLabel
            // 
            this.HSSemanalesLabel.AutoSize = true;
            this.HSSemanalesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSSemanalesLabel.Location = new System.Drawing.Point(13, 65);
            this.HSSemanalesLabel.Name = "HSSemanalesLabel";
            this.HSSemanalesLabel.Size = new System.Drawing.Size(75, 25);
            this.HSSemanalesLabel.TabIndex = 23;
            this.HSSemanalesLabel.Text = "Hs Semanales";
            this.HSSemanalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HSTotalesLabel
            // 
            this.HSTotalesLabel.AutoSize = true;
            this.HSTotalesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSTotalesLabel.Location = new System.Drawing.Point(13, 90);
            this.HSTotalesLabel.Name = "HSTotalesLabel";
            this.HSTotalesLabel.Size = new System.Drawing.Size(75, 25);
            this.HSTotalesLabel.TabIndex = 24;
            this.HSTotalesLabel.Text = "Hs Totales";
            this.HSTotalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(220, 158);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 24);
            this.btnAceptar.TabIndex = 31;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(104, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(110, 25);
            this.labelID.TabIndex = 27;
            this.labelID.Text = " -";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPlan
            // 
            this.cbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(220, 118);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(110, 21);
            this.cbPlan.TabIndex = 20;
            // 
            // cbEsp
            // 
            this.cbEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsp.FormattingEnabled = true;
            this.cbEsp.Location = new System.Drawing.Point(104, 118);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(110, 21);
            this.cbEsp.TabIndex = 19;
            // 
            // nudHSSem
            // 
            this.nudHSSem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHSSem.Location = new System.Drawing.Point(104, 68);
            this.nudHSSem.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHSSem.Name = "nudHSSem";
            this.nudHSSem.Size = new System.Drawing.Size(110, 20);
            this.nudHSSem.TabIndex = 17;
            // 
            // nudHSTot
            // 
            this.nudHSTot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudHSTot.Location = new System.Drawing.Point(104, 93);
            this.nudHSTot.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHSTot.Name = "nudHSTot";
            this.nudHSTot.Size = new System.Drawing.Size(110, 20);
            this.nudHSTot.TabIndex = 18;
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
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DescLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.PlanIDLabel, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.HSSemanalesLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.HSTotalesLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbPlan, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbEsp, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.nudHSSem, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudHSTot, 3, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 201);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 201);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            ((System.ComponentModel.ISupportInitialize)(this.nudHSSem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHSTot)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label PlanIDLabel;
        private System.Windows.Forms.Label HSSemanalesLabel;
        private System.Windows.Forms.Label HSTotalesLabel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.ComboBox cbEsp;
        private System.Windows.Forms.NumericUpDown nudHSSem;
        private System.Windows.Forms.NumericUpDown nudHSTot;
    }
}