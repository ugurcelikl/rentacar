namespace rent_a_car.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arabalars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Plaka = c.String(nullable: false),
                        Marka = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        AracTipi = c.String(nullable: false),
                        Vites = c.String(nullable: false),
                        YakitTipi = c.String(nullable: false),
                        Fiyat = c.String(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kiralamas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArabaID = c.Int(nullable: false),
                        MusteriID = c.Int(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        KiralamaSuresi = c.Int(nullable: false),
                        FaturaTutari = c.Double(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                        Arabalar_ID = c.Int(),
                        Musteriler_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arabalars", t => t.Arabalar_ID)
                .ForeignKey("dbo.Musterilers", t => t.Musteriler_ID)
                .Index(t => t.Arabalar_ID)
                .Index(t => t.Musteriler_ID);
            
            CreateTable(
                "dbo.Musterilers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false),
                        Soyadi = c.String(nullable: false),
                        TC = c.String(nullable: false),
                        EhliyetNo = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Telefon = c.String(nullable: false),
                        Adres = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralamas", "Musteriler_ID", "dbo.Musterilers");
            DropForeignKey("dbo.Kiralamas", "Arabalar_ID", "dbo.Arabalars");
            DropIndex("dbo.Kiralamas", new[] { "Musteriler_ID" });
            DropIndex("dbo.Kiralamas", new[] { "Arabalar_ID" });
            DropTable("dbo.Musterilers");
            DropTable("dbo.Kiralamas");
            DropTable("dbo.Arabalars");
        }
    }
}
