
namespace rent_a_car
{
    partial class frmAracListesi
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
            this.dg_arac_listesi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_arac_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_arac_listesi
            // 
            this.dg_arac_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_arac_listesi.Location = new System.Drawing.Point(0, 2);
            this.dg_arac_listesi.Name = "dg_arac_listesi";
            this.dg_arac_listesi.Size = new System.Drawing.Size(799, 296);
            this.dg_arac_listesi.TabIndex = 0;
            this.dg_arac_listesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_arac_listesi_CellContentClick);
            this.dg_arac_listesi.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dg_arac_listesi_CellMouseClick);
            // 
            // frmAracListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 299);
            this.Controls.Add(this.dg_arac_listesi);
            this.Name = "frmAracListesi";
            this.Text = "frmAracListesi";
            this.Load += new System.EventHandler(this.frmAracListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_arac_listesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_arac_listesi;
    }
}