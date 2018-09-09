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
    List<string> bookList = new List<string>();

    public BookFinderService()
    {
        bookList.Add("Starting out with C++");
        bookList.Add("Starting out with Java");
        bookList.Add("Starting out with SQL");
        bookList.Add("Starting out with HTML");
        bookList.Add("Advanced C++");
        bookList.Add("Advanced Java");
        bookList.Add("Advanced SQL");
        bookList.Add("Advanced HTML");
        bookList.Add("Advanced C#");
        bookList.Add("Advanced Algebra");
    }

    public string FindBook(string partialName)
    {
        foreach (String n in bookList)
        {
            if (partialName.CompareTo(n) == 0)
            {
                return n;
            }
        }
        return null;
    }

    public string[] GetBookList()
    {
        return bookList.ToArray();
    }

    

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}
