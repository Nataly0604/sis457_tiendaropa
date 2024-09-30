using CadTiendaropa;
<<<<<<< HEAD
using ClnTiendaropa;
=======
>>>>>>> 13b0a28cbd030d805b9f7a07b2c6dd1e22e95479
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sis457_tiendaropa
{
    public partial class Inicio : Form
    {

<<<<<<< HEAD
        public static Usuario  usuarioActual;
        private static IconMenuItem menuActual=null;
        private static Form formularioActual = null;

        public Inicio(Usuario objusuario=null)
        {
            //if (objusuario == null)
            //    usuarioActual = new Usuario() { usuarioRegistro = "ADMIN", id = 1, usuario1 = "ADMIN", clave="123" };
            //else
                usuarioActual = objusuario;

=======
        private static Usuario  usuarioActual;
        private static IconMenuItem menuActual=null;
        private static Form formularioActual = null;

        public Inicio(Usuario objusuario)
        {
            usuarioActual=objusuario;
>>>>>>> 13b0a28cbd030d805b9f7a07b2c6dd1e22e95479
            InitializeComponent();
        }


        private void abrirFormulario(IconMenuItem menu, Form formulario)
        {
            
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
          
            menuActual=menu;
            if (formulario != null)
            {
                formularioActual = formulario;
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
          
               

                contenedor.Controls.Add(formulario);
                contenedor.Tag = formulario;
                formulario.BringToFront();
                formulario.Show();
            }


        }

        private void Inicio_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            List<Permiso> listapermisos = new PermisosCln().listar(usuarioActual.id);

            foreach(IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado=listapermisos.Any(x => x.nombreMenu == iconmenu.Name);
                if (encontrado)
                {
                    iconmenu.Visible = true;
                }
                else
                {
                    iconmenu.Visible = false;
                }
            }

            userActual.Text = usuarioActual.usuario1;
        }



=======
            userActual.Text = usuarioActual.usuario1;
        }

        private void menuusuario_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }
>>>>>>> 13b0a28cbd030d805b9f7a07b2c6dd1e22e95479

        private void submenuCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmCategoria());

        }

        private void submenuProducto_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            abrirFormulario((IconMenuItem)sender, new FrmProducto());
=======
            abrirFormulario((IconMenuItem)sender, new frmProducto());
>>>>>>> 13b0a28cbd030d805b9f7a07b2c6dd1e22e95479
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submenuregistrar_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmVentas());
        }

        private void submenuverdetalle_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmDetalleVentas());
        }

        private void submenuregistraventa_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmcompras());
        }

        private void submenuverdetallecompra_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmDetalleCompra());
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmClientes());
        }

        private void menuproveedores_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmProveedores());
        }

        private void menureportes_Click(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmReportes());
        }

        private void menuventas_Click(object sender, EventArgs e)
        {

        }

        private void submenuCategoria_Click_1(object sender, EventArgs e)
        {
            abrirFormulario((IconMenuItem)sender, new frmCategoria());
        }

        private void submenuProducto_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            abrirFormulario((IconMenuItem)sender, new FrmProducto());
        }

        private void menuusuarios_Click(object sender, EventArgs e)
        {

     
                abrirFormulario((IconMenuItem)sender, new frmUsuarios());
            
=======
            abrirFormulario((IconMenuItem)sender, new frmProducto());
>>>>>>> 13b0a28cbd030d805b9f7a07b2c6dd1e22e95479
        }
    }
}
