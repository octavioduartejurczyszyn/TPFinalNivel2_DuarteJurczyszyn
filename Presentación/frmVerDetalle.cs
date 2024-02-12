using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;

namespace Presentación
{
    public partial class frmVerDetalle : Form
    {
        private Articulo articulo = null;
        private OpenFileDialog archivo = null;
        private List<Articulo> listaArticulo;
   
        public frmVerDetalle()
        {
            InitializeComponent();
        }
        public frmVerDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle artículo";
        }
        private void frmVerDetalle_Load(object sender, EventArgs e)
        {
            if (articulo != null)
            {
                List<Articulo> detalles = new List<Articulo> { articulo };
                dgvVerDetalle.DataSource = detalles;
                ocultarColumnas();
                cargarImagen(articulo.ImagenUrl);
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxVerDetalle.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxVerDetalle.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void ocultarColumnas()
        {
            dgvVerDetalle.Columns["Imagenurl"].Visible = false;
            dgvVerDetalle.Columns["Id"].Visible = false;
        }
    }
}
