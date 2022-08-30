using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopApi.Models;
using yektaApi.Models;

public class ApiContext : DbContext
{
    public ApiContext(DbContextOptions<ApiContext> options)
        : base(options)
    {
    }

    public DbSet<ShopApi.Models.User> User { get; set; }

    public DbSet<yektaApi.Models.Customer> Customer { get; set; }

    public DbSet<yektaApi.Models.ProCategory> ProCategory { get; set; }

    public DbSet<yektaApi.Models.Product> Product { get; set; }
    public DbSet<yektaApi.Models.Category> categories { get; set; }





}
