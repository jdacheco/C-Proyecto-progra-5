using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.lnkOlvido.Parent = this.pctFondo;
            this.lnkOlvido.BackColor = Color.Transparent;

            this.btnIngresar.Parent = this.pctFondo;
            this.btnIngresar.BackColor = Color.Transparent;

            this.pctUsuarios.Parent = this.pctFondo;
            this.pctUsuarios.BackColor = Color.Transparent;
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
