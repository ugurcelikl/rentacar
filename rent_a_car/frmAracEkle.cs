using rent_a_car.ORM.Context;
using rent_a_car.ORM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class frmAracEkle : Form
    {
        public frmAracEkle()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        // Ödev buranın kontolü
        private void btn_arac_ekle_Click(object sender, EventArgs e)
        {
            Arabalar arabalar = new Arabalar();
            arabalar.Marka = txt_Marka.Text;
            arabalar.Model = txt_Model.Text;
            arabalar.Plaka = txt_Plaka.Text;
            arabalar.Fiyat = txt_gunluk_fiyat.Text;
            arabalar.AracTipi = cb_arac_tipi.Text;
            arabalar.Vites = cb_vites_turu.Text;
            arabalar.YakitTipi = cb_yakit_tipi.Text;
            arabalar.IsActive = true;
            arabalar.AddDate = DateTime.Now;
            arabalar.UpdateDate = DateTime.Now;

            db.Arabalars.Add(arabalar);
            db.SaveChanges();
            MessageBox.Show("Araç Ekleme İşlemi Başarıyla Gerçekleşti.");
            this.Hide();
        }
    }
}
