﻿namespace UI.Desktop
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
            this.tsmIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrarPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministrarUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCursadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportesDocentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCargarNotasAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMateriasInscripto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInscribirseAMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogueado = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblNombrePersona = new System.Windows.Forms.Label();
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
            // tsmIniciarSesion
            // 
            this.tsmIniciarSesion.Name = "tsmIniciarSesion";
            this.tsmIniciarSesion.Size = new System.Drawing.Size(143, 22);
            this.tsmIniciarSesion.Text = "Iniciar Sesion";
            // 
            // tsmCerrarSesion
            // 
            this.tsmCerrarSesion.Name = "tsmCerrarSesion";
            this.tsmCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.tsmCerrarSesion.Text = "Cerrar Sesion";
            this.tsmCerrarSesion.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(143, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tsmAdministrar
            // 
            this.tsmAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdministrarPersonas,
            this.tsmAdministrarUsuarios,
            this.administrarCursadasToolStripMenuItem});
            this.tsmAdministrar.Name = "tsmAdministrar";
            this.tsmAdministrar.Size = new System.Drawing.Size(81, 20);
            this.tsmAdministrar.Text = "Administrar";
            // 
            // tsmAdministrarPersonas
            // 
            this.tsmAdministrarPersonas.Name = "tsmAdministrarPersonas";
            this.tsmAdministrarPersonas.Size = new System.Drawing.Size(187, 22);
            this.tsmAdministrarPersonas.Text = "Administrar Personas";
            this.tsmAdministrarPersonas.Click += new System.EventHandler(this.tsmAdministrarPersonas_Click);
            // 
            // tsmAdministrarUsuarios
            // 
            this.tsmAdministrarUsuarios.Name = "tsmAdministrarUsuarios";
            this.tsmAdministrarUsuarios.Size = new System.Drawing.Size(187, 22);
            this.tsmAdministrarUsuarios.Text = "Administrar Usuarios";
            this.tsmAdministrarUsuarios.Click += new System.EventHandler(this.tsmUsuarios_Click);
            // 
            // administrarCursadasToolStripMenuItem
            // 
            this.administrarCursadasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEspecialidadesToolStripMenuItem,
            this.aBMPlanesToolStripMenuItem,
            this.aBMMateriasToolStripMenuItem,
            this.aBMCursosToolStripMenuItem});
            this.administrarCursadasToolStripMenuItem.Name = "administrarCursadasToolStripMenuItem";
            this.administrarCursadasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.administrarCursadasToolStripMenuItem.Text = "Administrar Cursadas";
            this.administrarCursadasToolStripMenuItem.Click += new System.EventHandler(this.administrarCursadasToolStripMenuItem_Click);
            // 
            // aBMEspecialidadesToolStripMenuItem
            // 
            this.aBMEspecialidadesToolStripMenuItem.Name = "aBMEspecialidadesToolStripMenuItem";
            this.aBMEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aBMEspecialidadesToolStripMenuItem.Text = "ABM Especialidades";
            this.aBMEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.aBMEspecialidadesToolStripMenuItem_Click);
            // 
            // aBMPlanesToolStripMenuItem
            // 
            this.aBMPlanesToolStripMenuItem.Name = "aBMPlanesToolStripMenuItem";
            this.aBMPlanesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aBMPlanesToolStripMenuItem.Text = "ABM Planes";
            this.aBMPlanesToolStripMenuItem.Click += new System.EventHandler(this.aBMPlanesToolStripMenuItem_Click);
            // 
            // aBMMateriasToolStripMenuItem
            // 
            this.aBMMateriasToolStripMenuItem.Name = "aBMMateriasToolStripMenuItem";
            this.aBMMateriasToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aBMMateriasToolStripMenuItem.Text = "ABM Materias";
            this.aBMMateriasToolStripMenuItem.Click += new System.EventHandler(this.aBMMateriasToolStripMenuItem_Click);
            // 
            // aBMCursosToolStripMenuItem
            // 
            this.aBMCursosToolStripMenuItem.Name = "aBMCursosToolStripMenuItem";
            this.aBMCursosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.aBMCursosToolStripMenuItem.Text = "ABM Comision";
            this.aBMCursosToolStripMenuItem.Click += new System.EventHandler(this.aBMCursosToolStripMenuItem_Click);
            // 
            // tsmDocentes
            // 
            this.tsmDocentes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReportesDocentes,
            this.tsmCargarNotasAlumnos});
            this.tsmDocentes.Name = "tsmDocentes";
            this.tsmDocentes.Size = new System.Drawing.Size(68, 20);
            this.tsmDocentes.Text = "Docentes";
            // 
            // tsmReportesDocentes
            // 
            this.tsmReportesDocentes.Name = "tsmReportesDocentes";
            this.tsmReportesDocentes.Size = new System.Drawing.Size(194, 22);
            this.tsmReportesDocentes.Text = "Reportes Docentes";
            this.tsmReportesDocentes.Click += new System.EventHandler(this.tsmReportesDocentes_Click);
            // 
            // tsmCargarNotasAlumnos
            // 
            this.tsmCargarNotasAlumnos.Name = "tsmCargarNotasAlumnos";
            this.tsmCargarNotasAlumnos.Size = new System.Drawing.Size(194, 22);
            this.tsmCargarNotasAlumnos.Text = "Cargar Notas Alumnos";
            this.tsmCargarNotasAlumnos.Click += new System.EventHandler(this.cargarNotasAlumnosToolStripMenuItem_Click);
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
            this.tsmMateriasInscripto.Size = new System.Drawing.Size(179, 22);
            this.tsmMateriasInscripto.Text = "Materias Inscripto";
            this.tsmMateriasInscripto.Click += new System.EventHandler(this.tsmMateriasInscripto_Click);
            // 
            // tsmInscribirseAMateria
            // 
            this.tsmInscribirseAMateria.Name = "tsmInscribirseAMateria";
            this.tsmInscribirseAMateria.Size = new System.Drawing.Size(179, 22);
            this.tsmInscribirseAMateria.Text = "Inscribirse a materia";
            this.tsmInscribirseAMateria.Click += new System.EventHandler(this.tsmInscribirseAMateria_Click);
            // 
            // lblLogueado
            // 
            this.lblLogueado.AutoSize = true;
            this.lblLogueado.Location = new System.Drawing.Point(72, 66);
            this.lblLogueado.Name = "lblLogueado";
            this.lblLogueado.Size = new System.Drawing.Size(154, 13);
            this.lblLogueado.TabIndex = 1;
            this.lblLogueado.Text = "Usted ha sido logueado como :";
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(75, 105);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(69, 13);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido : ";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(253, 66);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(0, 13);
            this.lblTipoPersona.TabIndex = 3;
            // 
            // lblNombrePersona
            // 
            this.lblNombrePersona.AutoSize = true;
            this.lblNombrePersona.Location = new System.Drawing.Point(253, 105);
            this.lblNombrePersona.Name = "lblNombrePersona";
            this.lblNombrePersona.Size = new System.Drawing.Size(0, 13);
            this.lblNombrePersona.TabIndex = 4;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNombrePersona);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.lblLogueado);
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
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrarPersonas;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministrarUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmReportesDocentes;
        private System.Windows.Forms.ToolStripMenuItem tsmAlumnos;
        private System.Windows.Forms.ToolStripMenuItem tsmMateriasInscripto;
        private System.Windows.Forms.ToolStripMenuItem tsmInscribirseAMateria;
        private System.Windows.Forms.ToolStripMenuItem tsmIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem administrarCursadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCursosToolStripMenuItem;
        private System.Windows.Forms.Label lblLogueado;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.Label lblNombrePersona;
        private System.Windows.Forms.ToolStripMenuItem tsmCargarNotasAlumnos;
    }
}