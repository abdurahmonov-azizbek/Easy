namespace Easy.Models
{
    public class Level
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
