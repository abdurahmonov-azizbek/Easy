namespace Easy.Models
{
    public class Like
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid SharedId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
