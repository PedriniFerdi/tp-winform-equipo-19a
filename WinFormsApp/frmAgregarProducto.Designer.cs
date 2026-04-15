namespace WinFormsApp
{
    partial class frmAgregarProducto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Codigo = new Label();
            Nombre = new Label();
            Descripcion = new Label();
            Precio = new Label();
            Marca = new Label();
            Categoria = new Label();
            label7 = new Label();
            textCodigo = new TextBox();
            textNombre = new TextBox();
            textDescripcion = new TextBox();
            textPrecio = new TextBox();
            cbMarca = new ComboBox();
            cbCategoria = new ComboBox();
            btnAgregarImagenes = new Button();
            btnAceptar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Codigo
            // 
            Codigo.AutoSize = true;
            Codigo.Location = new Point(49, 49);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(58, 20);
            Codigo.TabIndex = 0;
            Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(49, 100);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(49, 144);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(87, 20);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(49, 187);
            Precio.Name = "Precio";
            Precio.Size = new Size(50, 20);
            Precio.TabIndex = 3;
            Precio.Text = "Precio";
            // 
            // Marca
            // 
            Marca.AutoSize = true;
            Marca.Location = new Point(49, 238);
            Marca.Name = "Marca";
            Marca.Size = new Size(50, 20);
            Marca.TabIndex = 4;
            Marca.Text = "Marca";
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(49, 290);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(74, 20);
            Categoria.TabIndex = 5;
            Categoria.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 343);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "UrlImagen";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(142, 46);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(163, 27);
            textCodigo.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(142, 97);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(163, 27);
            textNombre.TabIndex = 8;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(142, 144);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(163, 27);
            textDescripcion.TabIndex = 9;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(142, 187);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(163, 27);
            textPrecio.TabIndex = 10;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(142, 238);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(163, 28);
            cbMarca.TabIndex = 11;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(142, 290);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(163, 28);
            cbCategoria.TabIndex = 12;
            // 
            // btnAgregarImagenes
            // 
            btnAgregarImagenes.Location = new Point(142, 339);
            btnAgregarImagenes.Name = "btnAgregarImagenes";
            btnAgregarImagenes.Size = new Size(112, 29);
            btnAgregarImagenes.TabIndex = 13;
            btnAgregarImagenes.Text = "Agregar";
            btnAgregarImagenes.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(358, 138);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 38);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(358, 220);
            button1.Name = "button1";
            button1.Size = new Size(93, 38);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 405);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(btnAgregarImagenes);
            Controls.Add(cbCategoria);
            Controls.Add(cbMarca);
            Controls.Add(textPrecio);
            Controls.Add(textDescripcion);
            Controls.Add(textNombre);
            Controls.Add(textCodigo);
            Controls.Add(label7);
            Controls.Add(Categoria);
            Controls.Add(Marca);
            Controls.Add(Precio);
            Controls.Add(Descripcion);
            Controls.Add(Nombre);
            Controls.Add(Codigo);
            Name = "frmAgregarProducto";
            Text = "AgregarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Codigo;
        private Label Nombre;
        private Label Descripcion;
        private Label Precio;
        private Label Marca;
        private Label Categoria;
        private Label label7;
        private TextBox textCodigo;
        private TextBox textNombre;
        private TextBox textDescripcion;
        private TextBox textPrecio;
        private ComboBox cbMarca;
        private ComboBox cbCategoria;
        private Button btnAgregarImagenes;
        private Button btnAceptar;
        private Button button1;
    }
}
