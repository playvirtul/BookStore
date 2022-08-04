namespace BookStore.DataAccess.MSSQL.Entites
{
    public sealed class Book
    {
        public int Id { get; set; }

        public string Author { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public DateTime PublishYear { get; set; }
    }
}
