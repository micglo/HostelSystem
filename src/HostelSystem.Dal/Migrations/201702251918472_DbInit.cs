namespace HostelSystem.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Gosc",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Imie = c.String(nullable: false, maxLength: 100),
                        Nazwisko = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 30),
                        RezerwacjaId = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rezerwacja", t => t.RezerwacjaId)
                .Index(t => t.RezerwacjaId);
            
            CreateTable(
                "dbo.Rezerwacja",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KodRezerwacji = c.String(nullable: false, maxLength: 10),
                        DataUtworzenia = c.DateTime(nullable: false),
                        Cena = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DataZameldowania = c.DateTime(),
                        DataWymeldowania = c.DateTime(),
                        Prowizja = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gosc", "RezerwacjaId", "dbo.Rezerwacja");
            DropIndex("dbo.Gosc", new[] { "RezerwacjaId" });
            DropTable("dbo.Rezerwacja");
            DropTable("dbo.Gosc");
        }
    }
}
