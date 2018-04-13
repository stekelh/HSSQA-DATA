using Microsoft.EntityFrameworkCore;
using QAManagment.Models;   
namespace QAManagment
{
    public class QADataContext : DbContext
    {

        public QADataContext(DbContextOptions options) : base(options){}
        
        public DbSet<Patron> Patrons{get; set;}

    }
}
