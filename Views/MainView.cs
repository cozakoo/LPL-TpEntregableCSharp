using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using Npgsql; // Libreria para conectar con PostgreSQL
using medicApp.db; // incluir libreria para poder acceder a los objetos de negocios.

namespace medicApp.Views
{
    public partial class MainView : FormBase
    {
        private Usuario _usuarioActual = null;
        public Usuario UsuarioActual
        {
            get { return _usuarioActual; }
        }

        public override void ConfigurePermiso(PermisoAttribute perm)
        {

        }

        public void ShowUsuario()
        {
            _usuarioActual = Usuario.UsuarioSys;
            StatusInfoUser.Text = String.Format("Usuario: {0} - {1}", _usuarioActual.UsuarioName, _usuarioActual.FechaLogin); ;
            // mostrar los permisos del usuario en base a los roles, leer cada permiso.
            // Recorrer cada item de Menu, para verificar primero los grupos  y luego cada opcion.
            var list = this.menuStrip1.Items.Cast<ToolStripMenuItem>().ToList().Where(t => t.Name.IndexOf("mnu_top") != -1);
            List<Funcion> listFuncUser = UsuarioActual.ListadoFunciones;
            bool prmOK = false;
            foreach (var item in list)
            {
                // verificar el permiso puede incluir listado hacer split.
                prmOK = false;
                string perm = item.Tag.ToString();
                string[] listFunciones = perm.Split(',');
                for (int i = 0; i < listFunciones.Length; i++)
                {
                    prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFunciones[i]) != null;
                }
                item.Enabled = prmOK;
                //por cada ItemPrincipal, verificar los SubItems por debajo si tiene permiso.

                var list_subitm = item.DropDownItems.Cast<ToolStripMenuItem>().ToList();

                foreach (var subitm in list_subitm)
                {
                    prmOK = false;
                    string permsub = subitm.Tag.ToString();
                    string[] listFuncionesSub = permsub.Split(',');
                    for (int i = 0; i < listFuncionesSub.Length; i++)
                    {
                        prmOK = prmOK || listFuncUser.Find(ff => ff.Nombre == listFuncionesSub[i]) != null;
                    }
                    subitm.Enabled = prmOK;
                }
            }
            // aplicar permiso a cada submenu.

            this.Visible = true;
        }
        private static readonly MainView instance = new MainView();
        static MainView()
        { }
        private MainView()
        {
            InitializeComponent();
        }
        
        // Implementacion de Patron Singleton
        public static MainView Instance
        {
            get
            {
                return instance;
            }
        }

        public void ShowMain(FrmLogin loginFrm, Usuario user)
        {
            loginFrm.Dispose();
            loginFrm = null;
            _usuarioActual = user;
            this.Show();
        }
        
