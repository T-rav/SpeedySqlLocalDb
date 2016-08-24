using System.Data.Common;
using System.Data.Entity;

namespace TddBuddy.SpeedySqlLocalDb.Test
{ 

    public class ExampleDbContext : DbContext
    {
        public ExampleDbContext() : base("SomeDbConnectionStringReference")
        {
            Database.SetInitializer<ExampleDbContext>(null);
        }

        public ExampleDbContext(DbConnection dbConnection) : base(dbConnection, false)
        {
        }
        
    }
}