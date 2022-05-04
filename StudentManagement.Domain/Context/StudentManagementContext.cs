using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain.Models;

namespace StudentManagement.Domain.Context
{
    public partial class StudentManagementContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public StudentManagementContext()
        {
        }

        public StudentManagementContext(DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=PHUC-LAPTOP\\MSSQLSERVER_2019;Initial Catalog=StudentManagement;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey("Id");
                entity.Property(e => e.Address).HasMaxLength(200);
                entity.Property(e => e.Birthday).HasColumnType("date");
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.HasOne(x => x.Class).WithMany(c => c.Students).HasForeignKey("ClassId").OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.HasKey("Id");
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.HasOne(s => s.Instructor).WithMany(i => i.Subjects).HasForeignKey("InstructorID").OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey("Id");
            });

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
