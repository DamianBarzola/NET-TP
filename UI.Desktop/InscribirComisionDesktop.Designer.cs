namespace UI.Desktop
{
    partial class InscribirComisionDesktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbPersona = new System.Windows.Forms.ComboBox();
            this.cbComision = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Comision :";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(149, 147);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbPersona
            // 
            this.cbPersona.FormattingEnabled = true;
            this.cbPersona.Location = new System.Drawing.Point(124, 30);
            this.cbPersona.Name = "cbPersona";
            this.cbPersona.Size = new System.Drawing.Size(100, 21);
            this.cbPersona.TabIndex = 5;
            this.cbPersona.SelectedIndexChanged += new System.EventHandler(this.cbPersona_SelectedIndexChanged);
            // 
            // cbComision
            // 
            this.cbComision.FormattingEnabled = true;
            this.cbComision.Location = new System.Drawing.Point(124, 86);
            this.cbComision.Name = "cbComision";
            this.cbComision.Size = new System.Drawing.Size(100, 21);
            this.cbComision.TabIndex = 6;
            // 
            // InscribirComisionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 195);
            this.Controls.Add(this.cbComision);
            this.Controls.Add(this.cbPersona);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InscribirComisionDesktop";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbPersona;
        private System.Windows.Forms.ComboBox cbComision;
    }
}