namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.competitors", "gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.competitors", "gender");
        }
    }
}
