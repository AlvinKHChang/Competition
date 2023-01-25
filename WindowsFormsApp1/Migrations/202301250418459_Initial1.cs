namespace WindowsFormsApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.competitors", "passport_name", c => c.String());
            AddColumn("public.competitors", "reg_phone", c => c.String());
            AddColumn("public.competitors", "check_in", c => c.Boolean(nullable: false));
            AddColumn("public.competitors", "drawing_id", c => c.String());
            AddColumn("public.competitors", "teacher_name", c => c.String());
            AddColumn("public.competitors", "teacher_phone", c => c.String());
            AddColumn("public.competitors", "reg_teacher_phone", c => c.String());
            AddColumn("public.competitors", "rank", c => c.String());
            AddColumn("public.competitors", "rank_id", c => c.Int(nullable: false));
            AddColumn("public.competitors", "group", c => c.String());
            AddColumn("public.competitors", "group_id", c => c.Int(nullable: false));
            AddColumn("public.competitors", "competition_type", c => c.Int(nullable: false));
            CreateIndex("public.competitors", "entry_name", unique: true, name: "Index_EntryNumber");
            CreateIndex("public.competitors", "drawing_id", unique: true, name: "Index_DrawingId");
            CreateIndex("public.competitors", "rank_id", name: "Index_rankId");
            CreateIndex("public.competitors", "group_id", name: "Index_groupId");
            CreateIndex("public.competitors", "competition_type", name: "Index_CompetitionType");
        }
        
        public override void Down()
        {
            DropIndex("public.competitors", "Index_CompetitionType");
            DropIndex("public.competitors", "Index_groupId");
            DropIndex("public.competitors", "Index_rankId");
            DropIndex("public.competitors", "Index_DrawingId");
            DropIndex("public.competitors", "Index_EntryNumber");
            DropColumn("public.competitors", "competition_type");
            DropColumn("public.competitors", "group_id");
            DropColumn("public.competitors", "group");
            DropColumn("public.competitors", "rank_id");
            DropColumn("public.competitors", "rank");
            DropColumn("public.competitors", "reg_teacher_phone");
            DropColumn("public.competitors", "teacher_phone");
            DropColumn("public.competitors", "teacher_name");
            DropColumn("public.competitors", "drawing_id");
            DropColumn("public.competitors", "check_in");
            DropColumn("public.competitors", "reg_phone");
            DropColumn("public.competitors", "passport_name");
        }
    }
}
