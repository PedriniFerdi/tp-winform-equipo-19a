namespace WinFormsApp
{
    partial class frmSobreescribirUrl
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
            this.lblNuevaUrl = new System.Windows.Forms.Label();
            this.txtSobreescribirUrl = new System.Windows.Forms.TextBox();
            this.btnSobreescribirUrl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaUrl
            // 
            this.lblNuevaUrl.AutoSize = true;
            this.lblNuevaUrl.Location = new System.Drawing.Point(37, 56);
            this.lblNuevaUrl.Name = "lblNuevaUrl";
            this.lblNuevaUrl.Size = new System.Drawing.Size(77, 16);
            this.lblNuevaUrl.TabIndex = 0;
            this.lblNuevaUrl.Text = "Nueva URL";
            // 
            // txtSobreescribirUrl
            // 
            this.txtSobreescribirUrl.Location = new System.Drawing.Point(40, 95);
            this.txtSobreescribirUrl.Name = "txtSobreescribirUrl";
            this.txtSobreescribirUrl.Size = new System.Drawing.Size(378, 22);
            this.txtSobreescribirUrl.TabIndex = 1;
            // 
            // btnSobreescribirUrl
            // 
            this.btnSobreescribirUrl.Location = new System.Drawing.Point(257, 142);
            this.btnSobreescribirUrl.Name = "btnSobreescribirUrl";
            this.btnSobreescribirUrl.Size = new System.Drawing.Size(161, 41);
            this.btnSobreescribirUrl.TabIndex = 2;
            this.btnSobreescribirUrl.Text = "Sobreescribir URL imagen";
            this.btnSobreescribirUrl.UseVisualStyleBackColor = true;
            this.btnSobreescribirUrl.Click += new System.EventHandler(this.btnSobreescribirUrl_Click);
            // 
            // frmSobreescribirUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 206);
            this.Controls.Add(this.btnSobreescribirUrl);
            this.Controls.Add(this.txtSobreescribirUrl);
            this.Controls.Add(this.lblNuevaUrl);
            this.Name = "frmSobreescribirUrl";
            this.Text = "frmSobreescribirUrl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNuevaUrl;
        private TextBox txtSobreescribirUrl;
        private Button btnSobreescribirUrl;
    }
}