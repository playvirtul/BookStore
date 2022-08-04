namespace BookStore.Domain
{
    public record Book
    {
        public const int MAX_TITLE_LENGTH = 100;
        public const int MAX_AUTHOR_LENGTH = 100;

        public Book(int id, string author, string title, DateTime publishYear)
        {
            Id = id;
            Author = author;
            Title = title;
            PublishYear = publishYear;
        }

        public int Id { get; }

        public string Author { get; }

        public string Title { get; }

        public DateTime PublishYear { get; }
    }
}