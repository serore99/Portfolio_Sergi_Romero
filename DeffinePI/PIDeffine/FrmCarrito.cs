using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIDeffine.RecursosLocalizables;
using System.Threading;

namespace PIDeffine
{
    public partial class FrmCarrito : Form
    {

        public FrmCarrito()
        {
            InitializeComponent();
        }
        private int mouseX = 0, mouseY = 0;
        private bool mouseDown;

        private void AplicarIdioma()
        {
            lblCarrito.Text = StringRecursos.Carrito;
            lblCarritoVacio.Text = StringRecursos.CarritoVacio;
            lblCliente.Text = StringRecursos.Cliente;
            lblCodPostal.Text = StringRecursos.CodPostal;
            lblCorreo.Text = StringRecursos.CorreoElec;
            lblDireccion.Text = StringRecursos.Direccion;
            lblIdioma.Text = StringRecursos.Idioma;
            lblTotalPedido.Text = StringRecursos.TotalPedido;
            btnConfCompra.Text = StringRecursos.ConfCompra;
            bttComprar.Text = StringRecursos.Comprar;
            bttEliminarCarrito.Text = StringRecursos.EliminarCarrito;
            bttVolverCarrito.Text = StringRecursos.VolverCarrito;
        }

        private void paneldecontrol_MouseDown(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
            mouseDown = true;
        }

        private void paneldecontrol_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void paneldecontrol_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int newX = this.Left + (e.X - mouseX);
                int newY = this.Top + (e.Y - mouseY);
                this.Location = new Point(newX, newY);
            }
        }

        private void pcbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pcbLogOut_Click(object sender, EventArgs e)
        {
            DialogResult logOut = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (logOut == DialogResult.Yes)
            {
                FrmInicio frm = new FrmInicio();
                frm.Show();
                Cliente.clienteLogeado.Clear();
                this.Hide();
            }
        }

        private void pcbVolver_Click(object sender, EventArgs e)
        {
            FrmTienda frm = new FrmTienda();
            frm.Show();
            this.Hide();
        }

        private void pcbCerrar_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Form formulario = Application.OpenForms[i];

                formulario.Close();
                formulario.Dispose();
            }
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            if (Producto.carrito.Count == 0)
            {
                CarritoVacio();
            }
            btnConfCompra.Visible = false;
            grbComprar.Visible = false;
            if (Producto.carrito.Count != 0)
            {
                dgvCarrito.DataSource = Producto.carrito;
                dgvCarrito.Columns["IdProducto"].Visible = false;
                dgvCarrito.Columns["Stock"].Visible = false;
                dgvCarrito.Columns["Imagen"].Visible = false;
            }
            decimal importeTotal = 0;
            for (int i = 0; i < Producto.carrito.Count; i++)
            {
                importeTotal += Producto.carrito[i].Subtotal;
            }
            lblPrecioTotalCamb.Text = importeTotal.ToString();
        }



        private void bttEliminarCarrito_Click(object sender, EventArgs e)
        {
            Producto.carrito.Clear();
            MessageBox.Show("Se ha eliminado el carrito");
            CarritoVacio();
        }

        private void bttComprar_Click(object sender, EventArgs e)
        {
            grbComprar.Show();
            btnConfCompra.Show();
            bttVolverCarrito.Show();
            bttComprar.Hide();
            dgvCarrito.Hide();
            lblPrecioTotalCamb.Hide();
            lblTotalPedido.Hide();
            bttEliminarCarrito.Hide();
            txtCliente.Text = Cliente.clienteLogeado[0].Nombre + " " + Cliente.clienteLogeado[0].Apellidos;
            txtCorreo.Text = Cliente.clienteLogeado[0].Correo;
            string direccion = txtDireccion.Text;

        }
        private void bttVolverCarrito_Click(object sender, EventArgs e)
        {
            if (Producto.carrito.Count == 0)
            {
                CarritoVacio();
            }
            else
            {
                grbComprar.Hide();
                btnConfCompra.Hide();
                bttVolverCarrito.Hide();
                bttComprar.Show();
                dgvCarrito.Show();
                bttEliminarCarrito.Show();
                lblTotalPedido.Show();
                lblPrecioTotalCamb.Show();
            }
        }

        private void btnConfCompra_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text != "" && txtCodPostal.Text != "")
            {

                string direccion = txtDireccion.Text;
                int idCliente = Cliente.clienteLogeado[0].IdCliente;
                string fechaString = DateTime.Now.ToString("yyyy-MM-dd");
                DateTime fecha = DateTime.ParseExact(fechaString, "yyyy-MM-dd", CultureInfo.InvariantCulture);

                ConBD.AbrirConexion();

                for (int i = 0; i < Producto.carrito.Count; i++)
                {
                    int idProd = Producto.carrito[i].IdProducto;
                    int cantidad = Producto.carrito[i].Cantidad;
                    Producto.RestarStock(idProd, cantidad);
                }

                decimal importeTotal = 0;
                for (int i = 0; i < Producto.carrito.Count; i++)
                {
                    importeTotal += Producto.carrito[i].Subtotal;
                }

                Pedido.AgregarPedido(idCliente, fecha, importeTotal, direccion);
                int idPedido = Pedido.RecogerIdPedido(idCliente, fechaString, direccion, importeTotal);

                for (int i = 0; i < Producto.carrito.Count; i++)
                {
                    Producto.AgregarDetallesPedido(idPedido, Producto.carrito[i].IdProducto, Producto.carrito[i].Cantidad, Producto.carrito[i].Subtotal);
                }
                Producto.carrito.Clear();
                MessageBox.Show("Tu compra se ha realizado correctamente. Gracias por confiar en nostros");
                CarritoVacio();
                ConBD.CerrarConexion();
            }
            else MessageBox.Show("Debes rellenar todos los campos para poder realizar la compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pcbspain_Click(object sender, EventArgs e)
        {
            IdiomaIngles();
            pcbspain.Hide();
            pcbingle.Show();
        }

        private void pcbingle_Click(object sender, EventArgs e)
        {
            IdiomaSpanish();
            pcbingle.Hide();
            pcbspain.Show();
        }
        private void IdiomaIngles()
        {
            string cultura = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
        }
        private void IdiomaSpanish()
        {
            string cultura = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();

        }
        private void CarritoVacio()
        {
            lblCarritoVacio.Show();
            dgvCarrito.Hide();
            bttComprar.Hide();
            bttEliminarCarrito.Hide();
            dgvCarrito.Hide();
            grbComprar.Hide();
            btnConfCompra.Hide();
            bttVolverCarrito.Hide();
            lblPrecioTotalCamb.Hide();
            lblTotalPedido.Hide();
        }
    }
}
