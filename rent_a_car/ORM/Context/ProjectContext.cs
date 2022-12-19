using rent_a_car.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rent_a_car.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=RentACar;uid=sa;password=9117";
            //Database.Connection.ConnectionString = "Server=202-HOCAPC;Database=RentACar;uid=sa;password=9117";
            //Database.Connection.ConnectionString = "Data Source=202-HOCAPC;Initial Catalog=RentACar;Integrated Security=True";
        }

        public DbSet<Arabalar> Arabalars { get; set; }
        public DbSet<Musteriler> Musterilers { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
    }
}
