using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rana_Tanzeel.Models
{
    

        public class OrderDbContext : DbContext
        {
            public DbSet<student> students { get; set; }


            public OrderDbContext(DbContextOptions<OrderDbContext> options)
             : base(options)
            {
            }
        }
    
}
