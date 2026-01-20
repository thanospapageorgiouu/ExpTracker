namespace ExpTracker.Models
{
    public class Expense
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Note { get; set; }
    }
}
