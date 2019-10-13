using System;
using System.Windows.Forms;

namespace SistemaPreventa.Formularios
{
    public partial class frmConexion : Form
    {
        public frmConexion()
        {
            InitializeComponent();
        }

        private void FrmConexion_Load(object sender, EventArgs e)
        {
            cmbServer.Items.Add(".");
            cmbServer.Items.Add("(local)");
            cmbServer.Items.Add(@".\SQLEXPRESS");
            cmbServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cmbServer.SelectedIndex = 3;
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cmbServer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            try
            {
                Logica.clsSqlCnn helper = new Logica.clsSqlCnn(connectionString);
                if (helper.IsConnection)
                {
                    Logica.AppSettings setting = new Logica.AppSettings();
                    setting.SaveConnectionString("cn", connectionString);
                    MessageBox.Show("La conexion fue exitosa!", "Estado de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnProbar_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};", cmbServer.Text, txtDB.Text, txtUser.Text, txtPass.Text);
            try
            {
                Logica.clsSqlCnn helper = new Logica.clsSqlCnn(connectionString);
                if (helper.IsConnection)
                    MessageBox.Show("La prueba de conexion fue exitosa!", "Estado de conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGenerar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
