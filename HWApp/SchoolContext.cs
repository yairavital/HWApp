﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWApp;
using HWApp.Models;

namespace HWApp
{
    public class SchoolContext : DbContext

    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-V122D4I5;DataBase=SchoollDb;Trusted_Connection = True;");
        }
    }
}
