
namespace rent_a_car
{
    partial class frmKullaniciGirisi
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_TC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.lbl_Kayit_ol = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txt_TC
            // 
            this.txt_TC.Location = new System.Drawing.Point(109, 87);
            this.txt_TC.Name = "txt_TC";
            this.txt_TC.Size = new System.Drawing.Size(180, 20);
            this.txt_TC.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TC";
            // 
            // txt_Parola
            // 
            this.txt_Parola.Location = new System.Drawing.Point(109, 128);
            this.txt_Parola.Name = "txt_Parola";
            this.txt_Parola.Size = new System.Drawing.Size(180, 20);
            this.txt_Parola.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(145, 170);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(114, 23);
            this.btn_Giris.TabIndex = 2;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // lbl_Kayit_ol
            // 
            this.lbl_Kayit_ol.AutoSize = true;
            this.lbl_Kayit_ol.Location = new System.Drawing.Point(181, 222);
            this.lbl_Kayit_ol.Name = "lbl_Kayit_ol";
            this.lbl_Kayit_ol.Size = new System.Drawing.Size(43, 13);
            this.lbl_Kayit_ol.TabIndex = 3;
            this.lbl_Kayit_ol.TabStop = true;
            this.lbl_Kayit_ol.Text = "Kayıt Ol";
            this.lbl_Kayit_ol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_Kayit_ol_LinkClicked);
            // 
            // frmKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 300);
            this.Controls.Add(this.lbl_Kayit_ol);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Parola);
            this.Controls.Add(this.txt_TC);
            this.Name = "frmKullaniciGirisi";
            this.Text = "Kullanıcı Girişi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.LinkLabel lbl_Kayit_ol;
    }
}

