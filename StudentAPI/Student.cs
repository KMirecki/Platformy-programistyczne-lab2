using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI
{
    internal class Student
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required float Average { get; set; }
        public string? Specialty { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} ,\t tName : {Name,-15}\t, Average : {Average:0.00} , Specialty : {Specialty,-3}";
        }
    }

    internal class University : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public University()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=Univ.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, Name = "Agnieszka", Average = 5.5f},
                new Student() { Id = 2, Name = "Bartosz", Average = 4.5f},
                new Student() { Id = 3, Name = "Czarek", Average = 5.0f}
                );
        }
    }
}
