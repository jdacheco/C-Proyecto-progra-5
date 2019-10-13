using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPreventa
{
    public partial class frmPrincipal : Form
    {
        int mov;
        int movX;
        int movY;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void Deshabilita(string sBoton)
        {
            if (sBoton == "btnVentas") { btnVentas.Enabled = false; } else { btnVentas.Enabled = true; }
            if (sBoton == "btnDevolucion") { btnDevolucion.Enabled = false; } else { btnDevolucion.Enabled = true; }
            /*if (sBoton == "btnReporteria") { btnReporteria.Enabled = false; } else { btnReporteria.Enabled = true; }
            if (sBoton == "btnEstadistica") { btnEstadistica.Enabled = false; } else { btnEstadistica.Enabled = true; }
            if (sBoton == "btnValidacion") { btnValidacion.Enabled = false; } else { btnValidacion.Enabled = true; }
            if (sBoton == "btnFacturacion") { btnFacturacion.Enabled = false; } else { btnFacturacion.Enabled = true; }*/
            if (sBoton == "btnUsuarios") { btnUsuarios.Enabled = false; } else { btnUsuarios.Enabled = true; }
            if (sBoton == "btnCambiarClave") { btnCambiarClave.Enabled = false; } else { btnCambiarClave.Enabled = true; }

            /*if (sBoton == "pctBitacora") { pctBitacora.Enabled = false; } else { pctBitacora.Enabled = true; }
            if (sBoton == "pctSocios") { pctSocios.Enabled = false; } else { pctSocios.Enabled = true; }
            if (sBoton == "pctConfig") { pctConfig.Enabled = false; } else { pctConfig.Enabled = true; }*/
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.pctLogo.BackColor = Color.Transparent;

            this.btnSideBar.BackColor = Color.Transparent;
            this.btnVentas.BackColor = Color.Transparent;
            this.btnDevolucion.BackColor = Color.Transparent;
            this.btnClientes.BackColor = Color.Transparent;
            this.btnEstadistica.BackColor = Color.Transparent;
            this.btnValidacion.BackColor = Color.Transparent;
            this.btnFacturacion.BackColor = Color.Transparent;

            this.btnUsuarios.BackColor = Color.Transparent;
            this.btnCambiarClave.BackColor = Color.Transparent;
            this.btnCerrarSesion.BackColor = Color.Transparent;

            FrmPrincipal_Resize(sender, e);
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Width = (this.Width - 4) - pnlMenu.Width; //- this.pnlMenu.Width - 4;
                frm.Height = (this.Height - 5) - pnlSistema.Height;// - 9;
            }
        }

        private void BtnSideBar_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 255) { pnlMenu.Width = 50; pctLogo.Visible = false; }
            else { pnlMenu.Width = 255; pctLogo.Visible = true; }
        }

        private void BtnRetorna_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            btnRetorna.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            btnRetorna.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void BtnX_MouseMove(object sender, MouseEventArgs e)
        {
            //btnX.BackColor = Color.LightBlue;
        }

        private void BtnX_MouseLeave(object sender, EventArgs e)
        {
            //btnX.BackColor = Color.Transparent;
        }

        private void BtnRetorna_MouseMove(object sender, MouseEventArgs e)
        {
            //btnRetorna.BackColor = Color.LightBlue;
        }

        private void BtnRetorna_MouseLeave(object sender, EventArgs e)
        {
            //btnRetorna.BackColor = Color.Transparent;
        }

        private void BtnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnMaximizar.BackColor = Color.LightBlue;
        }

        private void BtnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            //btnMaximizar.BackColor = Color.Transparent;
        }

        private void BtnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            //btnMinimizar.BackColor = Color.LightBlue;
        }

        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            //btnMinimizar.BackColor = Color.Transparent;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            Clases.clsGlobales.MiFormLogin.Show();
            this.Hide();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Top = btnVentas.Top;

            Deshabilita("btnVentas");

            foreach (Form frm in this.MdiChildren) { frm.Close(); }
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Top = btnUsuarios.Top;

            Deshabilita("btnUsuarios");

            foreach (Form frm in this.MdiChildren) { frm.Close(); }

            Formularios.frmUsuarios fUser = new Formularios.frmUsuarios();
            fUser.MdiParent = this;
            fUser.Show();

            FrmPrincipal_Resize(sender, e);
        }

        private void BtnCambiarClave_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Top = btnCambiarClave.Top;

            Deshabilita("btnCambiarClave");

            foreach (Form frm in this.MdiChildren) { frm.Close(); }
        }

        private void PnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void PnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) { this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY); }
        }

        private void PnlMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BtnUsuarios_MouseMove(object sender, MouseEventArgs e)
        {
            btnUsuarios.BackColor = Color.DarkOrchid;
        }

        private void BtnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.BackColor = Color.Transparent;
        }

        private void BtnCambiarClave_MouseMove(object sender, MouseEventArgs e)
        {
            btnCambiarClave.BackColor = Color.DarkOrchid;
        }

        private void BtnCambiarClave_MouseLeave(object sender, EventArgs e)
        {
            btnCambiarClave.BackColor = Color.Transparent;
        }

        private void BtnCerrarSesion_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrarSesion.BackColor = Color.DarkOrchid;
        }

        private void BtnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.Transparent;
        }

        private void BtnVentas_MouseMove(object sender, MouseEventArgs e)
        {
            btnVentas.BackColor = Color.DarkOrchid;
        }

        private void BtnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.BackColor = Color.Transparent;
        }

        private void BtnDevolucion_MouseMove(object sender, MouseEventArgs e)
        {
            btnDevolucion.BackColor = Color.DarkOrchid;
        }

        private void BtnDevolucion_MouseLeave(object sender, EventArgs e)
        {
            btnDevolucion.BackColor = Color.Transparent;
        }

        private void BtnDevolucion_Click(object sender, EventArgs e)
        {
            SlidePanel.Visible = true;
            SlidePanel.Top = btnDevolucion.Top;

            Deshabilita("btnDevolucion");

            foreach (Form frm in this.MdiChildren) { frm.Close(); }
        }

        private void BtnSideBar_MouseMove(object sender, MouseEventArgs e)
        {
            btnSideBar.BackColor = Color.DarkOrchid;
        }

        private void BtnSideBar_MouseLeave(object sender, EventArgs e)
        {
            btnSideBar.BackColor = Color.Transparent;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            BtnX_Click(sender, e);
        }
    }
}
