
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
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblYasananGun = new System.Windows.Forms.Label();
            this.lblBurc = new System.Windows.Forms.Label();
            this.lblYasHesap = new System.Windows.Forms.Label();
            this.lblYasananGunHesap = new System.Windows.Forms.Label();
            this.lblBurcHesap = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(259, 47);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDogumTarihi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doğum Tarihiniz";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(310, 141);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(46, 13);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yaşınız :";
            // 
            // lblYasananGun
            // 
            this.lblYasananGun.AutoSize = true;
            this.lblYasananGun.Location = new System.Drawing.Point(267, 164);
            this.lblYasananGun.Name = "lblYasananGun";
            this.lblYasananGun.Size = new System.Drawing.Size(89, 13);
            this.lblYasananGun.TabIndex = 2;
            this.lblYasananGun.Text = "Yaşadığınız Gün :";
            // 
            // lblBurc
            // 
            this.lblBurc.AutoSize = true;
            this.lblBurc.Location = new System.Drawing.Point(310, 186);
            this.lblBurc.Name = "lblBurc";
            this.lblBurc.Size = new System.Drawing.Size(58, 13);
            this.lblBurc.TabIndex = 2;
            this.lblBurc.Text = "Burcunuz :";
            // 
            // lblYasHesap
            // 
            this.lblYasHesap.AutoSize = true;
            this.lblYasHesap.Location = new System.Drawing.Point(386, 141);
            this.lblYasHesap.Name = "lblYasHesap";
            this.lblYasHesap.Size = new System.Drawing.Size(0, 13);
            this.lblYasHesap.TabIndex = 3;
            // 
            // lblYasananGunHesap
            // 
            this.lblYasananGunHesap.AutoSize = true;
            this.lblYasananGunHesap.Location = new System.Drawing.Point(386, 164);
            this.lblYasananGunHesap.Name = "lblYasananGunHesap";
            this.lblYasananGunHesap.Size = new System.Drawing.Size(0, 13);
            this.lblYasananGunHesap.TabIndex = 3;
            // 
            // lblBurcHesap
            // 
            this.lblBurcHesap.AutoSize = true;
            this.lblBurcHesap.Location = new System.Drawing.Point(386, 186);
            this.lblBurcHesap.Name = "lblBurcHesap";
            this.lblBurcHesap.Size = new System.Drawing.Size(0, 13);
            this.lblBurcHesap.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(314, 92);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBurcHesap);
            this.Controls.Add(this.lblYasananGunHesap);
            this.Controls.Add(this.lblYasHesap);
            this.Controls.Add(this.lblBurc);
            this.Controls.Add(this.lblYasananGun);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblYasHesap;
        private System.Windows.Forms.Label lblYasananGunHesap;
        private System.Windows.Forms.Label lblBurcHesap;
        private System.Windows.Forms.Button btnHesapla;
    }
}

