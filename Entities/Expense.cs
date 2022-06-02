namespace MusicMoney.Entities
{
    public record Expense
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public int Cost { get; set; }
        
        public int Tax { get; set; }
        
        public string Vendor { get; set; }
        
        public DateTimeOffset CreateDate { get; set; }
    }
}