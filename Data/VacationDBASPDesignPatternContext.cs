using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VacationDBASPDesignPattern.Models;

namespace VacationDBASPDesignPattern.Data
{
    public class VacationDBASPDesignPatternContext : DbContext
    {
        public VacationDBASPDesignPatternContext (DbContextOptions<VacationDBASPDesignPatternContext> options)
            : base(options)
        {
        }

        public DbSet<VacationDBASPDesignPattern.Models.Department> Department { get; set; }

        public DbSet<VacationDBASPDesignPattern.Models.Employee> Employee { get; set; }

        public DbSet<VacationDBASPDesignPattern.Models.RequestDate> RequestDate { get; set; }

        public DbSet<VacationDBASPDesignPattern.Models.DaysTaken> DaysTaken { get; set; }
    }
}
