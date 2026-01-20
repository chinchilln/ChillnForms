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
        public DbSet<Template> Templates { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<Page> Pages { get; set; }
    }
}
