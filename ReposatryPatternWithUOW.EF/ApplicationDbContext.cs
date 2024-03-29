﻿using Microsoft.EntityFrameworkCore;
using ReposatryPatternWithUOW.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReposatryPatternWithUOW.EF
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options)
        {
                
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book>  Books { get; set; } 
    }
}
