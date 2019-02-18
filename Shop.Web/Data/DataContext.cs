namespace Shop.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Shop.Web.Data.Entities;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class DataContext : DbContext
    {
        #region Properties

        public DbSet<Product> Products { get; set; }

        #endregion

        #region Constructors

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        #endregion
    }
}
