using Microsoft.EntityFrameworkCore;
using RichyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RichyProject.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

      public  DbSet<YourMessage> yourMessages { get; set; }
    }
}
