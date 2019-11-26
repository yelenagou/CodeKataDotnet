using List.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace List.Data
{
   public class ListItemsDbContext : DbContext
    {
        public ListItemsDbContext(DbContextOptions<ListItemsDbContext> options) : base(options)
        {

        }
        public DbSet<ListItem>  ListItems { get; set; }
    }
}
