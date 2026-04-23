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
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvAgregarImg = new System.Windows.Forms.DataGridView();
            this.pbxAgregarImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(48, 82);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(82, 16);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Ingrese URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(51, 115);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(344, 22);
            this.txtUrl.TabIndex = 1;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(224, 175);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(171, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver sin agregar";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(122, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvAgregarImg
            // 
            this.dgvAgregarImg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarImg.Location = new System.Drawing.Point(51, 236);
            this.dgvAgregarImg.Name = "dgvAgregarImg";
            this.dgvAgregarImg.RowHeadersWidth = 51;
            this.dgvAgregarImg.RowTemplate.Height = 24;
            this.dgvAgregarImg.Size = new System.Drawing.Size(344, 150);
            this.dgvAgregarImg.TabIndex = 4;
            this.dgvAgregarImg.SelectionChanged += new System.EventHandler(this.dgvAgregarImg_SelectionChanged);
            // 
            // pbxAgregarImg
            // 
            this.pbxAgregarImg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxAgregarImg.Location = new System.Drawing.Point(448, 115);
            this.pbxAgregarImg.Name = "pbxAgregarImg";
            this.pbxAgregarImg.Size = new System.Drawing.Size(289, 271);
            this.pbxAgregarImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregarImg.TabIndex = 5;
            this.pbxAgregarImg.TabStop = false;
            // 
            // frmAgregarImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 398);
            this.Controls.Add(this.pbxAgregarImg);
            this.Controls.Add(this.dgvAgregarImg);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "frmAgregarImagen";
            this.Text = "frmAgregarImagen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregarImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUrl;
        private TextBox txtUrl;
        private Button btnVolver;
        private Button btnAgregar;
        private DataGridView dgvAgregarImg;
        private PictureBox pbxAgregarImg;
    }
}