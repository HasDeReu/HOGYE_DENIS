using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HOGYE_DENIS.Models;

namespace HOGYE_DENIS.Data
{
    public class HOGYE_DENISContext : DbContext
    {
        public HOGYE_DENISContext (DbContextOptions<HOGYE_DENISContext> options)
            : base(options)
        {
        }

        public DbSet<HOGYE_DENIS.Models.Phone> Phone { get; set; }
    }
}
