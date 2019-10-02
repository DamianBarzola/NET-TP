namespace UI.Desktop
{
    partial class CargarNotas
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
            this.labelLegajo = new System.Windows.Forms.Label();
            this.labelCond = new System.Windows.Forms.Label();
            this.labelNota = new System.Windows.Forms.Label();
            this.nNota = new System.Windows.Forms.NumericUpDown();
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.lblLeg = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(57, 34);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
          
            // 
            // labelAlumno
            // 
            this.labelAlumno.AutoSize = true;
            this.labelAlumno.Location = new System.Drawing.Point(33, 64);
            this.labelAlumno.Name = "labelAlumno";
            this.labelAlumno.Size = new System.Drawing.Size(42, 13);
            this.labelAlumno.TabIndex = 1;
            this.labelAlumno.Text = "Alumno";
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Location = new System.Drawing.Point(36, 88);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(39, 13);
            this.labelLegajo.TabIndex = 2;
            this.labelLegajo.Text = "Legajo";
            // 
            // labelCond
            // 
            this.labelCond.AutoSize = true;
            this.labelCond.Location = new System.Drawing.Point(24, 120);
            this.labelCond.Name = "labelCond";
            this.labelCond.Size = new System.Drawing.Size(54, 13);
            this.labelCond.TabIndex = 3;
            this.labelCond.Text = "Condicion";
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(48, 155);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(30, 13);
            this.labelNota.TabIndex = 4;
            this.labelNota.Text = "Nota";
            // 
            // nNota
            // 
            this.nNota.Location = new System.Drawing.Point(84, 153);
            this.nNota.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nNota.Name = "nNota";
            this.nNota.Size = new System.Drawing.Size(120, 20);
            this.nNota.TabIndex = 5;
            // 
            // cbCondicion
            // 
            this.cbCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Location = new System.Drawing.Point(85, 117);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(121, 21);
            this.cbCondicion.TabIndex = 6;
            // 
            // lblLeg
            // 
            this.lblLeg.AutoSize = true;
            this.lblLeg.Location = new System.Drawing.Point(81, 88);
            this.lblLeg.Name = "lblLeg";
            this.lblLeg.Size = new System.Drawing.Size(39, 13);
            this.lblLeg.TabIndex = 7;
            this.lblLeg.Text = "Legajo";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(81, 64);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(52, 13);
            this.lblAlumno.TabIndex = 8;
            this.lblAlumno.Text = "lblAlumno";
           
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(81, 34);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(28, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "lblID";
           
            // 
            // CargarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 199);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblLeg);
            this.Controls.Add(this.cbCondicion);
            this.Controls.Add(this.nNota);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.labelCond);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.labelAlumno);
            this.Controls.Add(this.labelID);
            this.Name = "CargarNotas";
            this.Text = "CargarNotas";
            ((System.ComponentModel.ISupportInitialize)(this.nNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAlumno;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.Label labelCond;
        private System.Windows.Forms.Label labelNota;
        private System.Windows.Forms.NumericUpDown nNota;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Label lblLeg;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblID;
    }
}