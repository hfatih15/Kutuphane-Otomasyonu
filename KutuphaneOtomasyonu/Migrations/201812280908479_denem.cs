namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class denem : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Uyeler", "KitapID", "dbo.Kitaplar");
            DropIndex("dbo.Uyeler", new[] { "KitapID" });
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
            
            DropColumn("dbo.Uyeler", "KitapID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uyeler", "KitapID", c => c.Int(nullable: false));
            DropForeignKey("dbo.KitapKira", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.KitapKira", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.KitapKira", new[] { "KitapId" });
            DropIndex("dbo.KitapKira", new[] { "UyeId" });
            DropTable("dbo.KitapKira");
            CreateIndex("dbo.Uyeler", "KitapID");
            AddForeignKey("dbo.Uyeler", "KitapID", "dbo.Kitaplar", "KitapId", cascadeDelete: true);
        }
    }
}
