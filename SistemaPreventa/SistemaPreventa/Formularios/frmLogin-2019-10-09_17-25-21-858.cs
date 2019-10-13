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
        public frmLogin()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.pnlLogin.Parent = this.pctFondo;
            this.pnlLogin.BackColor = Color.Transparent;
            this.btnIngresar.BackColor = Color.Transparent;

            this.txtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            Clases.clsGlobales.MiFormPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_Resize(object sender, EventArgs e)
        {
            //this.pnlLogin.Location.X = (this.Width / 2) - (pnlLogin.Width / 2);
            this.pnlLogin.Left = (this.Width / 2) - (this.pnlLogin.Width / 2) - 70;
            this.pnlLogin.Top = (this.Height / 2) - (this.pnlLogin.Height / 2) - 20;
        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresar.BackColor = Color.MidnightBlue;
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
    }
}
