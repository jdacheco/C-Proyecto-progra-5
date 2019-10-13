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

        public int MenuSize
        {
            get { return pnlMenu.Width; }
            set { pnlMenu.Width = value; }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Formularios.frmLogin fLog = new Formularios.frmLogin(this);
            fLog.MdiParent = this;
            fLog.Show();

            pnlMenu.Width = 0;

            FrmPrincipal_Resize(sender, e);
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Width = (this.Width - 20) - pnlMenu.Width; //- this.pnlMenu.Width - 4;
                frm.Height = this.Height - 44;// - 9;
            }
        }

        private void BtnSideBar_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 242) { pnlMenu.Width = 50; pctLogo.Visible = false; }
            else { pnlMenu.Width = 242; pctLogo.Visible = true; }

            //FrmPrincipal_Resize(sender, e);
        }
    }
}
