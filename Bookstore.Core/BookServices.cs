using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Bookstore.Core
{
    public class BookServices : IBookServices
    {
        private readonly IMongoCollection<Book> _books;

        public BookServices(IDbClient dbClient)
        {
            _books = dbClient.GetBooksCollection();
        }
        public List<Book> GetBooks() => _books.Find(book => true).ToList();
 
    }
}

/*https://www.youtube.com/watch?v=MNepwvCcKXA 26:40*/
