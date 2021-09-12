using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_webapi.Models
{
    public class BoaSessionFourSatContext :DbContext
    {
        public BoaSessionFourSatContext(DbContextOptions<BoaSessionFourSatContext> options) :base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
