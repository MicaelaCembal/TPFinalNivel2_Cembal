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
using catalogo;

namespace winform_app
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;

        public frmArticulos()
        {
            InitializeComponent();
        }

        private void pictureBoxImagenArticulo_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en la imagen del artículo
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en el elemento de menú "Agregar"
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en el elemento de menú "Modificar"
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Código para manejar el evento de clic en el elemento de menú "Eliminar"
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código para manejar el evento de clic en una celda del DataGridView
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            ocultarColumnas();
        }

        private void cargar()
        {
            ArticuloCatalogo arti = new ArticuloCatalogo();
            try
            {
                listaArticulo = arti.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pictureBoxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código para manejar el evento de cambio de selección en el ComboBox
        }
    }
}
