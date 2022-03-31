using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStroe.Core
{
    public interface IBookServices
    {
        List<Book> GetBooks();
        Book AddBook(Book book);
        Book GetBook(string id);
        void DeleteBook(string id);
        Book UpdateBook(Book book);
    }
}
