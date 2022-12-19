using rent_a_car.ORM.Context;
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
    public partial class frmAracListesi : Form
    {
        public int kid;
        public frmAracListesi()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        private void frmAracListesi_Load(object sender, EventArgs e)
        {
            dg_arac_listesi.DataSource = db.Arabalars.Where(x => x.IsActive == false).ToList();
        }

        private void dg_arac_listesi_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Guid guid = Guid.NewGuid();
            frmAracDetayVeKirala frmAracDetayVeKirala = new frmAracDetayVeKirala();
            frmAracDetayVeKirala.kid =
            frmAracDetayVeKirala.id = Convert.ToInt32(dg_arac_listesi.CurrentRow.Cells["ID"].Value.ToString());
            frmAracDetayVeKirala.Show();
        }

        private void dg_arac_listesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
