﻿namespace UI.Desktop.ABMs
{
    partial class CursosDesktop
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
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.AnioLabel = new System.Windows.Forms.Label();
            this.CupoLabel = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.MateriaIDLabel = new System.Windows.Forms.Label();
            this.ComisionIDLabel = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.Plan = new System.Windows.Forms.Label();
            this.cbEsp = new System.Windows.Forms.ComboBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.nudCupo = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbComision
            // 
            this.cbComision.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbComision.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cbComision, 2);
            this.cbComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(86, 133);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(188, 21);
            this.cbComision.TabIndex = 5;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDLabel.Location = new System.Drawing.Point(11, 15);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(61, 25);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "ID";
            this.IDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AnioLabel
            // 
            this.AnioLabel.AutoSize = true;
            this.AnioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnioLabel.Location = new System.Drawing.Point(11, 65);
            this.AnioLabel.Name = "AnioLabel";
            this.AnioLabel.Size = new System.Drawing.Size(61, 25);
            this.AnioLabel.TabIndex = 23;
            this.AnioLabel.Text = "Año";
            this.AnioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CupoLabel
            // 
            this.CupoLabel.AutoSize = true;
            this.CupoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CupoLabel.Location = new System.Drawing.Point(11, 40);
            this.CupoLabel.Name = "CupoLabel";
            this.CupoLabel.Size = new System.Drawing.Size(61, 25);
            this.CupoLabel.TabIndex = 24;
            this.CupoLabel.Text = "Cupo";
            this.CupoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbMateria
            // 
            this.cbMateria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMateria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cbMateria, 2);
            this.cbMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(86, 158);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(188, 21);
            this.cbMateria.TabIndex = 6;
            // 
            // MateriaIDLabel
            // 
            this.MateriaIDLabel.AutoSize = true;
            this.MateriaIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MateriaIDLabel.Location = new System.Drawing.Point(11, 155);
            this.MateriaIDLabel.Name = "MateriaIDLabel";
            this.MateriaIDLabel.Size = new System.Drawing.Size(61, 25);
            this.MateriaIDLabel.TabIndex = 19;
            this.MateriaIDLabel.Text = "Materia";
            this.MateriaIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComisionIDLabel
            // 
            this.ComisionIDLabel.AutoSize = true;
            this.ComisionIDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComisionIDLabel.Location = new System.Drawing.Point(11, 130);
            this.ComisionIDLabel.Name = "ComisionIDLabel";
            this.ComisionIDLabel.Size = new System.Drawing.Size(61, 25);
            this.ComisionIDLabel.TabIndex = 27;
            this.ComisionIDLabel.Text = "Comisión";
            this.ComisionIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(86, 15);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(91, 25);
            this.labelID.TabIndex = 29;
            this.labelID.Text = " -";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Plan
            // 
            this.Plan.AutoSize = true;
            this.Plan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plan.Location = new System.Drawing.Point(11, 105);
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(61, 25);
            this.Plan.TabIndex = 30;
            this.Plan.Text = "Plan";
            this.Plan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbEsp
            // 
            this.cbEsp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbEsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEsp.FormattingEnabled = true;
            this.cbEsp.Location = new System.Drawing.Point(86, 108);
            this.cbEsp.Name = "cbEsp";
            this.cbEsp.Size = new System.Drawing.Size(91, 21);
            this.cbEsp.TabIndex = 3;
            // 
            // cbPlan
            // 
            this.cbPlan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(183, 108);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(91, 21);
            this.cbPlan.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(183, 198);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 24);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // nudAnio
            // 
            this.nudAnio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAnio.Location = new System.Drawing.Point(86, 68);
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
            this.nudAnio.Size = new System.Drawing.Size(91, 20);
            this.nudAnio.TabIndex = 2;
            this.nudAnio.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // nudCupo
            // 
            this.nudCupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudCupo.Location = new System.Drawing.Point(86, 43);
            this.nudCupo.Name = "nudCupo";
            this.nudCupo.Size = new System.Drawing.Size(91, 20);
            this.nudCupo.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.cbComision, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AnioLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CupoLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbMateria, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.MateriaIDLabel, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ComisionIDLabel, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Plan, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbEsp, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbPlan, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 9);
            this.tableLayoutPanel1.Controls.Add(this.nudAnio, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudCupo, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(295, 237);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CursosDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CursosDesktop";
            this.Text = "CursosDesktop";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCupo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label AnioLabel;
        private System.Windows.Forms.Label CupoLabel;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label MateriaIDLabel;
        private System.Windows.Forms.Label ComisionIDLabel;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label Plan;
        private System.Windows.Forms.ComboBox cbEsp;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.NumericUpDown nudCupo;
    }
}