namespace UI.Desktop
{
    partial class PersonaSinUsuarioList
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
            this.dvgPersonasSinUsuario = new System.Windows.Forms.DataGridView();
            this.lblElijaPersona = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.id_persona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonasSinUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgPersonasSinUsuario
            // 
            this.dvgPersonasSinUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dvgPersonasSinUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPersonasSinUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_persona,
            this.nombre,
            this.apellido});
            this.dvgPersonasSinUsuario.Location = new System.Drawing.Point(16, 31);
            this.dvgPersonasSinUsuario.Name = "dvgPersonasSinUsuario";
            this.dvgPersonasSinUsuario.Size = new System.Drawing.Size(345, 250);
            this.dvgPersonasSinUsuario.TabIndex = 0;
            // 
            // lblElijaPersona
            // 
            this.lblElijaPersona.AutoSize = true;
            this.lblElijaPersona.Location = new System.Drawing.Point(13, 12);
            this.lblElijaPersona.Name = "lblElijaPersona";
            this.lblElijaPersona.Size = new System.Drawing.Size(223, 13);
            this.lblElijaPersona.TabIndex = 1;
            this.lblElijaPersona.Text = "Elija una persona a la que agregar un usuario:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(302, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(211, 287);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // id_persona
            // 
            this.id_persona.HeaderText = "ID";
            this.id_persona.Name = "id_persona";
            this.id_persona.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // PersonaSinUsuarioList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 322);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblElijaPersona);
            this.Controls.Add(this.dvgPersonasSinUsuario);
            this.Name = "PersonaSinUsuarioList";
            this.Text = "PersonaSinUsuarioList";
            ((System.ComponentModel.ISupportInitialize)(this.dvgPersonasSinUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgPersonasSinUsuario;
        private System.Windows.Forms.Label lblElijaPersona;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_persona;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}