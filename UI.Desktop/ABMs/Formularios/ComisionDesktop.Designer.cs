namespace UI.Desktop
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblid_materia = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid_materia = new System.Windows.Forms.TextBox();
            this.txtanio = new System.Windows.Forms.TextBox();
            this.txtid_profesor = new System.Windows.Forms.TextBox();
            this.lblanio = new System.Windows.Forms.Label();
            this.lblId_profesor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.IDLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblid_materia, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtid_materia, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtanio, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtid_profesor, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblanio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblId_profesor, 1, 4);
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
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(230, 133);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(115, 24);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblid_materia
            // 
            this.lblid_materia.AutoSize = true;
            this.lblid_materia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblid_materia.Location = new System.Drawing.Point(11, 65);
            this.lblid_materia.Margin = new System.Windows.Forms.Padding(0);
            this.lblid_materia.Name = "lblid_materia";
            this.lblid_materia.Size = new System.Drawing.Size(84, 25);
            this.lblid_materia.TabIndex = 16;
            this.lblid_materia.Text = "ID Materia";
            this.lblid_materia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(109, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(115, 25);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "-";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtid_materia
            // 
            this.txtid_materia.Location = new System.Drawing.Point(109, 68);
            this.txtid_materia.Name = "txtid_materia";
            this.txtid_materia.Size = new System.Drawing.Size(115, 20);
            this.txtid_materia.TabIndex = 24;
            // 
            // txtanio
            // 
            this.txtanio.Location = new System.Drawing.Point(109, 43);
            this.txtanio.Name = "txtanio";
            this.txtanio.Size = new System.Drawing.Size(115, 20);
            this.txtanio.TabIndex = 25;
            // 
            // txtid_profesor
            // 
            this.txtid_profesor.Location = new System.Drawing.Point(109, 93);
            this.txtid_profesor.Name = "txtid_profesor";
            this.txtid_profesor.Size = new System.Drawing.Size(115, 20);
            this.txtid_profesor.TabIndex = 26;
            // 
            // lblanio
            // 
            this.lblanio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblanio.AutoSize = true;
            this.lblanio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblanio.Location = new System.Drawing.Point(11, 40);
            this.lblanio.Margin = new System.Windows.Forms.Padding(0);
            this.lblanio.Name = "lblanio";
            this.lblanio.Size = new System.Drawing.Size(84, 25);
            this.lblanio.TabIndex = 27;
            this.lblanio.Text = "Anio";
            this.lblanio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblId_profesor
            // 
            this.lblId_profesor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblId_profesor.AutoSize = true;
            this.lblId_profesor.Location = new System.Drawing.Point(14, 90);
            this.lblId_profesor.Name = "lblId_profesor";
            this.lblId_profesor.Size = new System.Drawing.Size(78, 25);
            this.lblId_profesor.TabIndex = 28;
            this.lblId_profesor.Text = "ID Profesor";
            this.lblId_profesor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblid_materia;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtid_materia;
        private System.Windows.Forms.TextBox txtanio;
        private System.Windows.Forms.TextBox txtid_profesor;
        private System.Windows.Forms.Label lblanio;
        private System.Windows.Forms.Label lblId_profesor;
    }
}