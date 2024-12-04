namespace nextinvesting.Models
{
    public class Investment

    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string CardImageUrl { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal GetPrice { get; set; }
        public string SecurityType { get; set; }
        public decimal InvestmentMultiple { get; set; }
        public string Maturity { get; set; }
        public decimal MinInvestment { get; set; }


        }
}
