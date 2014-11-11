using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace twentyone
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}
