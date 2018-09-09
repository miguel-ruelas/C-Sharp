using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookFinderService" in code, svc and config file together.
public class BookFinderService : IBookFinderService
{
    List<Book> bookList = new List<Book>();

    public BookFinderService()
    {
        bookList.Add(new Book("1001", "Don Quixote, vol 1", "Cervantes", 1605));
        bookList.Add(new Book("1002", "Robinson Crusoe", "Daniel Defoe", 1719));
        bookList.Add(new Book("1003", "Gulliver's Travels", "Jonathan Swift", 1726));
        bookList.Add(new Book("1004", "To Kill a Mockingbird", "Harper Lee", 1960));
        bookList.Add(new Book("1005", "Emma", "Jane Austin", 1815));
        bookList.Add(new Book("1006", "The Hunger Games", "Suzanne Collins", 2008));
        bookList.Add(new Book("1007", "Twilight", "Stephenie Meyer", 2006));
        bookList.Add(new Book("1008", "Pride and Prejudice", "Jane Austin", 1813));
        bookList.Add(new Book("1009", "The Chronicles of Narnia", "C.S. Lewis", 1949));
        bookList.Add(new Book("1010", "Gone with the Wind", "Margaret Mitchell", 1936));
    }

    public Book FindBook(string partialName)
    {
        if (string.IsNullOrEmpty(partialName))
        {
            return null;
        }
        foreach (Book n in bookList)
        {
            if (n.Title.ToLower().Contains(partialName.ToLower()))
            {
                return n;
            }
        }
        return null;
    }

    public Book[] GetBookList(String sort)
    {
        if (sort.ToLower() == "i")
        {
            bookList.Sort(new BookIdComparer());
        }
        else if (sort.ToLower() == "t")
        {
            bookList.Sort(new BookTitleComparer());
        }
        else if (sort.ToLower() == "a")
        {
            bookList.Sort(new BookAuthorComparer());
        }
        else if (sort.ToLower() == "y")
        {
            bookList.Sort(new BookYearComparer());
        }

        return bookList.ToArray();
    }

    

	public Book GetDataUsingDataContract(Book composite)
	{
        /**
         * if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
         * 
         * 
         * 
         */
        return composite;
		
	}

    public string ToBookString(Book b)
    {
        if (b ==null)
        {
            return "Book not found";
        }
        String str;
        str = b.ID + ", " + b.Title + ", " + b.Author +  ", " + b.Year;
        return str;
    }

  
    private class BookIdComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    private class BookTitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

    private class BookAuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    private class BookYearComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

}
