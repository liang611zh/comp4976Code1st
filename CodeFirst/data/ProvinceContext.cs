using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.data
{
    public class ProvinceContext:DbContext
    {
        public ProvinceContext():base("DefaultConnection") 
        {}
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}