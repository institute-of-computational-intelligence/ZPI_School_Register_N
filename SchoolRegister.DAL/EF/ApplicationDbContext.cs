using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolRegister.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static SchoolRegister.BLL.Entities.GradeScale;
using Grade = SchoolRegister.BLL.Entities.Grade;

namespace SchoolRegister.DAL.EF
{
    public class ApplicationDbContext: IdentityDbContext<User, Role, int>
    {
        private readonly ConnectionStringDto _connectionStringDto;
        public virtual DbSet<Grade> Grade { get; set; }

        public ApplicationDbContext(ConnectionStringDto connectionStringDto)
        {
            _connectionStringDto = connectionStringDto;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionStringDto.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .ToTable("AspNetUsers")
                .HasDiscriminator<int>("UserType")
                .HasValue<Student>(1)
                .HasValue<Parent>(2)
                .HasValue<Teacher>(3);

               modelBuilder.Entity<Group>()
               .HasMany(g => g.Students)
               .WithOne(s => s.Group)
               .HasForeignKey(x => x.GroupId)
               .IsRequired();
        }
    }
      

    
}
