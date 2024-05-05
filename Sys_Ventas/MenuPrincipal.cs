using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sys_Ventas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }

        private void PersonalizarDiseño()
        {
            panelSubMenu.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelSubMenu.Visible == true)  panelSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnFormulariosSubmenu_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu);
        }

        private void btnSubMarcas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Marcas());
            //codigo de abrir formulario
            OcultarSubMenu();
        }

        private void btnSubCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Categorias());  
            //codigo de abrir formulario
            OcultarSubMenu();
        }

        private void btnSubProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Proveedores());
            //codigo de abrir formulario
            OcultarSubMenu();
        }

        private void btnSubPuestos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Puestos());
            //codigo de abrir formulario
            OcultarSubMenu();
        }

        private Form activeForm = null;
        private void AbrirFormularioHijo(Form childForm)
        {
            if (activeForm != null) activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Ventas());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Empleados());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Clientes());
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FRM_Inventario());
        }
    }
}
