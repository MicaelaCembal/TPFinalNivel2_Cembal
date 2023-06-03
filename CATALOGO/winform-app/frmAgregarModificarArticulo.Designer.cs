
namespace winform_app
{
    partial class frmAgregarModificarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodigo = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtImagenUrl = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxImagenUrl = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.AutoSize = true;
            this.txtCodigo.Location = new System.Drawing.Point(41, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(56, 17);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Text = "Codigo:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(147, 161);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 24);
            this.cbCategoria.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Location = new System.Drawing.Point(44, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(62, 17);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre:";
            this.txtNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Location = new System.Drawing.Point(44, 123);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(86, 17);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.Text = "Descripcion:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.AutoSize = true;
            this.txtCategoria.Location = new System.Drawing.Point(44, 161);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(73, 17);
            this.txtCategoria.TabIndex = 4;
            this.txtCategoria.Text = "Categoria:";
            // 
            // txtMarca
            // 
            this.txtMarca.AutoSize = true;
            this.txtMarca.Location = new System.Drawing.Point(46, 202);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(51, 17);
            this.txtMarca.TabIndex = 6;
            this.txtMarca.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(147, 199);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 24);
            this.cbMarca.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(49, 285);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(52, 17);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "Precio:";
            this.txtPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.AutoSize = true;
            this.txtImagenUrl.Location = new System.Drawing.Point(46, 239);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(90, 17);
            this.txtImagenUrl.TabIndex = 7;
            this.txtImagenUrl.Text = "Imagen URL:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(147, 37);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxCodigo.TabIndex = 9;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(147, 85);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 10;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(147, 123);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescripcion.TabIndex = 11;
            // 
            // textBoxImagenUrl
            // 
            this.textBoxImagenUrl.Location = new System.Drawing.Point(147, 234);
            this.textBoxImagenUrl.Name = "textBoxImagenUrl";
            this.textBoxImagenUrl.Size = new System.Drawing.Size(100, 22);
            this.textBoxImagenUrl.TabIndex = 12;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(147, 280);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrecio.TabIndex = 13;
            // 
            // frmAgregarModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.textBoxImagenUrl);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.txtCodigo);
            this.Name = "frmAgregarModificarArticulo";
            this.Text = "frmAgregarModificarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCodigo;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label txtCategoria;
        private System.Windows.Forms.Label txtMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtImagenUrl;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxImagenUrl;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}