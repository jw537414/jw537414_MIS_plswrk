namespace jw537414_MIS_plswrk.Migrations.MISContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<jw537414_MIS_plswrk.DAL.MIS4200Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\MISContext";
            ContextKey = "jw537414_MIS_plswrk.DAL.MIS4200Context";
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(jw537414_MIS_plswrk.DAL.MIS4200Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
