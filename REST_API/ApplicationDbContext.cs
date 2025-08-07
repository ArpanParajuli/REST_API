using Microsoft.EntityFrameworkCore;


namespace REST_API
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AuthUser>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.Property(a => a.UserName)
                .IsRequired()
                .HasMaxLength(20);


                entity.Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(30);


                entity.Property(a => a.Email)
               .IsRequired()
               .HasMaxLength(30);

                entity.Property(a => a.Role)
                .IsRequired()
                .HasMaxLength(10);



                entity.HasData(
                    // Admins
                    new AuthUser { Id = 1, Role = "Admin", Email = "admin1@example.com", Password = "Admin@123", UserName = "AdminOne" },
                    new AuthUser { Id = 2, Role = "Admin", Email = "admin2@example.com", Password = "Admin@234", UserName = "AdminTwo" },
                    new AuthUser { Id = 3, Role = "Admin", Email = "admin3@example.com", Password = "Admin@345", UserName = "AdminThree" },
                    new AuthUser { Id = 4, Role = "Admin", Email = "admin4@example.com", Password = "Admin@456", UserName = "AdminFour" },
                    new AuthUser { Id = 5, Role = "Admin", Email = "admin5@example.com", Password = "Admin@567", UserName = "AdminFive" },

                    // Users
                    new AuthUser { Id = 6, Role = "User", Email = "user1@example.com", Password = "User@123", UserName = "UserOne" },
                    new AuthUser { Id = 7, Role = "User", Email = "user2@example.com", Password = "User@234", UserName = "UserTwo" },
                    new AuthUser { Id = 8, Role = "User", Email = "user3@example.com", Password = "User@345", UserName = "UserThree" },
                    new AuthUser { Id = 9, Role = "User", Email = "user4@example.com", Password = "User@456", UserName = "UserFour" },
                    new AuthUser { Id = 10, Role = "User", Email = "user5@example.com", Password = "User@567", UserName = "UserFive" }
                );



            });


             



        modelBuilder.Entity<Book>(entity =>
            {


                entity.HasKey(b => b.Id);

                entity.Property(b => b.Name)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(b => b.Description)
               .IsRequired()
               .HasMaxLength(200);

                entity.Property(b => b.AuthorName)
             .IsRequired()
             .HasMaxLength(50);

                entity.Property(b => b.Price)
           .IsRequired()
           .HasPrecision(10,2);

          




                entity.HasData(
        new Book { Id = 1, Name = "C# Programming", Description = "A beginner's guide to C#", Price = 29.99m, AuthorName = "dalit Dev" },
        new Book { Id = 2, Name = "ASP.NET Core Web API", Description = "Learn to build APIs with ASP.NET Core", Price = 34.99m, AuthorName = "dalit Dev" },
        new Book { Id = 3, Name = "EF Core In Action", Description = "Master Entity Framework Core", Price = 32.50m, AuthorName = "Julie Lerman" },
        new Book { Id = 4, Name = "LINQ Fundamentals", Description = "Learn LINQ from basics to advanced", Price = 27.00m, AuthorName = "Joe Smith" },
        new Book { Id = 5, Name = "ASP.NET Razor Pages", Description = "Create modern websites with Razor Pages", Price = 23.49m, AuthorName = "John Taylor" },
        new Book { Id = 6, Name = "Clean Code", Description = "Write maintainable and readable code", Price = 42.95m, AuthorName = "Robert C. Martin" },
        new Book { Id = 7, Name = "Design Patterns in C#", Description = "Classic design patterns with C#", Price = 39.99m, AuthorName = "dalit Dev" },
        new Book { Id = 8, Name = "Multithreading in C#", Description = "Concurrency and parallelism in C#", Price = 35.75m, AuthorName = "Jane Doe" },
        new Book { Id = 9, Name = "Data Structures", Description = "Practical data structures for developers", Price = 31.99m, AuthorName = "Mark Allen" },
        new Book { Id = 10, Name = "Unit Testing with xUnit", Description = "Test your .NET code with xUnit", Price = 28.95m, AuthorName = "dalit Dev" },
        new Book { Id = 11, Name = "Microservices with .NET", Description = "Build scalable microservices", Price = 43.99m, AuthorName = "Sam Hill" },
        new Book { Id = 12, Name = "Web Security Essentials", Description = "Protect your apps from common threats", Price = 25.00m, AuthorName = "Lara Hughes" },
        new Book { Id = 13, Name = "Blazor in Depth", Description = "Build interactive UIs with Blazor", Price = 37.20m, AuthorName = "dalit Dev" },
        new Book { Id = 14, Name = "REST API Design", Description = "Best practices for designing RESTful APIs", Price = 30.10m, AuthorName = "Rahul Patel" },
        new Book { Id = 15, Name = "Refactoring C# Code", Description = "Improve and optimize legacy code", Price = 41.99m, AuthorName = "Alice Moore" },
        new Book { Id = 16, Name = "Git for Developers", Description = "Version control using Git and GitHub", Price = 19.99m, AuthorName = "Tom Johnson" },
        new Book { Id = 17, Name = "Dapper vs EF Core", Description = "Comparison of two data access strategies", Price = 26.95m, AuthorName = "Emily Zhang" },
        new Book { Id = 18, Name = "SignalR Real-time Apps", Description = "Real-time features with SignalR", Price = 33.00m, AuthorName = "dalit Dev" },
        new Book { Id = 19, Name = "Logging in ASP.NET", Description = "How to log and monitor .NET apps", Price = 21.99m, AuthorName = "Brian Lee" },
        new Book { Id = 20, Name = "Advanced C# Tips", Description = "Hidden gems and performance tricks", Price = 36.45m, AuthorName = "dalit Dev" }
    );


            });



           
                base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Books { get; set; }

        public DbSet<AuthUser> AuthUsers { get; set; }






    }
}
