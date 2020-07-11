﻿using System.Data;
using System;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id=1 ,Name="value 101"},
                    new Value {Id=2 ,Name="value 102"},
                    new Value {Id=3 ,Name="value 103"}
                );
        }

        public DbSet<Value> Values { get; set; }
    }
}