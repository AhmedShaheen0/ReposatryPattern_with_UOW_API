using ReposatryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposatryPatternWithUOW.Core.Interfaces
{
    public interface IBooksReposatries :IBaseReposatry<Book>
    {
        IEnumerable<Book>  GetBooks(); 
    }
}
