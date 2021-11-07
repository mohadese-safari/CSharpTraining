namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNickNameToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "NickName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "NickName");
        }
    }
}
