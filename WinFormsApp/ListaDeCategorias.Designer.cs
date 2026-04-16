namespace WinFormsApp
{
    partial class FrmCategorias
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
            DgvCategorias = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            labelNombre = new Label();
            txtNombreCategoria = new TextBox();
            labelCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // DgvCategorias
            // 
            DgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvCategorias.BackgroundColor = SystemColors.ControlLightLight;
            DgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCategorias.Location = new Point(30, 107);
            DgvCategorias.Name = "DgvCategorias";
            DgvCategorias.Size = new Size(605, 426);
            DgvCategorias.TabIndex = 0;
            DgvCategorias.CellContentClick += DgvCategorias_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(656, 107);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 27);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ControlLightLight;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(656, 192);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ControlLightLight;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(656, 268);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(317, 9);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(96, 23);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "Categorias ";
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.BackColor = SystemColors.HighlightText;
            txtNombreCategoria.Location = new Point(135, 58);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(157, 23);
            txtNombreCategoria.TabIndex = 5;
            txtNombreCategoria.TextChanged += txtNombreCategoria_TextChanged;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(30, 61);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(99, 15);
            labelCategoria.TabIndex = 6;
            labelCategoria.Text = "Nueva categoria :";
            // 
            // FrmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(799, 594);
            Controls.Add(labelCategoria);
            Controls.Add(txtNombreCategoria);
            Controls.Add(labelNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(DgvCategorias);
            MaximumSize = new Size(815, 633);
            MinimumSize = new Size(815, 633);
            Name = "FrmCategorias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeCategorias";
            Load += FrmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)DgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCategorias;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label labelNombre;
        private TextBox txtNombreCategoria;
        private Label labelCategoria;
    }
}