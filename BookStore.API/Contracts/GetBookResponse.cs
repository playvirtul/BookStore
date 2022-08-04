using BookStore.Domain;
using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Contracts
{
    public class GetBookResponse
    {
        [Required]
        [MaxLength(Book.MAX_AUTHOR_LENGTH)]
        public string Author { get; set; }

        [Required]
        [MaxLength(Book.MAX_TITLE_LENGTH)]
        public string Title { get; set; }

        [Required]
        public DateTime PublishYear { get; set; }
    }
}
