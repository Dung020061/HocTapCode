using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace ConsoleApp2.Models
{
    public partial class btBuoi3Context : DbContext
    {
        public btBuoi3Context()
        {
        }

        public btBuoi3Context(DbContextOptions<btBuoi3Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<EnglishCourse> EnglishCourses { get; set; }
        public virtual DbSet<MathCourse> MathCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(config.GetConnectionString("Test"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Instructor)
                    .HasMaxLength(100)
                    .HasColumnName("instructor");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<EnglishCourse>(entity =>
            {
                entity.HasKey(e => e.EnglishCoursesid);

                entity.Property(e => e.EnglishInstructor)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EnglishTopic)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.EnglishCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnglishCourses_Courses");
            });

            modelBuilder.Entity<MathCourse>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoursesId).HasColumnName("CoursesID");

                entity.Property(e => e.MathInstructor).HasMaxLength(200);

                entity.Property(e => e.MathTopic).HasMaxLength(200);

                entity.HasOne(d => d.Courses)
                    .WithMany(p => p.MathCourses)
                    .HasForeignKey(d => d.CoursesId)
                    .HasConstraintName("FK_MathCourses_Courses");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
