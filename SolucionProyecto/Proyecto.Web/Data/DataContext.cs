using Microsoft.EntityFrameworkCore;
using Proyecto.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Web.Data
{
    public class DataContext:DbContext
    {
        public DbSet<User> Users { set; get; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
