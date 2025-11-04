using CI_CDOpgave.Classes;

namespace CI_CDOpgave.Repository
{
    public class BookLibaryRepo
    {
        private int _nextid = 0;
        private List<BooksLibary> _books;
        public BookLibaryRepo() 
        {
            _books = new List<BooksLibary>()
            {
                new BooksLibary(_nextid++, "C# mangment", "Kurt Alten", "IT", "C# mangment", "C# mangment is for developers that need to learn C# and learn how to manage it", 2022),
                new BooksLibary(_nextid++, "Python language", "Kurt Alten", "IT", "Python language", "Python language is for developers that need to learn Python and learn how to manage it", 2022),
                new BooksLibary(_nextid++, "Java language", "Kurt Alten", "IT", "Java language", "Java language is for developers that need to learn Java and learn how to manage it", 2022),
                new BooksLibary(_nextid++, "C++ language", "Kurt Alten", "IT", "C++ language", "C++ language is for developers that need to learn C++ and learn how to manage it", 2022),
                new BooksLibary(_nextid++, "PHP language", "Kurt Alten", "IT", "PHP language", "PHP language is for developers that need to learn PHP and learn how to manage it", 2022),
            };
        }

        public List<BooksLibary> GetAll()
        {
            return _books;
        }

        public BooksLibary? Get(int id)
        {
            var book = _books.FirstOrDefault(x => x.Bookid == id);
            if (book == null)
            {
                return book;
            }
            return book;
        }

        public BooksLibary Add(BooksLibary book)
        {
            book.Bookid = _nextid++;
            _books.Add(book);
            return book;
        }

        public BooksLibary Delete(int id)
        {
            var book = _books.FirstOrDefault(x => x.Bookid == id);
            if (book != null)
            {
                _books.Remove(book);
                return book;
            }
            return book;
        }


        public BooksLibary Update( int id,BooksLibary book)
        {
            var existingBook = _books.FirstOrDefault(x => x.Bookid == id);
            if (existingBook != null)
            {
                existingBook.Bookname = book.Bookname;
                existingBook.Bookauthor = book.Bookauthor;
                existingBook.Bookgenre = book.Bookgenre;
                existingBook.Bookdescription = book.Bookdescription;
                existingBook.Bookyear = book.Bookyear;
                return existingBook;
            }
            return book;
        }

    }
}
