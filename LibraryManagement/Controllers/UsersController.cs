using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/users/{userId}")]
    public class UsersController : ControllerBase
    {
        [Route("issuebook/{bookId}")]
        public string PutIssueBook(int userId, int bookId)
        {
            return "Books issued successfully!!";
        }

        [Route("returnbook/{bookId}")]
        public string PutReturnBook(int userId, int bookId)
        {
            return "Books returned successfully!!";
        }
    }
}
