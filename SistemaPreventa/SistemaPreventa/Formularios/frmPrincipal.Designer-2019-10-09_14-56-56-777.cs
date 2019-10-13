namespace SistemaPreventa
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSideBar = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.btnValidacion = new System.Windows.Forms.Button();
            this.btnEstadistica = new System.Windows.Forms.Button();
            this.btnReporteria = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlMenu.Controls.Add(this.pictureBox3);
            this.pnlMenu.Controls.Add(this.btnSideBar);
            this.pnlMenu.Controls.Add(this.btnFacturacion);
            this.pnlMenu.Controls.Add(this.btnValidacion);
            this.pnlMenu.Controls.Add(this.btnEstadistica);
            this.pnlMenu.Controls.Add(this.btnReporteria);
            this.pnlMenu.Controls.Add(this.btnConvertir);
            this.pnlMenu.Controls.Add(this.SlidePanel);
            this.pnlMenu.Controls.Add(this.btnHistorial);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(242, 450);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnSideBar
            // 
            this.btnSideBar.FlatAppearance.BorderSize = 0;
            this.btnSideBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideBar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSideBar.ForeColor = System.Drawing.Color.White;
            this.btnSideBar.Image = ((System.Drawing.Image)(resources.GetObject("btnSideBar.Image")));
            this.btnSideBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideBar.Location = new System.Drawing.Point(12, 12);
            this.btnSideBar.Name = "btnSideBar";
            this.btnSideBar.Size = new System.Drawing.Size(34, 30);
            this.btnSideBar.TabIndex = 41;
            this.btnSideBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSideBar.UseVisualStyleBackColor = true;
            this.btnSideBar.Click += new System.EventHandler(this.BtnSideBar_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.FlatAppearance.BorderSize = 0;
            this.btnFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturacion.Location = new System.Drawing.Point(11, 337);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(230, 40);
            this.btnFacturacion.TabIndex = 40;
            this.btnFacturacion.Text = "     Facturación";
            this.btnFacturacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // btnValidacion
            // 
            this.btnValidacion.FlatAppearance.BorderSize = 0;
            this.btnValidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidacion.ForeColor = System.Drawing.Color.White;
            this.btnValidacion.Image = ((System.Drawing.Image)(resources.GetObject("btnValidacion.Image")));
            this.btnValidacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidacion.Location = new System.Drawing.Point(11, 296);
            this.btnValidacion.Name = "btnValidacion";
            this.btnValidacion.Size = new System.Drawing.Size(230, 40);
            this.btnValidacion.TabIndex = 39;
            this.btnValidacion.Text = "     Validar pago";
            this.btnValidacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidacion.UseVisualStyleBackColor = true;
            // 
            // btnEstadistica
            // 
            this.btnEstadistica.FlatAppearance.BorderSize = 0;
            this.btnEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadistica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadistica.ForeColor = System.Drawing.Color.White;
            this.btnEstadistica.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadistica.Image")));
            this.btnEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadistica.Location = new System.Drawing.Point(12, 256);
            this.btnEstadistica.Name = "btnEstadistica";
            this.btnEstadistica.Size = new System.Drawing.Size(230, 40);
            this.btnEstadistica.TabIndex = 38;
            this.btnEstadistica.Text = "     Estadísticas";
            this.btnEstadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadistica.UseVisualStyleBackColor = true;
            // 
            // btnReporteria
            // 
            this.btnReporteria.FlatAppearance.BorderSize = 0;
            this.btnReporteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteria.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteria.ForeColor = System.Drawing.Color.White;
            this.btnReporteria.Image = ((System.Drawing.Image)(resources.GetObject("btnReporteria.Image")));
            this.btnReporteria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteria.Location = new System.Drawing.Point(12, 215);
            this.btnReporteria.Name = "btnReporteria";
            this.btnReporteria.Size = new System.Drawing.Size(230, 40);
            this.btnReporteria.TabIndex = 37;
            this.btnReporteria.Text = "     Reporteria";
            this.btnReporteria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteria.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.btnConvertir.FlatAppearance.BorderSize = 0;
            this.btnConvertir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.White;
            this.btnConvertir.Image = ((System.Drawing.Image)(resources.GetObject("btnConvertir.Image")));
            this.btnConvertir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConvertir.Location = new System.Drawing.Point(12, 175);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(230, 40);
            this.btnConvertir.TabIndex = 36;
            this.btnConvertir.Text = "     Convertir a .txt";
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SlidePanel.Location = new System.Drawing.Point(3, 134);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(6, 40);
            this.SlidePanel.TabIndex = 35;
            // 
            // btnHistorial
            // 
            this.btnHistorial.Enabled = false;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Location = new System.Drawing.Point(12, 134);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(230, 40);
            this.btnHistorial.TabIndex = 34;
            this.btnHistorial.Text = "     Historial GAP";
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(24, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(192, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Sistema de Preventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Resize += new System.EventHandler(this.FrmPrincipal_Resize);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSideBar;
        private System.Windows.Forms.Button btnFacturacion;
        private System.Windows.Forms.Button btnValidacion;
        private System.Windows.Forms.Button btnEstadistica;
        private System.Windows.Forms.Button btnReporteria;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

