
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : db tabloları ile proje classları bağlamak
    public class SubscriptionContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Subscription;Username=postgres;Password=Ppmk2520");
        }
        public DbSet<SubscriberModel> subscriberModel { get; set; }
        public DbSet<IndexCalculationModel> indexCalculation { get; set; }

    }
}