        private void MainView_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin;
            if (_usuarioActual == null)
            {
                this.Visible = false;
                frmLogin = new FrmLogin();
                frmLogin.ShowDialog();
                if (_usuarioActual == null)
                {
                    Application.Exit();
                    return;
                }
                //this.Visible = true;
            }
        }

        void frm_DoCompleteOperationForm(object Sender, EventArgDom ev)
        {
            if (ev.Status == TipoOperacionStatus.stOK)
            {
                MessageBox.Show("Operacion realizada correctamente ", "Exito...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Verificar si hay Form de Listado para poder actualizar la lista de datos..
            }
            else
            {
                MessageBox.Show("Ocurrio un error: " + ev.Mensaje, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresoPacienteMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmPacienteAM frm = new FrmPacienteAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoPaciente(this);
        }

        private void IngresoVacunaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmVacunaAM frm = new FrmVacunaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoVacuna(this);
        }

        private void IngresoEnfermero_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmEnfermeroAM frm = new FrmEnfermeroAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoEnfermero();
        }

        private void IngresoTurno_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTurnoAM frmTurno = new FrmTurnoAM();
            frmTurno.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frmTurno.ShowIngresoTurno();
        }

        private void IngresoCentroAtencion_mn_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmCentroAtencionAM frmCen = new FrmCentroAtencionAM();
            frmCen.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frmCen.ShowIngresoCentroAtencion();
        }

        private void IngresarTipoVacuna_mnu_click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTipoVacunaAM frm = new FrmTipoVacunaAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoTipoVacuna();
        }

        private void IngresoLocalidad_mnu_click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadAM frm = new FrmLocalidadAM();
            frm.DoCompleteOperationForm += new FormEvent(frm_DoCompleteOperationForm);
            frm.ShowIngresoLocalidad();
        }

        private void BuscarPacienteMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmPacienteBusq frm = new FrmPacienteBusq();
            frm.ShowBuscar();
        }

        private void BuscarVacunaMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmVacunaBusq frm = new FrmVacunaBusq();
            frm.ShowBuscar();
        }

        private void ListadoTipoVacunasMnu_Click(object sender, EventArgs e)
        {
            FrmListadoTipoVacuna frmListTV = new FrmListadoTipoVacuna();
            frmListTV.Show();
        }

        private void ListadoPacienteMnu_Click(object sender, EventArgs e)
        {
            FrmListadoPacientes frmListPac = new FrmListadoPacientes();
            frmListPac.Show();
        }

        private void ListadoEnfermeros_Click(object sender, EventArgs e)
        {
            FrmListadoEnfermeros frm = new FrmListadoEnfermeros();
            frm.Show();
        }

        private void ListadoLocalidades_Click(object sender, EventArgs e)
        {
            FrmListadoLocalidad frm = new FrmListadoLocalidad();
            frm.Show();
        }

        private void ListadoCentroAtencion_Click(object sender, EventArgs e)
        {
            FrmListadoCentroAtencion frmCentro = new FrmListadoCentroAtencion();
            frmCentro.Show();
        }


        private void ListadoTurnos_Click(object sender, EventArgs e)
        {
            FrmListadoTurnos frm = new FrmListadoTurnos();
            frm.Show();
        }


        private void vacunasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmListadoVacuna frm = new FrmListadoVacuna();
            frm.Show();
        }

        private void BuscarEnfermeroMnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmEnfermeroBusq frm = new FrmEnfermeroBusq();
            frm.ShowBuscar();
        }

        private void consultaVacunacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmConsultaVacunacion frm = new FrmConsultaVacunacion();
            frm.ShowConsultar();
        }

        private void BuscarTurno_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTurnoeBusq frm = new FrmTurnoeBusq();
            frm.ShowBuscar();
        }

        private void BuscarTipoVacuna_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmTipoVacunaBusq frm = new FrmTipoVacunaBusq();
            frm.ShowBuscar();
        }

        private void BuscarLocalidad_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmLocalidadBusq frm = new FrmLocalidadBusq();
            frm.ShowBuscar();
        }

        private void BuscarCentroAtencion_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmCentroAtencionBusq frm = new FrmCentroAtencionBusq();
            frm.ShowBuscar();
        }

        private void EstadisticaVacunados_mnu_Click(object sender, EventArgs e)
        {
            var lista = CentroAtencion.FindAllStatic(null, (t1, t2) => (t1.Id).CompareTo(t2.Id));
            MainView.Instance.Cursor = Cursors.Default;

            FrmEstadisticaVacunados frmEstadistica = new FrmEstadisticaVacunados();
            frmEstadistica.ShowListado(lista, this, null);
        }

        private void EstadisticaTipoVacuna_mnu_Click(object sender, EventArgs e)
        {
            var lista = CentroAtencion.FindAllStatic(null, (t1, t2) => (t1.Id).CompareTo(t2.Id));
            MainView.Instance.Cursor = Cursors.Default;

            FrmEstadisticaTipoVacuna frmTV = new FrmEstadisticaTipoVacuna();
            frmTV.ShowListado(lista, this, null);
        }

        private void EstadisticaLocalidad_mnu_Click(object sender, EventArgs e)
        {
            var lista = Localidad.FindAllStatic(null, (t1, t2) => (t1.Nombre).CompareTo(t2.Nombre));
            MainView.Instance.Cursor = Cursors.Default;

            FrmEstadisticaLocalidad frmLoc = new FrmEstadisticaLocalidad();
            frmLoc.ShowListado(lista, this, null);
        }

        private void Auditoria_mnu_Click(object sender, EventArgs e)
        {

        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir del sistema?", "salida..", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
                return;
            }
            e.Cancel = true;
        }

        private void AcercaDe_mnu_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.Help;
        }

        private void registroAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmRegistrarTurno frm = new FrmRegistrarTurno();
            frm.ShowRegistrar();
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainView.Instance.Cursor = Cursors.WaitCursor;
            FrmListadoAuditorias frm = new FrmListadoAuditorias();
            frm.Show();
        }


































    }
}
