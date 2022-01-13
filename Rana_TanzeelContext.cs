using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rana_Tanzeel.Models;

namespace Rana_Tanzeel.Data
{
    public class Rana_TanzeelContext : DbContext
    {
        public Rana_TanzeelContext (DbContextOptions<Rana_TanzeelContext> options)
            : base(options)
        {
        }

        public DbSet<Rana_Tanzeel.Models.student> student { get; set; }
    }
}
