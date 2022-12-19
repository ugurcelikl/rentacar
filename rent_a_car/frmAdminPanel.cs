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
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAracEkle frmAracEkle = new frmAracEkle();
            frmAracEkle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAracListesi frmAracListesi = new frmAracListesi();
            frmAracListesi.Show();
        }
    }
}
