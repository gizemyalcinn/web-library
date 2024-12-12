namespace library_otomation.Models
{
    public class Library
    {
        private List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public void addBook(Book book)
        { 
            Books.Add(book);
        }
                                //dönüş değeri bool yapılabilir 
        public void removeBook(string name)
        {
            Books.RemoveAll(book => book.Name == name);
        }


        public List<Book> SearchByName(string name)
        {
            return Books.FindAll(book => book.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Book> SearchByAuthor(string author)
        {
            return Books.FindAll(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase));
        }

        public List<Book> searchByYear(int year)
        {
            return Books.FindAll(book => book.Year == year);
        }

        public List<Book> ListAllBooks()
        {
            return Books;
        }
    }
}
