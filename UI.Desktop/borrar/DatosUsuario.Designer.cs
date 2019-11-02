namespace UI.Desktop
{
    partial class DatosUsuario
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
            this.LabelBienvenido = new System.Windows.Forms.Label();
            this.labelLegajo = new System.Windows.Forms.Label();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.btnCambiarPass = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbFechaNacimiento = new System.Windows.Forms.TextBox();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIabms = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIusuario = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIespecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIplanes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMImaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIcomisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIcursos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIinscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIdocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIMisCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIMisInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMImateriasInscripto = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIinscribirseACursado = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelBienvenido
            // 
            this.LabelBienvenido.AutoSize = true;
            this.LabelBienvenido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBienvenido.Location = new System.Drawing.Point(93, 34);
            this.LabelBienvenido.Name = "LabelBienvenido";
            this.LabelBienvenido.Size = new System.Drawing.Size(177, 19);
            this.LabelBienvenido.TabIndex = 4;
            this.LabelBienvenido.Text = "Bienvenido @Nombre";
            this.LabelBienvenido.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLegajo
            // 
            this.labelLegajo.AutoSize = true;
            this.labelLegajo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLegajo.Location = new System.Drawing.Point(335, 34);
            this.labelLegajo.Name = "labelLegajo";
            this.labelLegajo.Size = new System.Drawing.Size(127, 19);
            this.labelLegajo.TabIndex = 5;
            this.labelLegajo.Text = "Legajo @legajo";
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.btnCambiarPass);
            this.gb1.Controls.Add(this.btnSalir);
            this.gb1.Controls.Add(this.btnGuardar);
            this.gb1.Controls.Add(this.tbEmail);
            this.gb1.Controls.Add(this.tbTelefono);
            this.gb1.Controls.Add(this.tbDireccion);
            this.gb1.Controls.Add(this.tbFechaNacimiento);
            this.gb1.Controls.Add(this.tbUsuario);
            this.gb1.Controls.Add(this.tbApellido);
            this.gb1.Controls.Add(this.tbNombre);
            this.gb1.Controls.Add(this.label9);
            this.gb1.Controls.Add(this.label8);
            this.gb1.Controls.Add(this.label7);
            this.gb1.Controls.Add(this.label6);
            this.gb1.Controls.Add(this.label5);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Location = new System.Drawing.Point(12, 99);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(545, 349);
            this.gb1.TabIndex = 6;
            this.gb1.TabStop = false;
            this.gb1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCambiarPass
            // 
            this.btnCambiarPass.Location = new System.Drawing.Point(30, 307);
            this.btnCambiarPass.Name = "btnCambiarPass";
            this.btnCambiarPass.Size = new System.Drawing.Size(133, 23);
            this.btnCambiarPass.TabIndex = 17;
            this.btnCambiarPass.Text = "Cambiar contraseña";
            this.btnCambiarPass.UseVisualStyleBackColor = true;
            this.btnCambiarPass.Click += new System.EventHandler(this.btnCambiarPass_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(451, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(356, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(211, 270);
            this.tbEmail.MaxLength = 30;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(114, 20);
            this.tbEmail.TabIndex = 14;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(211, 232);
            this.tbTelefono.MaxLength = 30;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(114, 20);
            this.tbTelefono.TabIndex = 13;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(211, 199);
            this.tbDireccion.MaxLength = 30;
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(114, 20);
            this.tbDireccion.TabIndex = 12;
            // 
            // tbFechaNacimiento
            // 
            this.tbFechaNacimiento.Enabled = false;
            this.tbFechaNacimiento.Location = new System.Drawing.Point(211, 122);
            this.tbFechaNacimiento.Name = "tbFechaNacimiento";
            this.tbFechaNacimiento.Size = new System.Drawing.Size(114, 20);
            this.tbFechaNacimiento.TabIndex = 11;
            // 
            // tbUsuario
            // 
            this.tbUsuario.Enabled = false;
            this.tbUsuario.Location = new System.Drawing.Point(211, 84);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(114, 20);
            this.tbUsuario.TabIndex = 10;
            // 
            // tbApellido
            // 
            this.tbApellido.Enabled = false;
            this.tbApellido.Location = new System.Drawing.Point(211, 46);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(114, 20);
            this.tbApellido.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Enabled = false;
            this.tbNombre.Location = new System.Drawing.Point(211, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(114, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Usted puede modificar los siguientes datos";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datos Usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIabms,
            this.TSMIMisCursos,
            this.TSMIMisInscripciones,
            this.TSMIreportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(594, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIabms
            // 
            this.TSMIabms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIusuario,
            this.TSMIespecialidades,
            this.TSMIplanes,
            this.TSMImaterias,
            this.TSMIcomisiones,
            this.TSMIcursos,
            this.TSMIinscripciones,
            this.TSMIdocentes,
            this.personasToolStripMenuItem});
            this.TSMIabms.Name = "TSMIabms";
            this.TSMIabms.Size = new System.Drawing.Size(50, 20);
            this.TSMIabms.Text = "ABMs";
            // 
            // TSMIusuario
            // 
            this.TSMIusuario.Name = "TSMIusuario";
            this.TSMIusuario.Size = new System.Drawing.Size(194, 22);
            this.TSMIusuario.Text = "Usuarios";
            // 
            // TSMIespecialidades
            // 
            this.TSMIespecialidades.Name = "TSMIespecialidades";
            this.TSMIespecialidades.Size = new System.Drawing.Size(194, 22);
            this.TSMIespecialidades.Text = "Especialidades";
            // 
            // TSMIplanes
            // 
            this.TSMIplanes.Name = "TSMIplanes";
            this.TSMIplanes.Size = new System.Drawing.Size(194, 22);
            this.TSMIplanes.Text = "Planes";
            // 
            // TSMImaterias
            // 
            this.TSMImaterias.Name = "TSMImaterias";
            this.TSMImaterias.Size = new System.Drawing.Size(194, 22);
            this.TSMImaterias.Text = "Materias";
            // 
            // TSMIcomisiones
            // 
            this.TSMIcomisiones.Name = "TSMIcomisiones";
            this.TSMIcomisiones.Size = new System.Drawing.Size(194, 22);
            this.TSMIcomisiones.Text = "Comisiones";
            // 
            // TSMIcursos
            // 
            this.TSMIcursos.Name = "TSMIcursos";
            this.TSMIcursos.Size = new System.Drawing.Size(194, 22);
            this.TSMIcursos.Text = "Cursos";
            // 
            // TSMIinscripciones
            // 
            this.TSMIinscripciones.Name = "TSMIinscripciones";
            this.TSMIinscripciones.Size = new System.Drawing.Size(194, 22);
            this.TSMIinscripciones.Text = "Inscripciones Alumnos";
            // 
            // TSMIdocentes
            // 
            this.TSMIdocentes.Name = "TSMIdocentes";
            this.TSMIdocentes.Size = new System.Drawing.Size(194, 22);
            this.TSMIdocentes.Text = "Docentes - Cursos";
            // 
            // TSMIMisCursos
            // 
            this.TSMIMisCursos.Name = "TSMIMisCursos";
            this.TSMIMisCursos.Size = new System.Drawing.Size(55, 20);
            this.TSMIMisCursos.Text = "Cursos";
            // 
            // TSMIMisInscripciones
            // 
            this.TSMIMisInscripciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMImateriasInscripto,
            this.TSMIinscribirseACursado});
            this.TSMIMisInscripciones.Name = "TSMIMisInscripciones";
            this.TSMIMisInscripciones.Size = new System.Drawing.Size(64, 20);
            this.TSMIMisInscripciones.Text = "Materias";
            // 
            // TSMImateriasInscripto
            // 
            this.TSMImateriasInscripto.Name = "TSMImateriasInscripto";
            this.TSMImateriasInscripto.Size = new System.Drawing.Size(181, 22);
            this.TSMImateriasInscripto.Text = "Materias inscripto";
            // 
            // TSMIinscribirseACursado
            // 
            this.TSMIinscribirseACursado.Name = "TSMIinscribirseACursado";
            this.TSMIinscribirseACursado.Size = new System.Drawing.Size(181, 22);
            this.TSMIinscribirseACursado.Text = "Inscribirse a cursado";
            // 
            // TSMIreportes
            // 
            this.TSMIreportes.Name = "TSMIreportes";
            this.TSMIreportes.Size = new System.Drawing.Size(65, 20);
            this.TSMIreportes.Text = "Reportes";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 460);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.LabelBienvenido);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelBienvenido;
        private System.Windows.Forms.Label labelLegajo;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCambiarPass;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbFechaNacimiento;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIabms;
        private System.Windows.Forms.ToolStripMenuItem TSMIusuario;
        private System.Windows.Forms.ToolStripMenuItem TSMIespecialidades;
        private System.Windows.Forms.ToolStripMenuItem TSMIplanes;
        private System.Windows.Forms.ToolStripMenuItem TSMImaterias;
        private System.Windows.Forms.ToolStripMenuItem TSMIcomisiones;
        private System.Windows.Forms.ToolStripMenuItem TSMIcursos;
        private System.Windows.Forms.ToolStripMenuItem TSMIinscripciones;
        private System.Windows.Forms.ToolStripMenuItem TSMIdocentes;
        private System.Windows.Forms.ToolStripMenuItem TSMIMisCursos;
        private System.Windows.Forms.ToolStripMenuItem TSMIMisInscripciones;
        private System.Windows.Forms.ToolStripMenuItem TSMImateriasInscripto;
        private System.Windows.Forms.ToolStripMenuItem TSMIinscribirseACursado;
        private System.Windows.Forms.ToolStripMenuItem TSMIreportes;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
    }
}