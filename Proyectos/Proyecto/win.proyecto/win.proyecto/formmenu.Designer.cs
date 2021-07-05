namespace win.proyecto
{
    partial class formmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codigoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioDeSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesDelDiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesContabilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDePlanillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesProduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.reporteriaToolStripMenuItem,
            this.transaccionesToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.rentarToolStripMenuItem,
            this.codigoDeProductosToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // rentarToolStripMenuItem
            // 
            this.rentarToolStripMenuItem.Name = "rentarToolStripMenuItem";
            this.rentarToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.rentarToolStripMenuItem.Text = "Rentar";
            // 
            // codigoDeProductosToolStripMenuItem
            // 
            this.codigoDeProductosToolStripMenuItem.Name = "codigoDeProductosToolStripMenuItem";
            this.codigoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.codigoDeProductosToolStripMenuItem.Text = "Codigo de Productos";
            // 
            // reporteriaToolStripMenuItem
            // 
            this.reporteriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteProductosToolStripMenuItem,
            this.reporteClientesToolStripMenuItem});
            this.reporteriaToolStripMenuItem.Name = "reporteriaToolStripMenuItem";
            this.reporteriaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.reporteriaToolStripMenuItem.Text = "Formulario";
            // 
            // reporteProductosToolStripMenuItem
            // 
            this.reporteProductosToolStripMenuItem.Name = "reporteProductosToolStripMenuItem";
            this.reporteProductosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.reporteProductosToolStripMenuItem.Text = "Formulario de Mantenimiento";
            this.reporteProductosToolStripMenuItem.Click += new System.EventHandler(this.reporteProductosToolStripMenuItem_Click);
            // 
            // reporteClientesToolStripMenuItem
            // 
            this.reporteClientesToolStripMenuItem.Name = "reporteClientesToolStripMenuItem";
            this.reporteClientesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.reporteClientesToolStripMenuItem.Text = "Formulario de Cliente";
            this.reporteClientesToolStripMenuItem.Click += new System.EventHandler(this.reporteClientesToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioDeSesionToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // inicioDeSesionToolStripMenuItem
            // 
            this.inicioDeSesionToolStripMenuItem.Name = "inicioDeSesionToolStripMenuItem";
            this.inicioDeSesionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.inicioDeSesionToolStripMenuItem.Text = "Inicio de Sesion";
            this.inicioDeSesionToolStripMenuItem.Click += new System.EventHandler(this.inicioDeSesionToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesDelDiaToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // transaccionesDelDiaToolStripMenuItem
            // 
            this.transaccionesDelDiaToolStripMenuItem.Name = "transaccionesDelDiaToolStripMenuItem";
            this.transaccionesDelDiaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.transaccionesDelDiaToolStripMenuItem.Text = "Transacciones del dia";
            this.transaccionesDelDiaToolStripMenuItem.Click += new System.EventHandler(this.transaccionesDelDiaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesContabilidadToolStripMenuItem,
            this.reportesDePlanillaToolStripMenuItem,
            this.reportesProduccionToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesContabilidadToolStripMenuItem
            // 
            this.reportesContabilidadToolStripMenuItem.Name = "reportesContabilidadToolStripMenuItem";
            this.reportesContabilidadToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportesContabilidadToolStripMenuItem.Text = "Reportes Contabilidad";
            this.reportesContabilidadToolStripMenuItem.Click += new System.EventHandler(this.reportesContabilidadToolStripMenuItem_Click);
            // 
            // reportesDePlanillaToolStripMenuItem
            // 
            this.reportesDePlanillaToolStripMenuItem.Name = "reportesDePlanillaToolStripMenuItem";
            this.reportesDePlanillaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportesDePlanillaToolStripMenuItem.Text = "Reportes de Planilla";
            this.reportesDePlanillaToolStripMenuItem.Click += new System.EventHandler(this.reportesDePlanillaToolStripMenuItem_Click);
            // 
            // reportesProduccionToolStripMenuItem
            // 
            this.reportesProduccionToolStripMenuItem.Name = "reportesProduccionToolStripMenuItem";
            this.reportesProduccionToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.reportesProduccionToolStripMenuItem.Text = "Reportes Produccion";
            this.reportesProduccionToolStripMenuItem.Click += new System.EventHandler(this.reportesProduccionToolStripMenuItem_Click);
            // 
            // formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formmenu";
            this.Text = "Menu Ferreteria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codigoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioDeSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesDelDiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesContabilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDePlanillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesProduccionToolStripMenuItem;
    }
}

