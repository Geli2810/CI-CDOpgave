namespace CI_CDOpgave.Classes
{
    public class BooksLibary
    {
        private int _bookid;
        private string _bookname;
        private string _bookauthor;
        private string _bookgenre;
        private string _booktitle;
        private string _bookdescription;
        private int _bookyear;
        public BooksLibary(int bookid, string bookname, string bookauthor, string bookgenre, string booktitle, string bookdescription, int bookyear)
        {
            _bookid = bookid;
            _bookname = bookname;
            _bookauthor = bookauthor;
            _bookgenre = bookgenre;
            _booktitle = booktitle;
            _bookdescription = bookdescription;
            _bookyear = bookyear;
            
        }


        public BooksLibary() : this(3, "sajha", "hsaj", "hww", "qhjw", "qwjq", 1932) { }




        public int Bookid
        {
            get => _bookid;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bookid", "Bookid cannot be negative.");
                }
                _bookid = value; 
            }
        }
        public string Bookname
        {
            get => _bookname;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                { throw new ArgumentNullException("Bookname", "Bookname cannot be null or empty."); }
                _bookname = value;
            }
        }
        public string Bookauthor
        {
            get => _bookauthor;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Bookauthor", "Bookauthor cannot be null or empty.");
                }
                _bookauthor = value;
            }
        }
        public string Bookgenre { get => _bookgenre; 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("Bookgenre", "Bookgenre cannot be null or empty.");
                }
                _bookgenre = value; 
            }
        }
        public string Bookdescription
        {
            get => _bookdescription;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Bookdescription", "Bookdescription cannot be null or empty.");
                }
                _bookdescription = value;
            }
        }
        public int Bookyear
        {
            get => _bookyear;
            set
            {
                if (value < 1500 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Bookyear", "Bookyear cannot be negative.");
                }
                _bookyear = value;
            }
        }



        public override string ToString()
        {
            return $"Bookid: {_bookid}, Bookname: {_bookname}, Bookauthor: {_bookauthor}, Bookgenre: {_bookgenre}, Booktitle: {_booktitle}, Bookdescription: {_bookdescription}, Bookyear: {_bookyear}";
        }


    }
}
