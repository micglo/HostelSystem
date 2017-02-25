namespace HostelSystem.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gosc_Tel_Adres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gosc", "Telefon", c => c.String());
            AddColumn("dbo.Gosc", "Adres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gosc", "Adres");
            DropColumn("dbo.Gosc", "Telefon");
        }
    }
}
