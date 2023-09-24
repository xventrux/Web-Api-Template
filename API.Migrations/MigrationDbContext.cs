using API.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Migrations
{
    public class MigrationDbContext : BaseDbContext
    {
        public MigrationDbContext(DbContextOptions options) : base(options) { }
    }
}
