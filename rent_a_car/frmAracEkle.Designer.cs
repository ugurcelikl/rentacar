
namespace rent_a_car
{
    partial class frmAracEkle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Plaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_arac_tipi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_yakit_tipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_vites_turu = new System.Windows.Forms.ComboBox();
            this.txt_gunluk_fiyat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_arac_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Plaka
            // 
            this.txt_Plaka.Location = new System.Drawing.Point(376, 56);
            this.txt_Plaka.Name = "txt_Plaka";
            this.txt_Plaka.Size = new System.Drawing.Size(163, 20);
            this.txt_Plaka.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plaka";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(595, 56);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(163, 20);
            this.txt_Marka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(376, 124);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(163, 20);
            this.txt_Model.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Araç Tipi";
            // 
            // cb_arac_tipi
            // 
            this.cb_arac_tipi.FormattingEnabled = true;
            this.cb_arac_tipi.Items.AddRange(new object[] {
            "SUV",
            "Sedan",
            "Hatcback",
            "Cabrio"});
            this.cb_arac_tipi.Location = new System.Drawing.Point(595, 122);
            this.cb_arac_tipi.Name = "cb_arac_tipi";
            this.cb_arac_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_arac_tipi.TabIndex = 3;
            this.cb_arac_tipi.Text = "Araç Tipi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Yakıt Tipi";
            // 
            // cb_yakit_tipi
            // 
            this.cb_yakit_tipi.FormattingEnabled = true;
            this.cb_yakit_tipi.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Hibrit",
            "Elektrikli"});
            this.cb_yakit_tipi.Location = new System.Drawing.Point(595, 181);
            this.cb_yakit_tipi.Name = "cb_yakit_tipi";
            this.cb_yakit_tipi.Size = new System.Drawing.Size(121, 21);
            this.cb_yakit_tipi.TabIndex = 3;
            this.cb_yakit_tipi.Text = "Yakıt Tipi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Vites Türü";
            // 
            // cb_vites_turu
            // 
            this.cb_vites_turu.FormattingEnabled = true;
            this.cb_vites_turu.Items.AddRange(new object[] {
            "Otomatik",
            "Düz",
            "Yarı Otomatik"});
            this.cb_vites_turu.Location = new System.Drawing.Point(376, 181);
            this.cb_vites_turu.Name = "cb_vites_turu";
            this.cb_vites_turu.Size = new System.Drawing.Size(121, 21);
            this.cb_vites_turu.TabIndex = 3;
            this.cb_vites_turu.Text = "Vites Türü";
            // 
            // txt_gunluk_fiyat
            // 
            this.txt_gunluk_fiyat.Location = new System.Drawing.Point(373, 242);
            this.txt_gunluk_fiyat.Name = "txt_gunluk_fiyat";
            this.txt_gunluk_fiyat.Size = new System.Drawing.Size(163, 20);
            this.txt_gunluk_fiyat.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Günlük Fiyat";
            // 
            // btn_arac_ekle
            // 
            this.btn_arac_ekle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_arac_ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_arac_ekle.Location = new System.Drawing.Point(117, 301);
            this.btn_arac_ekle.Name = "btn_arac_ekle";
            this.btn_arac_ekle.Size = new System.Drawing.Size(599, 79);
            this.btn_arac_ekle.TabIndex = 4;
            this.btn_arac_ekle.Text = "Araç Ekle";
            this.btn_arac_ekle.UseVisualStyleBackColor = false;
            this.btn_arac_ekle.Click += new System.EventHandler(this.btn_arac_ekle_Click);
            // 
            // frmAracEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 439);
            this.Controls.Add(this.btn_arac_ekle);
            this.Controls.Add(this.cb_vites_turu);
            this.Controls.Add(this.cb_yakit_tipi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_arac_tipi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_gunluk_fiyat);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.txt_Plaka);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAracEkle";
            this.Text = "frmAracEkle";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_Plaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_arac_tipi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_yakit_tipi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_vites_turu;
        private System.Windows.Forms.TextBox txt_gunluk_fiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_arac_ekle;
    }
}