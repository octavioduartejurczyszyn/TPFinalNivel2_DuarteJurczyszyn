using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using dominio;
using Negocio;

namespace Presentación
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCategoria.Items.Add("Celulares");
            cboCategoria.Items.Add("Media");
            cboCategoria.Items.Add("Televisores");

            cboPrecio.Items.Add("de 0 a 100.00");
            cboPrecio.Items.Add("de 101.00 a 10000.00");
            cboPrecio.Items.Add("Más de 10000.00");

            cboMarca.Items.Add("Samsung");
            cboMarca.Items.Add("Apple");
            cboMarca.Items.Add("Sony");
            cboMarca.Items.Add("Huawei");
            cboMarca.Items.Add("Motorola");

        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }
         private void cargar()
         {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["Imagenurl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void cargarImagen(string imagen)
            {
                try
                {
                    pbxArticulo.Load(imagen);
                }
                catch (Exception ex)
                {
                    pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
            cargar();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulos modificar = new frmAltaArticulos(seleccionado);
            modificar.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que quieres eliminarlo?", "Eliminando.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);

                    cargar();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una opción en cada campo.");
                return true;
            }
            if (cboMarca.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una opción en cada campo.");
                return true;
            }
            if (cboPrecio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una opción en cada campo.");
                return true;
            }
            return false;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string categoria = cboCategoria.SelectedItem.ToString();
                string marca = cboMarca.SelectedItem.ToString();
                string precio = cboPrecio.SelectedItem.ToString();
                dgvArticulos.DataSource = negocio.filtrar(categoria, marca, precio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cboPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmVerDetalle verDetalle = new frmVerDetalle(seleccionado);
            verDetalle.ShowDialog();
        }
        private void btnArticulos_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}

    


    
