namespace Easy.Models
{
    public class Test
    {
        public Guid Id { get; set; }
        public string Question { get; set; } = default!;
        public Guid LevelId { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
