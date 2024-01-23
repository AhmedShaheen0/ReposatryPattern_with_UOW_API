using ReposatryPatternWithUOW.Core.Interfaces;
using ReposatryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposatryPatternWithUOW.EF.Reposatries
{
    public class BooksReposatries : BaseReposatry<Book>, IBooksReposatries
    {
        private readonly ApplicationDbContext _context;

        public BooksReposatries(ApplicationDbContext context): base (context) { } // because it exist in baseReposatry

        public IEnumerable<Book> GetBooks()
        {
            throw new NotImplementedException();
        }


    }
}
