using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Entity
{
    public class Kiralama : BaseEntity
    {
        public int ArabaID { get; set; }
        public virtual Arabalar Arabalar { get; set; }
        public int MusteriID { get; set; }
        public virtual Musteriler Musteriler { get; set; }
        public DateTime AlisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int KiralamaSuresi { get; set; }
        public double FaturaTutari { get; set; }

    }
}
