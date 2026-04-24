namespace WinFormsApp
{
    partial class ListaDeArticulos
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
            this.lblFiltroRapido = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.pbxArt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnBuscarFiltro = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImagenAnterior = new System.Windows.Forms.Button();
            this.btnImagenSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroRapido
            // 
            this.lblFiltroRapido.AutoSize = true;
            this.lblFiltroRapido.Location = new System.Drawing.Point(32, 46);
            this.lblFiltroRapido.Name = "lblFiltroRapido";
            this.lblFiltroRapido.Size = new System.Drawing.Size(78, 16);
            this.lblFiltroRapido.TabIndex = 0;
            this.lblFiltroRapido.Text = "Filtro rapido";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(116, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(368, 22);
            this.txtFiltro.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(490, 41);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 27);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(35, 142);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.RowHeadersVisible = false;
            this.dgvListaProd.RowHeadersWidth = 51;
            this.dgvListaProd.RowTemplate.Height = 24;
            this.dgvListaProd.Size = new System.Drawing.Size(810, 407);
            this.dgvListaProd.TabIndex = 4;
            this.dgvListaProd.SelectionChanged += new System.EventHandler(this.dgvListaProd_SelectionChanged);
            // 
            // pbxArt
            // 
            this.pbxArt.Location = new System.Drawing.Point(886, 142);
            this.pbxArt.Name = "pbxArt";
            this.pbxArt.Size = new System.Drawing.Size(416, 407);
            this.pbxArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArt.TabIndex = 5;
            this.pbxArt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1053, 606);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Imagen 0/0";
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(35, 585);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(198, 37);
            this.btnAgregarArticulo.TabIndex = 7;
            this.btnAgregarArticulo.Text = "Agregar articulo";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(548, 585);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(198, 37);
            this.btnEliminarArticulo.TabIndex = 8;
            this.btnEliminarArticulo.Text = "Eliminar articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(286, 585);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(198, 37);
            this.btnModificarArticulo.TabIndex = 9;
            this.btnModificarArticulo.Text = "Modificar articulo";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(32, 93);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(283, 93);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(518, 93);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(39, 16);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro ";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(89, 88);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(164, 24);
            this.cbCampo.TabIndex = 13;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(338, 90);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(164, 24);
            this.cbCriterio.TabIndex = 14;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(563, 90);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(164, 22);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // btnBuscarFiltro
            // 
            this.btnBuscarFiltro.Location = new System.Drawing.Point(733, 88);
            this.btnBuscarFiltro.Name = "btnBuscarFiltro";
            this.btnBuscarFiltro.Size = new System.Drawing.Size(75, 26);
            this.btnBuscarFiltro.TabIndex = 16;
            this.btnBuscarFiltro.Text = "Buscar";
            this.btnBuscarFiltro.UseVisualStyleBackColor = true;
            this.btnBuscarFiltro.Click += new System.EventHandler(this.btnBuscarFiltro_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(814, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(128, 26);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refrescar lista";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImagenAnterior
            // 
            this.btnImagenAnterior.Location = new System.Drawing.Point(1001, 566);
            this.btnImagenAnterior.Name = "btnImagenAnterior";
            this.btnImagenAnterior.Size = new System.Drawing.Size(75, 23);
            this.btnImagenAnterior.TabIndex = 18;
            this.btnImagenAnterior.Text = "←";
            this.btnImagenAnterior.UseVisualStyleBackColor = true;
            this.btnImagenAnterior.Click += new System.EventHandler(this.btnImagenAnterior_Click);
            // 
            // btnImagenSiguiente
            // 
            this.btnImagenSiguiente.Location = new System.Drawing.Point(1106, 566);
            this.btnImagenSiguiente.Name = "btnImagenSiguiente";
            this.btnImagenSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnImagenSiguiente.TabIndex = 19;
            this.btnImagenSiguiente.Text = "→";
            this.btnImagenSiguiente.UseVisualStyleBackColor = true;
            this.btnImagenSiguiente.Click += new System.EventHandler(this.btnImagenSiguiente_Click);
            // 
            // ListaDeArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 689);
            this.Controls.Add(this.btnImagenSiguiente);
            this.Controls.Add(this.btnImagenAnterior);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBuscarFiltro);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxArt);
            this.Controls.Add(this.dgvListaProd);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltroRapido);
            this.Name = "ListaDeArticulos";
            this.Text = "Lista de Articulos";
            this.Load += new System.EventHandler(this.ListaDeArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFiltroRapido;
        private TextBox txtFiltro;
        private Button btnFiltrar;
        private DataGridView dgvListaProd;
        private PictureBox pbxArt;
        private Label label1;
        private Button btnAgregarArticulo;
        private Button btnEliminarArticulo;
        private Button btnModificarArticulo;
        private Label lblCampo;
        private Label lblCriterio;
        private Label lblFiltro;
        private ComboBox cbCampo;
        private ComboBox cbCriterio;
        private TextBox txtFiltroAvanzado;
        private Button btnBuscarFiltro;
        private Button btnRefresh;
        private Button btnImagenAnterior;
        private Button btnImagenSiguiente;
    }
}