namespace Sys_Ventas
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnSubPuestos = new System.Windows.Forms.Button();
            this.btnSubProveedores = new System.Windows.Forms.Button();
            this.btnSubCategorias = new System.Windows.Forms.Button();
            this.btnSubMarcas = new System.Windows.Forms.Button();
            this.btnFormulariosSubmenu = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.AutoScroll = true;
            this.panelMenuLateral.BackColor = System.Drawing.Color.Gold;
            this.panelMenuLateral.Controls.Add(this.panelSubMenu);
            this.panelMenuLateral.Controls.Add(this.btnFormulariosSubmenu);
            this.panelMenuLateral.Controls.Add(this.btnInventario);
            this.panelMenuLateral.Controls.Add(this.btnClientes);
            this.panelMenuLateral.Controls.Add(this.btnEmpleados);
            this.panelMenuLateral.Controls.Add(this.btnVentas);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(250, 564);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.DimGray;
            this.panelSubMenu.Controls.Add(this.btnSubPuestos);
            this.panelSubMenu.Controls.Add(this.btnSubProveedores);
            this.panelSubMenu.Controls.Add(this.btnSubCategorias);
            this.panelSubMenu.Controls.Add(this.btnSubMarcas);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 396);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(250, 168);
            this.panelSubMenu.TabIndex = 6;
            // 
            // btnSubPuestos
            // 
            this.btnSubPuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubPuestos.FlatAppearance.BorderSize = 0;
            this.btnSubPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSubPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubPuestos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubPuestos.ForeColor = System.Drawing.Color.White;
            this.btnSubPuestos.Location = new System.Drawing.Point(0, 120);
            this.btnSubPuestos.Name = "btnSubPuestos";
            this.btnSubPuestos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 10);
            this.btnSubPuestos.Size = new System.Drawing.Size(250, 40);
            this.btnSubPuestos.TabIndex = 3;
            this.btnSubPuestos.Text = "Puestos";
            this.btnSubPuestos.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubPuestos.UseVisualStyleBackColor = true;
            this.btnSubPuestos.Click += new System.EventHandler(this.btnSubPuestos_Click);
            // 
            // btnSubProveedores
            // 
            this.btnSubProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubProveedores.FlatAppearance.BorderSize = 0;
            this.btnSubProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSubProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubProveedores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubProveedores.ForeColor = System.Drawing.Color.White;
            this.btnSubProveedores.Location = new System.Drawing.Point(0, 80);
            this.btnSubProveedores.Name = "btnSubProveedores";
            this.btnSubProveedores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 10);
            this.btnSubProveedores.Size = new System.Drawing.Size(250, 40);
            this.btnSubProveedores.TabIndex = 2;
            this.btnSubProveedores.Text = "Proveedores";
            this.btnSubProveedores.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubProveedores.UseVisualStyleBackColor = true;
            this.btnSubProveedores.Click += new System.EventHandler(this.btnSubProveedores_Click);
            // 
            // btnSubCategorias
            // 
            this.btnSubCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubCategorias.FlatAppearance.BorderSize = 0;
            this.btnSubCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSubCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategorias.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCategorias.ForeColor = System.Drawing.Color.White;
            this.btnSubCategorias.Location = new System.Drawing.Point(0, 40);
            this.btnSubCategorias.Name = "btnSubCategorias";
            this.btnSubCategorias.Padding = new System.Windows.Forms.Padding(35, 0, 0, 10);
            this.btnSubCategorias.Size = new System.Drawing.Size(250, 40);
            this.btnSubCategorias.TabIndex = 1;
            this.btnSubCategorias.Text = "Categorías";
            this.btnSubCategorias.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubCategorias.UseVisualStyleBackColor = true;
            this.btnSubCategorias.Click += new System.EventHandler(this.btnSubCategorias_Click);
            // 
            // btnSubMarcas
            // 
            this.btnSubMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubMarcas.FlatAppearance.BorderSize = 0;
            this.btnSubMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnSubMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubMarcas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubMarcas.ForeColor = System.Drawing.Color.White;
            this.btnSubMarcas.Location = new System.Drawing.Point(0, 0);
            this.btnSubMarcas.Name = "btnSubMarcas";
            this.btnSubMarcas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 10);
            this.btnSubMarcas.Size = new System.Drawing.Size(250, 40);
            this.btnSubMarcas.TabIndex = 0;
            this.btnSubMarcas.Text = "Marcas";
            this.btnSubMarcas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSubMarcas.UseVisualStyleBackColor = true;
            this.btnSubMarcas.Click += new System.EventHandler(this.btnSubMarcas_Click);
            // 
            // btnFormulariosSubmenu
            // 
            this.btnFormulariosSubmenu.BackColor = System.Drawing.Color.White;
            this.btnFormulariosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFormulariosSubmenu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFormulariosSubmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFormulariosSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormulariosSubmenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulariosSubmenu.ForeColor = System.Drawing.Color.Black;
            this.btnFormulariosSubmenu.Location = new System.Drawing.Point(0, 351);
            this.btnFormulariosSubmenu.Name = "btnFormulariosSubmenu";
            this.btnFormulariosSubmenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFormulariosSubmenu.Size = new System.Drawing.Size(250, 45);
            this.btnFormulariosSubmenu.TabIndex = 5;
            this.btnFormulariosSubmenu.Text = "Formularios";
            this.btnFormulariosSubmenu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFormulariosSubmenu.UseVisualStyleBackColor = false;
            this.btnFormulariosSubmenu.Click += new System.EventHandler(this.btnFormulariosSubmenu_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.White;
            this.btnInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.Location = new System.Drawing.Point(0, 306);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventario.Size = new System.Drawing.Size(250, 45);
            this.btnInventario.TabIndex = 4;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Location = new System.Drawing.Point(0, 261);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(250, 45);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.White;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleados.Location = new System.Drawing.Point(0, 216);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(250, 45);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.White;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Black;
            this.btnVentas.Location = new System.Drawing.Point(0, 171);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(250, 45);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Facturación";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 171);
            this.panelLogo.TabIndex = 0;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelChild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelChild.BackgroundImage")));
            this.panelChild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(684, 564);
            this.panelChild.TabIndex = 1;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 564);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelMenuLateral);
            this.MinimumSize = new System.Drawing.Size(950, 603);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D\'Smash Variedades";
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnFormulariosSubmenu;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSubCategorias;
        private System.Windows.Forms.Button btnSubMarcas;
        private System.Windows.Forms.Button btnSubPuestos;
        private System.Windows.Forms.Button btnSubProveedores;
        private System.Windows.Forms.Panel panelChild;
    }
}

