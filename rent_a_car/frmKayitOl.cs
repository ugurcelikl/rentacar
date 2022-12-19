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
    public partial class frmKayitOl : Form
    {
        public frmKayitOl()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        private void btn_kayit_ol_Click(object sender, EventArgs e)
        {
            // WinFormdan buraya gelen dataların kontrolünü yapın.
            Musteriler musteriler = new Musteriler()
            {
                Adi = txt_Ad.Text,
                Soyadi = txt_Soyad.Text,
                TC = txt_TC.Text,
                Sifre = txt_Sifre.Text,
                EhliyetNo =txt_EhliyetNo.Text,
                Email = txt_Eposta.Text,
                Adres = txt_adres.Text,
                Telefon = txt_Telefon.Text,
                Role = cb_role.Text
            };

            db.Musterilers.Add(musteriler);
            db.SaveChanges();
            MessageBox.Show("Kayıt İşleminiz gerçekleşti.");
            this.Hide();
            frmKullaniciGirisi frmKullaniciGirisi = new frmKullaniciGirisi();
            frmKullaniciGirisi.Show();
        }
    }
}
