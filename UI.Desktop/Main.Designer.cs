namespace UI.Desktop
{
    partial class Main
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnsPrincipal.SuspendLayout();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(594, 24);
            this.mnsPrincipal.TabIndex = 2;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadToolStripMenuItem,
            this.planToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.inscripcionesAlumnosToolStripMenuItem});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(50, 20);
            this.mnuArchivo.Text = "ABMs";
            // 
            // especialidadToolStripMenuItem
            // 
            this.especialidadToolStripMenuItem.Name = "especialidadToolStripMenuItem";
            this.especialidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.especialidadToolStripMenuItem.Text = "Especialidades";
            this.especialidadToolStripMenuItem.Click += new System.EventHandler(this.especialidadToolStripMenuItem_Click);
            // 
            // planToolStripMenuItem
            // 
            this.planToolStripMenuItem.Name = "planToolStripMenuItem";
            this.planToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.planToolStripMenuItem.Text = "Planes";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.cursosToolStripMenuItem.Text = "Cursos";
            // 
            // inscripcionesAlumnosToolStripMenuItem
            // 
            this.inscripcionesAlumnosToolStripMenuItem.Name = "inscripcionesAlumnosToolStripMenuItem";
            this.inscripcionesAlumnosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.inscripcionesAlumnosToolStripMenuItem.Text = "Inscripciones Alumnos";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.labelLegajo);
            this.Controls.Add(this.LabelBienvenido);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem especialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesAlumnosToolStripMenuItem;
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
    }
}