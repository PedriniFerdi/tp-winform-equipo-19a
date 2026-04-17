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
            Codigo.Location = new Point(43, 37);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(46, 15);
            Codigo.TabIndex = 0;
            Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(43, 75);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            Descripcion.AutoSize = true;
            Descripcion.Location = new Point(43, 108);
            Descripcion.Name = "Descripcion";
            Descripcion.Size = new Size(69, 15);
            Descripcion.TabIndex = 2;
            Descripcion.Text = "Descripcion";
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(43, 140);
            Precio.Name = "Precio";
            Precio.Size = new Size(40, 15);
            Precio.TabIndex = 3;
            Precio.Text = "Precio";
            // 
            // Marca
            // 
            Marca.AutoSize = true;
            Marca.Location = new Point(43, 178);
            Marca.Name = "Marca";
            Marca.Size = new Size(40, 15);
            Marca.TabIndex = 4;
            Marca.Text = "Marca";
            // 
            // Categoria
            // 
            Categoria.AutoSize = true;
            Categoria.Location = new Point(43, 218);
            Categoria.Name = "Categoria";
            Categoria.Size = new Size(58, 15);
            Categoria.TabIndex = 5;
            Categoria.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 257);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 6;
            label7.Text = "UrlImagen";
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(124, 34);
            textCodigo.Margin = new Padding(3, 2, 3, 2);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(143, 23);
            textCodigo.TabIndex = 7;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(124, 73);
            textNombre.Margin = new Padding(3, 2, 3, 2);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(143, 23);
            textNombre.TabIndex = 8;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(124, 108);
            textDescripcion.Margin = new Padding(3, 2, 3, 2);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(143, 23);
            textDescripcion.TabIndex = 9;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(124, 140);
            textPrecio.Margin = new Padding(3, 2, 3, 2);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(143, 23);
            textPrecio.TabIndex = 10;
            // 
            // cbMarca
            // 
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(124, 178);
            cbMarca.Margin = new Padding(3, 2, 3, 2);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(143, 23);
            cbMarca.TabIndex = 11;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(124, 218);
            cbCategoria.Margin = new Padding(3, 2, 3, 2);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(143, 23);
            cbCategoria.TabIndex = 12;
            // 
            // btnAgregarImagenes
            // 
            btnAgregarImagenes.Location = new Point(124, 254);
            btnAgregarImagenes.Margin = new Padding(3, 2, 3, 2);
            btnAgregarImagenes.Name = "btnAgregarImagenes";
            btnAgregarImagenes.Size = new Size(98, 22);
            btnAgregarImagenes.TabIndex = 13;
            btnAgregarImagenes.Text = "Agregar";
            btnAgregarImagenes.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(313, 104);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(81, 28);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(313, 165);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(81, 28);
            button1.TabIndex = 15;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmAgregarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 304);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAgregarProducto";
            Text = "AgregarProducto";
            Load += frmAgregarProducto_Load;
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
