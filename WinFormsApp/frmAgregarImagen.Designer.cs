namespace WinFormsApp
{
    partial class frmAgregarImagen
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
            btnVolver = new Button();
            lblUrl = new Label();
            txtBoxUrLImg = new TextBox();
            btnAgregar = new Button();
            dgvAgregarImg = new DataGridView();
            pbxAgregarImagen = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAgregarImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarImagen).BeginInit();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(242, 133);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(215, 29);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver sin agregar";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(12, 54);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(87, 20);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "Ingrese URL";
            lblUrl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBoxUrLImg
            // 
            txtBoxUrLImg.Location = new Point(12, 90);
            txtBoxUrLImg.Name = "txtBoxUrLImg";
            txtBoxUrLImg.Size = new Size(445, 27);
            txtBoxUrLImg.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(130, 133);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvAgregarImg
            // 
            dgvAgregarImg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAgregarImg.Location = new Point(12, 182);
            dgvAgregarImg.Name = "dgvAgregarImg";
            dgvAgregarImg.RowHeadersWidth = 51;
            dgvAgregarImg.Size = new Size(445, 193);
            dgvAgregarImg.TabIndex = 4;
            dgvAgregarImg.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // pbxAgregarImagen
            // 
            pbxAgregarImagen.BackColor = SystemColors.ActiveCaption;
            pbxAgregarImagen.Location = new Point(483, 90);
            pbxAgregarImagen.Name = "pbxAgregarImagen";
            pbxAgregarImagen.Size = new Size(280, 285);
            pbxAgregarImagen.TabIndex = 5;
            pbxAgregarImagen.TabStop = false;
            // 
            // frmAgregarImagen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 406);
            Controls.Add(pbxAgregarImagen);
            Controls.Add(dgvAgregarImg);
            Controls.Add(btnAgregar);
            Controls.Add(txtBoxUrLImg);
            Controls.Add(lblUrl);
            Controls.Add(btnVolver);
            Name = "frmAgregarImagen";
            Text = "frmAgregarImagen";
            Load += frmAgregarImagen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAgregarImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxAgregarImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblUrl;
        private TextBox txtBoxUrLImg;
        private Button btnAgregar;
        private DataGridView dgvAgregarImg;
        private PictureBox pbxAgregarImagen;
    }
}