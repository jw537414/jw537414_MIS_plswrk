using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jw537414_MIS_plswrk.Models; // This is needed to access the models
using System.Data.Entity; // this is needed to access the DbContext object
namespace jw537414_MIS_plswrk.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {

            // add the SetInitializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
           jw537414_MIS_plswrk.Migrations.MISContext.Configuration>("DefaultConnection"));

            // add this method - it will be used later

        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Class> Classes { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}