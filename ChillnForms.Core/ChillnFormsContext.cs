using ChillnForms.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChillnForms.Core
{
    public class ChillnFormsContext : DbContext
    {
        public ChillnFormsContext(DbContextOptions<ChillnFormsContext> options) : base(options)
        {
        }
        // Define DbSets for your entities here
        // public DbSet<Template> Templates { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
