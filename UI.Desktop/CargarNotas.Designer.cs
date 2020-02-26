namespace UI.Desktop
{
    partial class CargaNotas
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelAlumno = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.nParcial1 = new System.Windows.Forms.NumericUpDown();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nParcial2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nParcial3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nNotaFinal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nParcial1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nParcial2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nParcial3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNotaFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(33, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(63, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID Comision";
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(33, 118);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(56, 13);
            this.labelAlumno.TabIndex = 1;
            this.labelAlumno.Text = "ID Alumno";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(196, 29);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(45, 13);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "Parcial1";
            // 
            // nParcial1
            // 
            this.nParcial1.Location = new System.Drawing.Point(261, 27);
            this.nParcial1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nParcial1.Name = "nParcial1";
            this.nParcial1.Size = new System.Drawing.Size(84, 20);
            this.nParcial1.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 201);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nParcial2
            // 
            this.nParcial2.Location = new System.Drawing.Point(261, 66);
            this.nParcial2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nParcial2.Name = "nParcial2";
            this.nParcial2.Size = new System.Drawing.Size(84, 20);
            this.nParcial2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Parcial2";
            // 
            // nParcial3
            // 
            this.nParcial3.Location = new System.Drawing.Point(261, 116);
            this.nParcial3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nParcial3.Name = "nParcial3";
            this.nParcial3.Size = new System.Drawing.Size(84, 20);
            this.nParcial3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parcial3";
            // 
            // nNotaFinal
            // 
            this.nNotaFinal.Location = new System.Drawing.Point(261, 153);
            this.nNotaFinal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNotaFinal.Name = "nNotaFinal";
            this.nNotaFinal.Size = new System.Drawing.Size(84, 20);
            this.nNotaFinal.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nota Final";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(108, 34);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(63, 13);
            this.lblComision.TabIndex = 17;
            this.lblComision.Text = "LblComision";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(108, 118);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(52, 13);
            this.lblAlumno.TabIndex = 18;
            this.lblAlumno.Text = "lblAlumno";
            // 
            // CargaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 237);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.nNotaFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nParcial3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nParcial2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.nParcial1);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.labelAlumno);
            this.Controls.Add(this.labelID);
            this.Name = "CargaNotas";
            this.Text = "CargarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.nParcial1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nParcial2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nParcial3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNotaFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.NumericUpDown nParcial1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nParcial2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nParcial3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nNotaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblAlumno;
    }
}