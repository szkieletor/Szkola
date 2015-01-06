namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class next : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DateOfBirthday", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "UserDetails_DateOfBirthday");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserDetails_DateOfBirthday", c => c.DateTime());
            DropColumn("dbo.AspNetUsers", "DateOfBirthday");
        }
    }
}
