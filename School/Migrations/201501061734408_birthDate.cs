namespace School.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class birthDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserDetails_DateOfBirthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserDetails_DateOfBirthday");
        }
    }
}
