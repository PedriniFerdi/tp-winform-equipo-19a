namespace WinFormsApp
{
    partial class frmModNuevaImg
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
            this.txtUrlNuevaIMG = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.btnNuevaImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrlNuevaIMG
            // 
            this.txtUrlNuevaIMG.Location = new System.Drawing.Point(63, 90);
            this.txtUrlNuevaIMG.Name = "txtUrlNuevaIMG";
            this.txtUrlNuevaIMG.Size = new System.Drawing.Size(365, 22);
            this.txtUrlNuevaIMG.TabIndex = 0;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(60, 54);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(130, 16);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Ingrese URL imagen";
            // 
            // btnNuevaImg
            // 
            this.btnNuevaImg.Location = new System.Drawing.Point(241, 133);
            this.btnNuevaImg.Name = "btnNuevaImg";
            this.btnNuevaImg.Size = new System.Drawing.Size(187, 49);
            this.btnNuevaImg.TabIndex = 2;
            this.btnNuevaImg.Text = "Agregar nueva imagen";
            this.btnNuevaImg.UseVisualStyleBackColor = true;
            this.btnNuevaImg.Click += new System.EventHandler(this.btnNuevaImg_Click);
            // 
            // frmModNuevaImg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 206);
            this.Controls.Add(this.btnNuevaImg);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrlNuevaIMG);
            this.Name = "frmModNuevaImg";
            this.Text = "frmModNuevaImg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUrlNuevaIMG;
        private Label lblUrl;
        private Button btnNuevaImg;
    }
}