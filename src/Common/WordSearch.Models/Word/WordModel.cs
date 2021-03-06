namespace WordSearch.Models.Word
{
    public class WordModel
    {
        public int Id { get; set; }

        public string Value { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Language { get; set; } = null!;
    }
}
