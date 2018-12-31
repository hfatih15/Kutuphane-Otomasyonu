namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class son : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KitapKira",
                c => new
                    {
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        Ekleme = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.UyeId, t.KitapId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId)
                .Index(t => t.KitapId);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false),
                        KitapTuru = c.String(nullable: false),
                        YazarId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAd = c.String(nullable: false),
                        YazarSoyad = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyelerId = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        TCKNO = c.String(nullable: false, maxLength: 11),
                        CezaTutari = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyelerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KitapKira", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.KitapKira", "KitapId", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.KitapKira", new[] { "KitapId" });
            DropIndex("dbo.KitapKira", new[] { "UyeId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.KitapKira");
        }
    }
}
