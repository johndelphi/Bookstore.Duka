using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
  public class Books
  {
    public int Id { get; set; }
    public String Title { get; set; }
    public string Author { get; set; }
    public string  Description { get; set; }
    public string Category { get; set; }
    public string Language { get; set; }
    public int Totalpages { get; set; }

  }
}
