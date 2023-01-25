namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.competitors",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        entry_name = c.String(),
                        name = c.String(),
                        address = c.String(),
                        phone = c.String(),
                        updated_time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("public.competitors");
        }
    }
}
