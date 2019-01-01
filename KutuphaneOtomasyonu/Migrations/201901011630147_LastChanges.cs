namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastChanges : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.KitapKira", new[] { "UyeId" });
            DropIndex("dbo.KitapKira", new[] { "KitapId" });
            DropPrimaryKey("dbo.KitapKira");
            AddColumn("dbo.KitapKira", "AlindigiTarih ", c => c.DateTime(nullable: false, storeType: "date"));
            AddColumn("dbo.KitapKira", "Ad", c => c.String());
            AddColumn("dbo.KitapKira", "Soyad", c => c.String());
            AddColumn("dbo.KitapKira", "KitapAdi", c => c.String());
            AddColumn("dbo.KitapKira", "YazarAdi", c => c.String());
            AddPrimaryKey("dbo.KitapKira", new[] { "KitapID", "UyeID" });
            CreateIndex("dbo.KitapKira", "KitapID");
            CreateIndex("dbo.KitapKira", "UyeID");
            DropColumn("dbo.KitapKira", "Ekleme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.KitapKira", "Ekleme", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
            DropIndex("dbo.KitapKira", new[] { "UyeID" });
            DropIndex("dbo.KitapKira", new[] { "KitapID" });
            DropPrimaryKey("dbo.KitapKira");
            DropColumn("dbo.KitapKira", "YazarAdi");
            DropColumn("dbo.KitapKira", "KitapAdi");
            DropColumn("dbo.KitapKira", "Soyad");
            DropColumn("dbo.KitapKira", "Ad");
            DropColumn("dbo.KitapKira", "AlindigiTarih ");
            AddPrimaryKey("dbo.KitapKira", new[] { "UyeId", "KitapId" });
            CreateIndex("dbo.KitapKira", "KitapId");
            CreateIndex("dbo.KitapKira", "UyeId");
        }
    }
}
