namespace WinFormsApp
{
    partial class frmModificarImagen
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
            this.btnAgregarImg = new System.Windows.Forms.Button();
            this.pbxModificarImg = new System.Windows.Forms.PictureBox();
            this.dgvModificarImg = new System.Windows.Forms.DataGridView();
            this.btnModificarImg = new System.Windows.Forms.Button();
            this.btnEliminarImg = new System.Windows.Forms.Button();
            this.lblListaImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(26, 68);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(188, 28);
            this.btnAgregarImg.TabIndex = 0;
            this.btnAgregarImg.Text = "Agregar nueva imagen";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // pbxModificarImg
            // 
            this.pbxModificarImg.Location = new System.Drawing.Point(285, 44);
            this.pbxModificarImg.Name = "pbxModificarImg";
            this.pbxModificarImg.Size = new System.Drawing.Size(331, 307);
            this.pbxModificarImg.TabIndex = 3;
            this.pbxModificarImg.TabStop = false;
            // 
            // dgvModificarImg
            // 
            this.dgvModificarImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarImg.Location = new System.Drawing.Point(26, 386);
            this.dgvModificarImg.Name = "dgvModificarImg";
            this.dgvModificarImg.RowHeadersWidth = 51;
            this.dgvModificarImg.RowTemplate.Height = 24;
            this.dgvModificarImg.Size = new System.Drawing.Size(590, 150);
            this.dgvModificarImg.TabIndex = 4;
            this.dgvModificarImg.SelectionChanged += new System.EventHandler(this.dgvModificarImg_SelectionChanged);
            // 
            // btnModificarImg
            // 
            this.btnModificarImg.Location = new System.Drawing.Point(26, 145);
            this.btnModificarImg.Name = "btnModificarImg";
            this.btnModificarImg.Size = new System.Drawing.Size(188, 28);
            this.btnModificarImg.TabIndex = 5;
            this.btnModificarImg.Text = "Modificar imagen";
            this.btnModificarImg.UseVisualStyleBackColor = true;
            this.btnModificarImg.Click += new System.EventHandler(this.btnModificarImg_Click);
            // 
            // btnEliminarImg
            // 
            this.btnEliminarImg.Location = new System.Drawing.Point(26, 213);
            this.btnEliminarImg.Name = "btnEliminarImg";
            this.btnEliminarImg.Size = new System.Drawing.Size(188, 28);
            this.btnEliminarImg.TabIndex = 6;
            this.btnEliminarImg.Text = "Eliminar imagen";
            this.btnEliminarImg.UseVisualStyleBackColor = true;
            this.btnEliminarImg.Click += new System.EventHandler(this.btnEliminarImg_Click);
            // 
            // lblListaImg
            // 
            this.lblListaImg.AutoSize = true;
            this.lblListaImg.Location = new System.Drawing.Point(23, 335);
            this.lblListaImg.Name = "lblListaImg";
            this.lblListaImg.Size = new System.Drawing.Size(98, 16);
            this.lblListaImg.TabIndex = 7;
            this.lblListaImg.Text = "Lista Imagenes";
            // 
            // frmModificarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 548);
            this.Controls.Add(this.lblListaImg);
            this.Controls.Add(this.btnEliminarImg);
            this.Controls.Add(this.btnModificarImg);
            this.Controls.Add(this.dgvModificarImg);
            this.Controls.Add(this.pbxModificarImg);
            this.Controls.Add(this.btnAgregarImg);
            this.Name = "frmModificarImagen";
            this.Text = "frmModificarImagen";
            this.Load += new System.EventHandler(this.frmModificarImagen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxModificarImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregarImg;
        private PictureBox pbxModificarImg;
        private DataGridView dgvModificarImg;
        private Button btnModificarImg;
        private Button btnEliminarImg;
        private Label lblListaImg;
    }
}