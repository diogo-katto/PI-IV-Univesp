using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IoTMonitor.Models;

namespace IoTMonitor.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options)
            : base(options)
        {
            
        }
        public DbSet<Reading> Readings{get;set;} 
    }
}