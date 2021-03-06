﻿using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        [Route("all")]
        public string GetAllBooks()
        {
            return "All books fetched successfully";
        }

        [Route("{bookId}/details")]
        public string GetBookDetais(int bookId)
        {
            return "Book details fetched successfully";
        }

        [Route("add")]
        public string PostBook(Book book)
        {
            return "Book added successfully";
        }

        [Route("{bookId}/update")]
        public string PutBook(int bookId, Book book)
        {
            return "Book updated successfully";
        }

        [Route("{bookId}/delete")]
        public string DeleteBook(int bookId)
        {
            return "Book deleted successfully";
        }
    }
}
