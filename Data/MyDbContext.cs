using System.Data.Entity;
using Telecom-Prefix-Locator.Models;

namespace Telecom-Prefix-Locator.Data
{
    // The "DbContext" is the bridge between your C# classes and the SQL database
    public class MyDbContext : DbContext
    {
        // "name=TelecomDbConn" tells EF to look for this name in App.config
        public MyDbContext() : base("name=TelecomDbConn")
        {
        }

        // This creates a table named 'TelecomPlans' based on your model
        public DbSet<TelecomPlan> TelecomPlans { get; set; }
    }
}
