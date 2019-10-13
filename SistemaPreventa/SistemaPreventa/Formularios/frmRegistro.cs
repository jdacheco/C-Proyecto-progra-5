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
    public partial class frmRegistro : Form
    {
        int mov;
        int movX;
        int movY;
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void PctInfo_Click(object sender, EventArgs e)
        {

        }

        private void PctInfo_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1; movX = e.X; movY = e.Y;
        }

        private void PctInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1) {this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);}
        }

        private void PctInfo_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
