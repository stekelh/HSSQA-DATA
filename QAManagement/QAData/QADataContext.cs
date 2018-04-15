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

#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<DataSets> DataSet { get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type

#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<Video> Videos { get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type

#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<Checkouts> Checkout { get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<CheckoutHistory> CheckoutHistories { get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type

#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<QAAsset> QAAssets { get; set; }
#pragma warning restore CS0436 // Type conflicts with imported type

        public DbSet<QABranch> QABranch { get; set; }
#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<QACard> QACard { get; set; }
#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<Status> Statuses { get; set; }
#pragma warning disable CS0436 // Type conflicts with imported type
        public DbSet<Holds> Hold { get; set; }








    }
}
