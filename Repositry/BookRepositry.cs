using System;
using System.Collections.Generic;
using System.Linq;

namespace bookstore
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBook(int id)
        {
            return DataSource().Where(book => book.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBooks(string authorName, string bookTitle)
        {
            return DataSource().Where(book => book.Title.Contains(bookTitle) && book.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>() {
                new BookModel() {Id=1, Title="Mvc", Author="Vijay"},
                new BookModel() {Id=2, Title=".net", Author="Vijay"},
                new BookModel() {Id=3, Title="c#", Author="Vijay"},
                new BookModel() {Id=4, Title="java", Author="Vijay"},
                new BookModel() {Id=5, Title="Mvc", Author="Vijay"}
            };
        }
    }
}