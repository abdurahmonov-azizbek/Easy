namespace Easy.Models
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid TestId { get; set; }
        public Guid OptionId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}