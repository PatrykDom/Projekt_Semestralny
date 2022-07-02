﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt_Semestralny.Model;

namespace Projekt_Semestralny.DataBaseContext
{
    public class Context : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AppDatabase;Trusted_Connection=True;");
        //}

        public Context(DbContextOptions<Context> options): base(options)
        {
            Database.EnsureCreated();
        }

       

        public DbSet<Lekarze> Lekarze { get; set; }
        public DbSet<Gatunki> Gatunki { get; set; }
        public DbSet<Opiekunowie> Opiekunowie { get; set; }
        public DbSet<Pacjenci> Pacjenci { get; set; }

    }
}
