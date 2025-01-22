using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    protected DataContext()
    {
    }

    public DbSet<Activity> Activities { get; set;}
}
