using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaPreventa.Formularios
{
    public partial class frmLogin : Form
    {
        int mov;
        int movX;
        int movY;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.pnlLogin.Parent = this.pctFondo;
            this.pnlLogin.BackColor = Color.Transparent;

            this.btnIngresar.BackColor = Color.Transparent;
            this.btnCerrar.BackColor = Color.Transparent;

            this.btnMinimizar.Parent = this.pctFondo;
            this.btnMinimizar.BackColor = Color.Transparent;

            this.btnMaximizar.Parent = this.pctFondo;
            this.btnMaximizar.BackColor = Color.Transparent;

            this.btnRetorna.Parent = this.pctFondo;
            this.btnRetorna.BackColor = Color.Transparent;

            this.btnX.Parent = this.pctFondo;
            this.btnX.BackColor = Color.Transparent;

            this.txtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Clases.clsGlobales.MiFormPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            this.pnlLogin.Left = (this.Width / 2) - (this.pnlLogin.Width / 2) - 10;
            this.pnlLogin.Top = (this.Height / 2) - (this.pnlLogin.Height / 2) - 20;
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresar.BackColor = Color.ForestGreen;
        }

        private void BtnIngresar_MouseLeave(object sender, EventArgs e)
        {
            btnIngresar.BackColor = Color.Transparent;
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

        private void BtnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PctFondo_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void PctFondo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1){this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);}
        }

        private void PctFondo_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void PnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void PnlLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) { this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY); }
        }

        private void PnlLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BtnX_MouseMove(object sender, MouseEventArgs e)
        {
            btnX.BackColor = Color.LightBlue;
        }

        private void BtnX_MouseLeave(object sender, EventArgs e)
        {
            btnX.BackColor = Color.Transparent;
        }

        private void BtnRetorna_MouseMove(object sender, MouseEventArgs e)
        {
            btnRetorna.BackColor = Color.LightBlue;
        }

        private void BtnRetorna_MouseLeave(object sender, EventArgs e)
        {
            btnRetorna.BackColor = Color.Transparent;
        }

        private void BtnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.LightBlue;
        }

        private void BtnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.Transparent;
        }

        private void BtnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.LightBlue;
        }

        private void BtnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }

        private void BtnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Firebrick;
        }

        private void BtnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Transparent;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
