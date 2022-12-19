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
    public partial class frmKullaniciGirisi : Form
    {
        ProjectContext db = new ProjectContext();
        public frmKullaniciGirisi()
        {
            InitializeComponent();
        }

        private void lbl_Kayit_ol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKayitOl frmKayitOl = new frmKayitOl();
            frmKayitOl.Show();
            this.Hide();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string tc = "";
            string sifre = "";
            string id = "";
            string role = "";
            int musteriId;

            List<Musteriler> mst = new List<Musteriler>();
            mst = db.Musterilers.Where(x => x.TC == txt_TC.Text).ToList();
            // Form kontrollerini burada da değiştirebilirsiniz.
            foreach (Musteriler musteri in mst)
            {
                tc = musteri.TC;
                sifre = musteri.Sifre;
                id = musteri.ID.ToString();
                role = musteri.Role;
                musteriId = musteri.ID;
                frmAracListesi frmAracListesi = new frmAracListesi();
                frmAracListesi.kid = musteriId;
            }
                      

            if(role.ToLower()=="admin" && txt_Parola.Text == sifre && txt_TC.Text == tc)
            {
                frmAdminPanel frmAdminPanel = new frmAdminPanel();
                frmAdminPanel.Show();
                this.Hide();

            }
            else
            {
                if (tc == txt_TC.Text && !string.IsNullOrEmpty(tc))
                {
                    if (sifre == txt_Parola.Text && !string.IsNullOrEmpty(sifre))
                    {
                        frmMusteriPanel musteriPanel = new frmMusteriPanel();
                        musteriPanel.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Doğru Şifre giriniz.");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Doğru TC giriniz.");
                }
            }

            

        }
    }
}
