namespace UGCore {
    partial class LicenseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.Label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.textBoxCompanyName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.textBoxSerialKey = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Kullanıcı Adı";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(108, 9);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(203, 20);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "Faruk";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(326, 9);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 52);
            this.Button1.TabIndex = 2;
            this.Button1.Text = "Anahtarı \r\nKaydet";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxCompanyName
            // 
            this.textBoxCompanyName.Location = new System.Drawing.Point(108, 38);
            this.textBoxCompanyName.Name = "textBoxCompanyName";
            this.textBoxCompanyName.Size = new System.Drawing.Size(203, 20);
            this.textBoxCompanyName.TabIndex = 4;
            this.textBoxCompanyName.Text = "uzaktangelir";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(55, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Şirket İsmi";
            // 
            // textBoxSerialKey
            // 
            this.textBoxSerialKey.Location = new System.Drawing.Point(108, 67);
            this.textBoxSerialKey.Name = "textBoxSerialKey";
            this.textBoxSerialKey.Size = new System.Drawing.Size(293, 20);
            this.textBoxSerialKey.TabIndex = 6;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Ürün Anahtarı";
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 108);
            this.Controls.Add(this.textBoxSerialKey);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.textBoxCompanyName);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LicenseForm";
            this.Text = "LicenseForum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.TextBox textBoxCompanyName;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox textBoxSerialKey;
        private System.Windows.Forms.Label Label3;
    }
}