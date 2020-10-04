using System;
using System.Collections.Generic;
 
using System.Linq;
using System.Threading.Tasks;
using indoV3.Models;
using Microsoft.EntityFrameworkCore;

namespace indoV3.Data
{
    public class CoreContext: DbContext
    {
        public CoreContext(DbContextOptions<CoreContext> options) : base(options)
        {
        }
        public DbSet<Leads> Leads { get; set; }

       
    }
}
