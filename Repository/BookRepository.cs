using Bookstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Repository
{
  public class BookRepository
  {
    //    public int AddNewBook(Books model)
       // {
      //  }
    public List<Books> GetBooks()
    {
      return DataSource();
    }
    public Books GetBookById(int id)
    {
      return DataSource().Where(X => X.Id == id).FirstOrDefault();

    }
    public List<Books>SearchBook(string title,string authorName)
    {
      return DataSource().Where(x => x.Title.Contains (title) && x.Author.Contains(authorName)).ToList();
    }
    public List<Books> DataSource()
    {
      return new List<Books>()
      {
        new Books(){Id=1,Title="phyton",Author="teric", Description="This is a phython book data science realated",Category="programming",Totalpages=100,Language="English"},
        new Books(){Id=2,Title="macs",Author="longhorn",Description="This book is on trouble shooting mac books and repair",Category="guides",Totalpages=89,Language="spanish"},
        new Books(){Id=3,Title="calculas",Author="thomson",Description="This book is on college math, practice problems and solutions",Totalpages=66, Category="math",Language="swahili" },
         new Books(){Id=3,Title="Algebra",Author="thomson",Description="This book is on college math, practice problems and solutions",Totalpages=66, Category="math",Language="swahili"},
          new Books(){Id=3,Title="calculas",Author="thomson",Description="This book is on college math, practice problems and solutions",Totalpages=66, Category="math",Language="swahili"}
      };
    }
  }
}
