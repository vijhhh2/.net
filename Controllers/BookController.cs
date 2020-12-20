using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bookstore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }
        public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }

        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBook(id);
            return View();
        }

        public ViewResult SearchBooks(string authorName, string bookTitle)
        {
            var data = _bookRepository.SearchBooks(authorName, bookTitle);
            return View();
        }
    }
}