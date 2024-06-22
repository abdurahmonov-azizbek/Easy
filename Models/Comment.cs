namespace Easy.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Message { get; set; } = default!;
        public Guid UserId { get; set; }
        public Guid SharedId { get; set; }
        public Guid? ParentId { get; set; } = null;
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
