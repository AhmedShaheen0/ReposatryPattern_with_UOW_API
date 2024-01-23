using ReposatryPatternWithUOW.Core;
using ReposatryPatternWithUOW.Core.Interfaces;
using ReposatryPatternWithUOW.Core.Models;
using ReposatryPatternWithUOW.EF.Reposatries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposatryPatternWithUOW.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseReposatry<Author> Authors { get; private set; }
        public IBooksReposatries Books { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Authors = new BaseReposatry<Author>(_context);
            Books = new BooksReposatries(_context);

        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
