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
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.pctLogo.BackColor = Color.Transparent;

            this.btnSideBar.BackColor = Color.Transparent;
            this.btnVentas.BackColor = Color.Transparent;
            this.btnConvertir.BackColor = Color.Transparent;
            this.btnReporteria.BackColor = Color.Transparent;
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
            if (pnlMenu.Width == 242) { pnlMenu.Width = 50; pctLogo.Visible = false; }
            else { pnlMenu.Width = 242; pctLogo.Visible = true; }
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
        }
    }
}
