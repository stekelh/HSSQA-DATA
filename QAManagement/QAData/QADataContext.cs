using System;
using Microsoft.EntityFrameworkCore;

using QAData.Models;

namespace QAData
{
    public class QADataContext : DbContext
    {
        public QADataContext(DbContextOptions options) : base(options){}

#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<Patron> Patrons {get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type
    }
}
