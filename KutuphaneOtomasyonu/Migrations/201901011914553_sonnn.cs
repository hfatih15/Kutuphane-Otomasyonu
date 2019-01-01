namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sonnn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kitaplar", "Adet", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kitaplar", "Adet", c => c.Int(nullable: false));
        }
    }
}
