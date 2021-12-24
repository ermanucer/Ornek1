
namespace Ornek1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblYasananGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            resources.ApplyResources(this.dtpDogumTarihi, "dtpDogumTarihi");
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblYas
            // 
            resources.ApplyResources(this.lblYas, "lblYas");
            this.lblYas.Name = "lblYas";
            // 
            // lblYasananGun
            // 
            resources.ApplyResources(this.lblYasananGun, "lblYasananGun");
            this.lblYasananGun.Name = "lblYasananGun";
            // 
            // lblBurc
            // 
            resources.ApplyResources(this.lblBurc, "lblBurc");
            this.lblBurc.Name = "lblBurc";
            // 
            // btnHesapla
            // 
            resources.ApplyResources(this.btnHesapla, "btnHesapla");
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblYasananGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDogumTarihi);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblYasananGun;
        private System.Windows.Forms.Label lblBurc;
        private System.Windows.Forms.Button btnHesapla;
    }
}

