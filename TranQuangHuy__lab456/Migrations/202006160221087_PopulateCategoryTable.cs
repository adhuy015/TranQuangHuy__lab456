namespace TranQuangHuy__lab456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories(ID,Name) Values(1,'Development')");
            Sql("Insert into Categories(ID,Name) Values(2,'Business')");
            Sql("Insert into Categories(ID,Name) Values(3,'Marketing')");
        }
        
        public override void Down()
        {
        }
    }
}
