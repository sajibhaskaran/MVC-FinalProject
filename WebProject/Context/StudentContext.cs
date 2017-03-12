using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebProject.Models;

namespace WebProject.Context
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Student { get; set; }
    }
}