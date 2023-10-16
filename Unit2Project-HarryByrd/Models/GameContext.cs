using Microsoft.EntityFrameworkCore;

namespace Unit2Project_HarryByrd.Models
{
    public class GameContext : DbContext
    {
        public GameContext() { }

        public GameContext(DbContextOptions<GameContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreId = "A", Name = "Action" },
                new Genre { GenreId = "C", Name = "Comedy" },
                new Genre { GenreId = "F", Name = "Fantasy" },
                new Genre { GenreId = "H", Name = "Horror" },
                new Genre { GenreId = "P", Name = "Parody" },
                new Genre { GenreId = "S", Name = "Scifi" },
                new Genre { GenreId = "T", Name = "Thriller" }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Diablo II: Lord of Destruction",
                    Year = 2000,
                    Rating = 5,
                    GenreId = "F"
                },
                new Game
                {
                    GameId = 2,
                    Name = "Elder Scrolls IV: Oblivion",
                    Year = 2006,
                    Rating = 5,
                    GenreId = "F"
                },
                new Game
                {
                    GameId = 3,
                    Name = "Payday 2",
                    Year = 2013,
                    Rating = 5,
                    GenreId = "A"
                },
                new Game
                {
                    GameId = 4,
                    Name = "Delta Force: Black Hawk Down",
                    Year = 2003,
                    Rating = 5,
                    GenreId = "A"
                }
            );
        }
    }
}
