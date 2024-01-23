using ReposatryPatternWithUOW.Core.Interfaces;
using ReposatryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposatryPatternWithUOW.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseReposatry<Author> Authors { get; }
        IBooksReposatries Books { get; }
        int Complete();
    }
}
