using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoApp
{
    public class AdminContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseScore> CourseScores { get; set; }

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StudentInfoApp;Integrated Security=True;Connect Timeout=30;");
        }
        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity
                    .HasKey(e => e.Id)
                    .HasName("PK_StudentId");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address)
                            .IsRequired()
                            .HasMaxLength(50);

                entity.Property(e => e.Email)
                                    .IsRequired()
                                    .HasMaxLength(50);


            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_CourseID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreditHours)
                    .IsRequired();
            });


            modelBuilder.Entity<CourseScore>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_ScoreID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.StudentId)
                    .IsRequired();

                entity.Property(e => e.CourseId)
                    .IsRequired();

                entity.Property(e => e.Score)
                    .IsRequired();

                entity.HasOne(e => e.Student)
                    .WithMany()
                    .HasForeignKey(e => e.StudentId);

            });

            
        }

    }
}
