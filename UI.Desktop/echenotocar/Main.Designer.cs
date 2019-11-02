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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportesDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasInscripto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInscribirseAMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmAdministrar,
            this.tsmDocentes,
            this.tsmAlumnos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIniciarSesion,
            this.tsmCerrarSesion,
            this.tsmSalir});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmMenu.Text = "Menu";
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(180, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmAdministrar
            // 
            this.tsmAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPersonas,
            this.tsmUsuarios});
            this.tsmAdministrar.Name = "tsmAdministrar";
            this.tsmAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tsmAdministrar.Text = "Administrar";
            // 
            // tsmPersonas
            // 
            this.tsmPersonas.Name = "tsmPersonas";
            this.tsmPersonas.Size = new System.Drawing.Size(180, 22);
            this.tsmPersonas.Text = "Personas";
            // 
            // tsmUsuarios
            // 
            this.tsmUsuarios.Name = "tsmUsuarios";
            this.tsmUsuarios.Size = new System.Drawing.Size(180, 22);
            this.tsmUsuarios.Text = "Usuarios";
            // 
            // tsmDocentes
            // 
            this.tsmDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReportesDocentes});
            this.tsmDocentes.Name = "tsmDocentes";
            this.tsmDocentes.Size = new System.Drawing.Size(68, 20);
            this.tsmDocentes.Text = "Docentes";
            // 
            // tsmReportesDocentes
            // 
            this.tsmReportesDocentes.Name = "tsmReportesDocentes";
            this.tsmReportesDocentes.Size = new System.Drawing.Size(180, 22);
            this.tsmReportesDocentes.Text = "Reportes Docentes";
            // 
            // tsmAlumnos
            // 
            this.tsmAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMateriasInscripto,
            this.tsmInscribirseAMateria});
            this.tsmAlumnos.Name = "tsmAlumnos";
            this.tsmAlumnos.Size = new System.Drawing.Size(67, 20);
            this.tsmAlumnos.Text = "Alumnos";
            // 
            // tsmMateriasInscripto
            // 
            this.tsmMateriasInscripto.Name = "tsmMateriasInscripto";
            this.tsmMateriasInscripto.Size = new System.Drawing.Size(180, 22);
            this.tsmMateriasInscripto.Text = "Materias Inscripto";
            // 
            // tsmInscribirseAMateria
            // 
            this.tsmInscribirseAMateria.Name = "tsmInscribirseAMateria";
            this.tsmInscribirseAMateria.Size = new System.Drawing.Size(180, 22);
            this.tsmInscribirseAMateria.Text = "Inscribirse a materia";
            // 
            // tsmIniciarSesion
            // 
            this.tsmIniciarSesion.Name = "tsmIniciarSesion";
            this.tsmIniciarSesion.Size = new System.Drawing.Size(180, 22);
            this.tsmIniciarSesion.Text = "Iniciar Sesion";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrar;
        private System.Windows.Forms.ToolStripMenuItem tsmPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmReportesDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmAlumnos;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasInscripto;
        private System.Windows.Forms.ToolStripMenuItem tsmInscribirseAMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmIniciarSesion;
    }
}