using Microsoft.EntityFrameworkCore;
using MyWatchList.Models;

namespace MyWatchList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<WatchItem> WatchItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WatchItem>().HasData(
                new WatchItem
                {
                    Id = 1,
                    Title = "Inception",
                    Type = "Movie",
                    Description = "A mind-bending thriller",
                    IsWatched = true,
                    WatchDate = new DateTime(2020, 5, 1)
                },
                new WatchItem
                {
                    Id = 2,
                    Title = "Breaking Bad",
                    Type = "Series",
                    Description = "A chemistry teacher turns to crime",
                    IsWatched = true,
                    WatchDate = new DateTime(2021, 3, 10)
                },
                new WatchItem
                {
                    Id = 3,
                    Title = "The Matrix",
                    Type = "Movie",
                    Description = "What is real?",
                    IsWatched = false
                },
                new WatchItem
                {
                    Id = 4,
                    Title = "Stranger Things",
                    Type = "Series",
                    Description = "Sci-fi mystery",
                    IsWatched = false
                },
                new WatchItem
                {
                    Id = 5,
                    Title = "The Godfather",
                    Type = "Movie",
                    Description = "Classic mafia drama",
                    IsWatched = true,
                    WatchDate = new DateTime(2019, 9, 15)
                },
                new WatchItem
                {
                    Id = 6,
                    Title = "Interstellar",
                    Type = "Movie",
                    Description = "Space and time travel",
                    IsWatched = false
                }
            );
        }
    }
} 