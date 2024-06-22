namespace Easy.Models
{
    public class TestOption
    {
        public Guid Id { get; set; }
        public string Option { get; set; } = default!;
        public Guid TestId { get; set; }
        public bool IsCorrect { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
