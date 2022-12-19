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
    public partial class frmAracDetayVeKirala : Form
    {
        public frmAracDetayVeKirala()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        public int kid;
        public int id;
        int gun;

        private void btn_kirala_kaydet_Click(object sender, EventArgs e)
        {
            Kiralama kiralama = new Kiralama();
            kiralama.ID = id;
            kiralama.KiralamaSuresi = gun;
            kiralama.MusteriID = kid;
            kiralama.TeslimTarihi = DateTime.Parse(dtp_teslim.Text);
            kiralama.AlisTarihi = DateTime.Parse(dtp_alis.Text);
            kiralama.FaturaTutari = Convert.ToDouble(lbl_fatura_tutari.Text);
            kiralama.IsActive = true;
            
            db.Kiralamas.Add(kiralama);
            db.SaveChanges();
            MessageBox.Show("Kiralama Kaydı Başarıyla Oluşturuldu.");
        }

        private void frmAracDetayVeKirala_Load(object sender, EventArgs e)
        {
            List<Arabalar> arabalars = new List<Arabalar>();
            arabalars = db.Arabalars.Where(x => x.ID == id).ToList();
            foreach (Arabalar item in arabalars)
            {
                lbl_plaka.Text = item.Plaka.ToString();
                lbl_marka.Text = item.Marka.ToString();
                lbl_model.Text = item.Model.ToString();
                lbl_vites.Text = item.Vites.ToString();
                lbl_yakit.Text = item.YakitTipi.ToString();
                lbl_aracTipi.Text = item.AracTipi.ToString();
                lbl_fiyat.Text = item.Fiyat.ToString();
            }
        }

        private void dtp_alis_ValueChanged(object sender, EventArgs e)
        {
            dtp_teslim.Enabled = true;
        }

        private void dtp_teslim_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan GunFarki = dtp_teslim.Value.Subtract(dtp_alis.Value);
            gun = GunFarki.Days;
            if (gun < 0)
            {
                MessageBox.Show("Lütfen Teslim Tarihini Alış Tarihinden İleri bir tarihte giriniz.");
            }
            else
            {
                double FaturaFiyat = gun * Convert.ToDouble(lbl_fiyat.Text);
                lbl_fatura_tutari.Text = FaturaFiyat.ToString();
            }

           
        }

        private void btn_kirala_iptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
