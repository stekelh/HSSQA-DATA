using System;
using Microsoft.EntityFrameworkCore;
using QAData.Models;
namespace QAData
{
    public class QADataContext : DbContext
    {
        public QADataContext(DbContextOptions options) : base(options){}

        public DbSet<Patron> Patrons {get; set;}
    }
}
