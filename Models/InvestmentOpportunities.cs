using Humanizer.Localisation.TimeToClockNotation;

namespace nextinvesting.Models
{
    public class InvestmentOpportunities
    {
        public int id { get; set; }
        public string InvestmentName { get; set; }

        public int InvestmentAmount { get; set; }

        public string Description { get; set; }
    }
}
