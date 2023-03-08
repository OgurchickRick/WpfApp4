﻿namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Groups", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Groups", "Name");
        }
    }
}
