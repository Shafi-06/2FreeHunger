using _2FreeHunger.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _2FreeHunger.EF
{
    public class NGOContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Enroll> Enrolls { get; set; }
        public DbSet<FoodCollector> FoodCollectors { get; set; }
    }
}