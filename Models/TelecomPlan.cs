// Models/TelecomPlan.cs
namespace TelecomLocator.Models
{
    public class TelecomPlan
    {
        public int Id { get; set; }
        public string Prefix { get; set; }     // e.g., "447"
        public string Country { get; set; }    // e.g., "United Kingdom"
        public string Region { get; set; }     // e.g., "Mobile"
        public string Operator { get; set; }   // e.g., "O2 / Vodafone"
    }
}
