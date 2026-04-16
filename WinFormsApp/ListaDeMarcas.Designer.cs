namespace WinFormsApp
{
    partial class ListaDeMarcas
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
            dgvMarcas = new DataGridView();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            labelTitulo = new Label();
            txtNombreMarca = new TextBox();
            labelMarca = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // dgvMarcas
            // 
            dgvMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarcas.BackgroundColor = SystemColors.ControlLightLight;
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(74, 128);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.Size = new Size(533, 406);
            dgvMarcas.TabIndex = 0;
            dgvMarcas.CellContentClick += dgvMarcas_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ControlLightLight;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(654, 128);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ControlLightLight;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(654, 205);
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
            btnEliminar.Location = new Point(654, 273);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = SystemColors.GradientInactiveCaption;
            labelTitulo.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitulo.ForeColor = SystemColors.ControlText;
            labelTitulo.Location = new Point(345, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(65, 23);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Marcas";
            // 
            // txtNombreMarca
            // 
            txtNombreMarca.Location = new Point(174, 73);
            txtNombreMarca.Name = "txtNombreMarca";
            txtNombreMarca.Size = new Size(297, 23);
            txtNombreMarca.TabIndex = 5;
            txtNombreMarca.TextChanged += txtNombreMarca_TextChanged;
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(74, 76);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(83, 15);
            labelMarca.TabIndex = 6;
            labelMarca.Text = "Nueva Marca :";
            // 
            // ListaDeMarcas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(799, 594);
            Controls.Add(labelMarca);
            Controls.Add(txtNombreMarca);
            Controls.Add(labelTitulo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMarcas);
            MaximumSize = new Size(815, 633);
            MinimumSize = new Size(815, 633);
            Name = "ListaDeMarcas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListaDeMarcas";
            Load += ListaDeMarcas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMarcas;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label labelTitulo;
        private TextBox txtNombreMarca;
        private Label labelMarca;
    }
}