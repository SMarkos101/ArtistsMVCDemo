namespace ArtistsMVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dos : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Albums SET Description = 'An Awesome Album1' WHERE ID = 1");
            Sql("UPDATE Albums SET Description = 'An Awesome Album2' WHERE ID = 2");
            Sql("UPDATE Albums SET Description = 'An Awesome Album3' WHERE ID = 3");
            Sql("UPDATE Albums SET Description = 'An Awesome Album4' WHERE ID = 4");
        }
        
        public override void Down()
        {

            Sql("UPDATE Albums SET Description = ''");
        }
    }
}
