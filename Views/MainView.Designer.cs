namespace medicApp.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Pacientes_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.PacienteAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarPacienteMnu = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaVacunacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Enfermeros_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.EnfermeroAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarEnfermero_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Turnos_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TurnoAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTurno_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Localidades_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.LocalidadAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarLocalidad_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroAtencion_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.CentroAtencionAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarCentroAtencion_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Vacunas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.VacunaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarVacuna_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoVacunas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.TipoVacunaAM_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarTipoVacuna_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.Listados_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tuenosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeVacunasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centrosDeAtencionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Estadisticas_mnu_top = new System.Windows.Forms.ToolStripMenuItem();
            this.vacunadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermerosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.centroAtencionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaDe_mnu = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusInfoUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pacientes_mnu_top,
            this.Enfermeros_mnu_top,
            this.Turnos_mnu_top,
            this.Localidades_mnu_top,
            this.CentroAtencion_mnu_top,
            this.Vacunas_mnu_top,
            this.TipoVacunas_mnu_top,
            this.Listados_mnu_top,
            this.Estadisticas_mnu_top,
            this.AcercaDe_mnu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Pacientes_mnu_top
            // 
            this.Pacientes_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PacienteAM_mnu,
            this.BuscarPacienteMnu,
            this.consultaVacunacionToolStripMenuItem});
            this.Pacientes_mnu_top.Name = "Pacientes_mnu_top";
            this.Pacientes_mnu_top.Size = new System.Drawing.Size(69, 20);
            this.Pacientes_mnu_top.Tag = "AltaPaciente,ModificaPaciente,ConsultaPaciente,ConsultaVacunado";
            this.Pacientes_mnu_top.Text = "Pacientes";
            // 
            // PacienteAM_mnu
            // 
            this.PacienteAM_mnu.Name = "PacienteAM_mnu";
            this.PacienteAM_mnu.Size = new System.Drawing.Size(185, 22);
            this.PacienteAM_mnu.Tag = "AltaPaciente";
            this.PacienteAM_mnu.Text = "Ingreso";
            this.PacienteAM_mnu.Click += new System.EventHandler(this.IngresoPacienteMnu_Click);
            // 
            // BuscarPacienteMnu
            // 
            this.BuscarPacienteMnu.Name = "BuscarPacienteMnu";
            this.BuscarPacienteMnu.Size = new System.Drawing.Size(185, 22);
            this.BuscarPacienteMnu.Tag = "ModificaPaciente,ConsultaPaciente";
            this.BuscarPacienteMnu.Text = "Buscar...";
            this.BuscarPacienteMnu.Click += new System.EventHandler(this.BuscarPacienteMnu_Click);
            // 
            // consultaVacunacionToolStripMenuItem
            // 
            this.consultaVacunacionToolStripMenuItem.Name = "consultaVacunacionToolStripMenuItem";
            this.consultaVacunacionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.consultaVacunacionToolStripMenuItem.Tag = "ConsultaVacunado";
            this.consultaVacunacionToolStripMenuItem.Text = "Consulta Vacunacion";
            this.consultaVacunacionToolStripMenuItem.Click += new System.EventHandler(this.consultaVacunacionToolStripMenuItem_Click);
            // 
            // Enfermeros_mnu_top
            // 
            this.Enfermeros_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EnfermeroAM_mnu,
            this.BuscarEnfermero_mnu});
            this.Enfermeros_mnu_top.Name = "Enfermeros_mnu_top";
            this.Enfermeros_mnu_top.Size = new System.Drawing.Size(79, 20);
            this.Enfermeros_mnu_top.Tag = "AltaEnfermero,ModificaEnfermero,ConsultaEnfermero";
            this.Enfermeros_mnu_top.Text = "Enfermeros";
            // 
            // EnfermeroAM_mnu
            // 
            this.EnfermeroAM_mnu.Name = "EnfermeroAM_mnu";
            this.EnfermeroAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.EnfermeroAM_mnu.Tag = "AltaEnfermero";
            this.EnfermeroAM_mnu.Text = "Ingreso";
            this.EnfermeroAM_mnu.Click += new System.EventHandler(this.IngresoEnfermero_Click);
            // 
            // BuscarEnfermero_mnu
            // 
            this.BuscarEnfermero_mnu.Name = "BuscarEnfermero_mnu";
            this.BuscarEnfermero_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarEnfermero_mnu.Tag = "ModificaEnfermero,ConsultaEnfermero";
            this.BuscarEnfermero_mnu.Text = "Buscar";
            this.BuscarEnfermero_mnu.Click += new System.EventHandler(this.BuscarEnfermeroMnu_Click);
            // 
            // Turnos_mnu_top
            // 
            this.Turnos_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TurnoAM_mnu,
            this.BuscarTurno_mnu,
            this.registroAsistenciaToolStripMenuItem});
            this.Turnos_mnu_top.Name = "Turnos_mnu_top";
            this.Turnos_mnu_top.Size = new System.Drawing.Size(55, 20);
            this.Turnos_mnu_top.Tag = "AltaTurno,ModificaTurno,ConsultaTurno,RegistraAsistenciaTurno";
            this.Turnos_mnu_top.Text = "Turnos";
            // 
            // TurnoAM_mnu
            // 
            this.TurnoAM_mnu.Name = "TurnoAM_mnu";
            this.TurnoAM_mnu.Size = new System.Drawing.Size(173, 22);
            this.TurnoAM_mnu.Tag = "AltaTurno";
            this.TurnoAM_mnu.Text = "Ingreso";
            this.TurnoAM_mnu.Click += new System.EventHandler(this.IngresoTurno_Click);
            // 
            // BuscarTurno_mnu
            // 
            this.BuscarTurno_mnu.Name = "BuscarTurno_mnu";
            this.BuscarTurno_mnu.Size = new System.Drawing.Size(173, 22);
            this.BuscarTurno_mnu.Tag = "ModificaTurno,ConsultaTurno";
            this.BuscarTurno_mnu.Text = "Buscar";
            this.BuscarTurno_mnu.Click += new System.EventHandler(this.BuscarTurno_mnu_Click);
            // 
            // registroAsistenciaToolStripMenuItem
            // 
            this.registroAsistenciaToolStripMenuItem.Name = "registroAsistenciaToolStripMenuItem";
            this.registroAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroAsistenciaToolStripMenuItem.Tag = "RegistraAsistenciaTurno";
            this.registroAsistenciaToolStripMenuItem.Text = "Registro Asistencia";
            this.registroAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.registroAsistenciaToolStripMenuItem_Click);
            // 
            // Localidades_mnu_top
            // 
            this.Localidades_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LocalidadAM_mnu,
            this.BuscarLocalidad_mnu});
            this.Localidades_mnu_top.Name = "Localidades_mnu_top";
            this.Localidades_mnu_top.Size = new System.Drawing.Size(81, 20);
            this.Localidades_mnu_top.Tag = "AltaLocalidad,ModificaLocalidad,ConsultaLocalidad";
            this.Localidades_mnu_top.Text = "Localidades";
            // 
            // LocalidadAM_mnu
            // 
            this.LocalidadAM_mnu.Name = "LocalidadAM_mnu";
            this.LocalidadAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.LocalidadAM_mnu.Tag = "AltaLocalidad";
            this.LocalidadAM_mnu.Text = "Ingreso";
            this.LocalidadAM_mnu.Click += new System.EventHandler(this.IngresoLocalidad_mnu_click);
            // 
            // BuscarLocalidad_mnu
            // 
            this.BuscarLocalidad_mnu.Name = "BuscarLocalidad_mnu";
            this.BuscarLocalidad_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarLocalidad_mnu.Tag = "ModificaLocalidad,ConsultaLocalidad";
            this.BuscarLocalidad_mnu.Text = "Buscar";
            this.BuscarLocalidad_mnu.Click += new System.EventHandler(this.BuscarLocalidad_mnu_Click);
            // 
            // CentroAtencion_mnu_top
            // 
            this.CentroAtencion_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CentroAtencionAM_mnu,
            this.BuscarCentroAtencion_mnu});
            this.CentroAtencion_mnu_top.Name = "CentroAtencion_mnu_top";
            this.CentroAtencion_mnu_top.Size = new System.Drawing.Size(106, 20);
            this.CentroAtencion_mnu_top.Tag = "AltaCentroAtencion,ModificaCentroAtencion,ConsultaCentroAtencion";
            this.CentroAtencion_mnu_top.Text = "Centro Atencion";
            // 
            // CentroAtencionAM_mnu
            // 
            this.CentroAtencionAM_mnu.Name = "CentroAtencionAM_mnu";
            this.CentroAtencionAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.CentroAtencionAM_mnu.Tag = "AltaCentroAtencion";
            this.CentroAtencionAM_mnu.Text = "Ingreso";
            this.CentroAtencionAM_mnu.Click += new System.EventHandler(this.IngresoCentroAtencion_mn_Click);
            // 
            // BuscarCentroAtencion_mnu
            // 
            this.BuscarCentroAtencion_mnu.Name = "BuscarCentroAtencion_mnu";
            this.BuscarCentroAtencion_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarCentroAtencion_mnu.Tag = "ModificaCentroAtencion,ConsultaCentroAtencion";
            this.BuscarCentroAtencion_mnu.Text = "Buscar";
            this.BuscarCentroAtencion_mnu.Click += new System.EventHandler(this.BuscarCentroAtencion_mnu_Click);
            // 
            // Vacunas_mnu_top
            // 
            this.Vacunas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VacunaAM_mnu,
            this.BuscarVacuna_mnu});
            this.Vacunas_mnu_top.Name = "Vacunas_mnu_top";
            this.Vacunas_mnu_top.Size = new System.Drawing.Size(62, 20);
            this.Vacunas_mnu_top.Tag = "AltaVacuna,ModificaVacuna,ConsultaVacuna";
            this.Vacunas_mnu_top.Text = "Vacunas";
            // 
            // VacunaAM_mnu
            // 
            this.VacunaAM_mnu.Name = "VacunaAM_mnu";
            this.VacunaAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.VacunaAM_mnu.Tag = "AltaVacuna";
            this.VacunaAM_mnu.Text = "Ingreso";
            this.VacunaAM_mnu.Click += new System.EventHandler(this.IngresoVacunaMnu_Click);
            // 
            // BuscarVacuna_mnu
            // 
            this.BuscarVacuna_mnu.Name = "BuscarVacuna_mnu";
            this.BuscarVacuna_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarVacuna_mnu.Tag = "ModificaVacuna,ConsultaVacuna";
            this.BuscarVacuna_mnu.Text = "Buscar";
            this.BuscarVacuna_mnu.Click += new System.EventHandler(this.BuscarVacunaMnu_Click);
            // 
            // TipoVacunas_mnu_top
            // 
            this.TipoVacunas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TipoVacunaAM_mnu,
            this.BuscarTipoVacuna_mnu});
            this.TipoVacunas_mnu_top.ForeColor = System.Drawing.Color.Black;
            this.TipoVacunas_mnu_top.Name = "TipoVacunas_mnu_top";
            this.TipoVacunas_mnu_top.Size = new System.Drawing.Size(83, 20);
            this.TipoVacunas_mnu_top.Tag = "AltaTipoVacuna,ModificaTipoVacuna,ConsultaTipoVacuna";
            this.TipoVacunas_mnu_top.Text = "Tipo Vacuna";
            // 
            // TipoVacunaAM_mnu
            // 
            this.TipoVacunaAM_mnu.Name = "TipoVacunaAM_mnu";
            this.TipoVacunaAM_mnu.Size = new System.Drawing.Size(113, 22);
            this.TipoVacunaAM_mnu.Tag = "AltaTipoVacuna";
            this.TipoVacunaAM_mnu.Text = "Ingreso";
            this.TipoVacunaAM_mnu.Click += new System.EventHandler(this.IngresarTipoVacuna_mnu_click);
            // 
            // BuscarTipoVacuna_mnu
            // 
            this.BuscarTipoVacuna_mnu.Name = "BuscarTipoVacuna_mnu";
            this.BuscarTipoVacuna_mnu.Size = new System.Drawing.Size(113, 22);
            this.BuscarTipoVacuna_mnu.Tag = "ModificaTipoVacuna,ConsultaTipoVacuna";
            this.BuscarTipoVacuna_mnu.Text = "Buscar";
            this.BuscarTipoVacuna_mnu.Click += new System.EventHandler(this.BuscarTipoVacuna_mnu_Click);
            // 
            // Listados_mnu_top
            // 
            this.Listados_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.enfermerosToolStripMenuItem,
            this.tuenosToolStripMenuItem,
            this.localidadesToolStripMenuItem1,
            this.vacunasToolStripMenuItem1,
            this.tipoDeVacunasToolStripMenuItem,
            this.auditoriaToolStripMenuItem,
            this.centrosDeAtencionToolStripMenuItem});
            this.Listados_mnu_top.Name = "Listados_mnu_top";
            this.Listados_mnu_top.Size = new System.Drawing.Size(62, 20);
            this.Listados_mnu_top.Tag = "Listados";
            this.Listados_mnu_top.Text = "Listados";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pacientesToolStripMenuItem.Tag = "ConsultaPaciente";
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.ListadoPacienteMnu_Click);
            // 
            // enfermerosToolStripMenuItem
            // 
            this.enfermerosToolStripMenuItem.Name = "enfermerosToolStripMenuItem";
            this.enfermerosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.enfermerosToolStripMenuItem.Tag = "ConsultaEnfermero";
            this.enfermerosToolStripMenuItem.Text = "Enfermeros";
            this.enfermerosToolStripMenuItem.Click += new System.EventHandler(this.ListadoEnfermeros_Click);
            // 
            // tuenosToolStripMenuItem
            // 
            this.tuenosToolStripMenuItem.Name = "tuenosToolStripMenuItem";
            this.tuenosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tuenosToolStripMenuItem.Tag = "ConsultaTurno";
            this.tuenosToolStripMenuItem.Text = "Turnos";
            this.tuenosToolStripMenuItem.Click += new System.EventHandler(this.ListadoTurnos_Click);
            // 
            // localidadesToolStripMenuItem1
            // 
            this.localidadesToolStripMenuItem1.Name = "localidadesToolStripMenuItem1";
            this.localidadesToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.localidadesToolStripMenuItem1.Tag = "ConsultaLocalidad";
            this.localidadesToolStripMenuItem1.Text = "Localidades";
            this.localidadesToolStripMenuItem1.Click += new System.EventHandler(this.ListadoLocalidades_Click);
            // 
            // vacunasToolStripMenuItem1
            // 
            this.vacunasToolStripMenuItem1.Name = "vacunasToolStripMenuItem1";
            this.vacunasToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.vacunasToolStripMenuItem1.Tag = "ConsultaVacuna";
            this.vacunasToolStripMenuItem1.Text = "Vacunas";
            this.vacunasToolStripMenuItem1.Click += new System.EventHandler(this.vacunasToolStripMenuItem1_Click);
            // 
            // tipoDeVacunasToolStripMenuItem
            // 
            this.tipoDeVacunasToolStripMenuItem.Name = "tipoDeVacunasToolStripMenuItem";
            this.tipoDeVacunasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tipoDeVacunasToolStripMenuItem.Tag = "ConsultaTipoVacuna";
            this.tipoDeVacunasToolStripMenuItem.Text = "Tipo de vacunas";
            this.tipoDeVacunasToolStripMenuItem.Click += new System.EventHandler(this.ListadoTipoVacunasMnu_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.auditoriaToolStripMenuItem.Tag = "ConsultaAuditoria";
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // centrosDeAtencionToolStripMenuItem
            // 
            this.centrosDeAtencionToolStripMenuItem.Name = "centrosDeAtencionToolStripMenuItem";
            this.centrosDeAtencionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.centrosDeAtencionToolStripMenuItem.Tag = "ConsultaCentroAtencion";
            this.centrosDeAtencionToolStripMenuItem.Text = "Centros de Atencion";
            this.centrosDeAtencionToolStripMenuItem.Click += new System.EventHandler(this.ListadoCentroAtencion_Click);
            // 
            // Estadisticas_mnu_top
            // 
            this.Estadisticas_mnu_top.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacunadosToolStripMenuItem,
            this.enfermerosToolStripMenuItem1,
            this.centroAtencionToolStripMenuItem1});
            this.Estadisticas_mnu_top.Name = "Estadisticas_mnu_top";
            this.Estadisticas_mnu_top.Size = new System.Drawing.Size(79, 20);
            this.Estadisticas_mnu_top.Tag = "Estadisticas";
            this.Estadisticas_mnu_top.Text = "Estadísticas";
            // 
            // vacunadosToolStripMenuItem
            // 
            this.vacunadosToolStripMenuItem.Name = "vacunadosToolStripMenuItem";
            this.vacunadosToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.vacunadosToolStripMenuItem.Tag = "ConsultaPaciente,ConsultaTurno";
            this.vacunadosToolStripMenuItem.Text = "Vacunados";
            this.vacunadosToolStripMenuItem.Click += new System.EventHandler(this.EstadisticaVacunados_mnu_Click);
            // 
            // enfermerosToolStripMenuItem1
            // 
            this.enfermerosToolStripMenuItem1.Name = "enfermerosToolStripMenuItem1";
            this.enfermerosToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.enfermerosToolStripMenuItem1.Tag = "ConsultaEnfermero";
            this.enfermerosToolStripMenuItem1.Text = "Tipo Vacuna";
            this.enfermerosToolStripMenuItem1.Click += new System.EventHandler(this.EstadisticaTipoVacuna_mnu_Click);
            // 
            // centroAtencionToolStripMenuItem1
            // 
            this.centroAtencionToolStripMenuItem1.Name = "centroAtencionToolStripMenuItem1";
            this.centroAtencionToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.centroAtencionToolStripMenuItem1.Tag = "ConsultaCentroAtencion";
            this.centroAtencionToolStripMenuItem1.Text = "Localidad";
            this.centroAtencionToolStripMenuItem1.Click += new System.EventHandler(this.EstadisticaLocalidad_mnu_Click);
            // 
            // AcercaDe_mnu
            // 
            this.AcercaDe_mnu.Name = "AcercaDe_mnu";
            this.AcercaDe_mnu.Size = new System.Drawing.Size(80, 20);
            this.AcercaDe_mnu.Text = "Acerca de...";
            this.AcercaDe_mnu.Click += new System.EventHandler(this.AcercaDe_mnu_Click);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusInfoUser});
            this.status.Location = new System.Drawing.Point(0, 422);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status.Size = new System.Drawing.Size(964, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // StatusInfoUser
            // 
            this.StatusInfoUser.Name = "StatusInfoUser";
            this.StatusInfoUser.Size = new System.Drawing.Size(0, 17);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 444);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de información";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripMenuItem Pacientes_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem PacienteAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarPacienteMnu;
        private System.Windows.Forms.ToolStripMenuItem Enfermeros_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem EnfermeroAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarEnfermero_mnu;
        private System.Windows.Forms.ToolStripMenuItem Turnos_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Localidades_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem Vacunas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TipoVacunas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem TurnoAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem LocalidadAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem VacunaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem TipoVacunaAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem Listados_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuenosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarTurno_mnu;
        private System.Windows.Forms.ToolStripMenuItem localidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vacunasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tipoDeVacunasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Estadisticas_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem vacunadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermerosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel StatusInfoUser;
        private System.Windows.Forms.ToolStripMenuItem centrosDeAtencionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BuscarLocalidad_mnu;
        private System.Windows.Forms.ToolStripMenuItem CentroAtencion_mnu_top;
        private System.Windows.Forms.ToolStripMenuItem CentroAtencionAM_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarCentroAtencion_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarVacuna_mnu;
        private System.Windows.Forms.ToolStripMenuItem BuscarTipoVacuna_mnu;
        private System.Windows.Forms.ToolStripMenuItem centroAtencionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AcercaDe_mnu;
        private System.Windows.Forms.ToolStripMenuItem consultaVacunacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsistenciaToolStripMenuItem;

    }
}