using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dominio;
using catalogo;

namespace winform_app
{
    public partial class frmAgregarModificarArticulo : Form
    {
        private Articulo articulo;
        private CategoriaArticulo categoriaArticulo;
        private MarcaArticulo marcaArticulo;
        private bool esNuevo;
    
        public frmAgregarModificarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            categoriaArticulo = new CategoriaArticulo();
            marcaArticulo = new MarcaArticulo();
        }

        private void frmAgregarModificarArticulo_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            CargarMarcas();

            if (articulo != null)
            {
                esNuevo = false;
                Text = "Modificar Artículo";
                textBoxCodigo.Text = articulo.Codigo;
                textBoxNombre.Text = articulo.Nombre;
                textBoxDescripcion.Text = articulo.Descripcion;
                cbCategoria.SelectedValue = articulo.IdCategoria;
                cbMarca.SelectedValue = articulo.IdMarca;
                textBoxImagenUrl.Text = articulo.ImagenUrl;
                textBoxPrecio.Text = articulo.Precio.ToString();
            }
            else
            {
                esNuevo = true;
                Text = "Agregar Artículo";
                cbCategoria.SelectedIndex = -1;
                cbMarca.SelectedIndex = -1;
                //btnEliminar.Visible = false; // Ocultar el botón de eliminar para nuevos artículos
            }
        }

        private void CargarCategorias()
        {
            List<Categoria> categorias = categoriaArticulo.listar();
            cbCategoria.DataSource = categorias;
            cbCategoria.DisplayMember = "Descripcion";
            cbCategoria.ValueMember = "Id";
        }

        private void CargarMarcas()
        {
            List<Marca> marcas = marcaArticulo.listar();
            cbMarca.DataSource = marcas;
            cbMarca.DisplayMember = "Descripcion";
            cbMarca.ValueMember = "Id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (esNuevo)
                {
                    Articulo nuevoArticulo = new Articulo();
                    nuevoArticulo.Codigo = txtCodigo.Text;
                    nuevoArticulo.Nombre = txtNombre.Text;
                    nuevoArticulo.Descripcion = txtDescripcion.Text;
                    nuevoArticulo.IdCategoria = (int)cbCategoria.SelectedValue;
                    nuevoArticulo.IdMarca = (int)cbMarca.SelectedValue;
                    nuevoArticulo.ImagenUrl = txtImagenUrl.Text;
                    nuevoArticulo.Precio = decimal.Parse(txtPrecio.Text);

                    try
                    {
                        ArticuloCatalogo articuloCatalogo = new ArticuloCatalogo();
                        articuloCatalogo.agregar(nuevoArticulo);
                        MessageBox.Show("Artículo agregado correctamente.", "Agregar Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al agregar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.IdCategoria = (int)cbCategoria.SelectedValue;
                    articulo.IdMarca = (int)cbMarca.SelectedValue;
                    articulo.ImagenUrl = txtImagenUrl.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);

                    try
                    {
                        ArticuloCatalogo articuloCatalogo = new ArticuloCatalogo();
                        articuloCatalogo.modificar(articulo);
                        MessageBox.Show("Artículo modificado correctamente.", "Modificar Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al modificar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       /* private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("¿Está seguro de eliminar este artículo?", "Eliminar Artículo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    ArticuloCatalogo articuloCatalogo = new ArticuloCatalogo();
                    articuloCatalogo.eliminar(articulo);
                    MessageBox.Show("Artículo eliminado correctamente.", "Eliminar Artículo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

        private bool ValidarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un código.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
