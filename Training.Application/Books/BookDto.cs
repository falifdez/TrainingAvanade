using Training.Core.Models;

namespace Training.Application.Books
{
    public class BookDto
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public Book GetEntity()
        {
            return new Book
            {
                ISBN = this.ISBN,
                Name = this.Name,
                Author = this.Author
            };
        }

        public static BookDto GetDtoByEntity(Book dto)
        {
            return new BookDto
            {
                ISBN = dto.ISBN,
                Name = dto.Name,
                Author = dto.Author
            };
        }
    }
}
