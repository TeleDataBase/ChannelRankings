namespace Sqlitecodefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.YGroups",
                c => new
                    {
                        GroupID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(maxLength: 64),
                        GroupType = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.YUsers",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 64),
                        UserSex = c.String(maxLength: 8),
                        NickName = c.String(maxLength: 64),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.YUsers");
            DropTable("dbo.YGroups");
        }
    }
}
