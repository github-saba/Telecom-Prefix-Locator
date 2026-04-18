// This handles the LINQ logic and the Async database calls. It uses Entity Framework (EF6).
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using TelecomLocator.Models;

namespace TelecomLocator.Data
{
    public class PlanRepository
    {
        private readonly MyDbContext _context = new MyDbContext();

        public async Task<List<TelecomPlan>> SearchPlansAsync(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return new List<TelecomPlan>();

            // Optimized LINQ: Search by prefix OR country
            return await _context.TelecomPlans
                .AsNoTracking() // Performance boost for read-only
                .Where(p => p.Prefix.StartsWith(query) || p.Country.Contains(query))
                .OrderBy(p => p.Country)
                .ToListAsync();
        }
    }
}
