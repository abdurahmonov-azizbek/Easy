namespace Easy.Models
{
    public class Word
    {
        public Guid Id { get; set; }
        public string English { get; set; } = default!;
        public string Uzbek { get; set; } = default!;
        public string ExampleInEnglish { get; set; } = default!;
        public string ExampleInUzbek { get; set; } = default!;
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset UpdatedDate { get; set; }
    }
}
