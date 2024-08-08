using Microsoft.EntityFrameworkCore;

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentAddress> StudentAddresses { get; set; }
    public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Course-Student relationship
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Students)
            .WithMany(s => s.Courses)
            .UsingEntity<Dictionary<string, object>>(
                "StudentCourse",
                j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId"),
                j => j.HasOne<Course>().WithMany().HasForeignKey("CourseId"));

        // Course-Teacher relationship
        modelBuilder.Entity<Course>()
            .HasOne<Teacher>(c => c.Teacher)
            .WithMany(t => t.Courses)
            .HasForeignKey(c => c.TeacherId);


        // Student-StudentAddress one-to-one relationship
        modelBuilder.Entity<Student>()
            .HasOne<StudentAddress>(s => s.Address)
            .WithOne(a => a.Student)
            .HasForeignKey<StudentAddress>(a => a.StudentId);


       // Student-Grade relationship
        modelBuilder.Entity<Student>()
            .HasOne<Grade>(s => s.Grade)
            .WithMany(g => g.Students)
            .HasForeignKey(s => s.CurrentGradeId);
    }
}
