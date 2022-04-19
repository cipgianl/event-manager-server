using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blazordata
{
    public class EventManagerDbContext: DbContext
    {
        public DbSet<DatiEvento> Eventi { get; set; }

        public EventManagerDbContext(DbContextOptions options) : base(options) { }

    }
}
