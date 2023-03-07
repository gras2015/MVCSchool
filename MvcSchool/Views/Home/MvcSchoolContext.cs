﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSchool.Views.Home
{
    public class MvcSchoolContext : DbContext
    {
        public MvcSchoolContext(DbContextOptions<MvcSchoolContext> options)
            :base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
