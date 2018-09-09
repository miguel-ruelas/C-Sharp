using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBookFinderService" in both code and config file together.
[ServiceContract]
public interface IBookFinderService
{

    [OperationContract]
    Book[] GetBookList(String sort);

    [OperationContract]
    Book FindBook(String partialName);

    [OperationContract]
    String ToBookString(Book b);

    // TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Book
{
    //public properties author and title.
    string id;
    string author;
    string title;
    int year;

    public Book(string ID, string Title, string Author, int Year)
    {

        id = ID;
        this.author = Author;
        this.title = Title;
        this.year = Year;

    }

    [DataMember]
    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    [DataMember]
    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    [DataMember]
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    [DataMember]
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
}




