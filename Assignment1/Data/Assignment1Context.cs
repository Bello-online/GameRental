using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment1.Models;

namespace Assignment1.Data
{
    public class Assignment1Context : DbContext
    {
        public Assignment1Context (DbContextOptions<Assignment1Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


        public DbSet<Assignment1.Models.Game> Game { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                       new Game
                       {
                           GameId = 1,
                           Title = "Fortnite",
                           Developer = "Epic Games",
                           Genre = "Shooting",
                           ReleaseYear = 2020,
                           PurchaseDate = new DateTime(2021, 8, 17),
                           Rating = 80
                       },
                       new Game
                       {
                           GameId = 2,
                           Title = "NBA 2K23",
                           Developer = "2K Games",
                           Genre = "Sport",
                           ReleaseYear = 2022,
                           PurchaseDate = new DateTime(2022, 3, 19),
                           Rating = 70
                       },
                       new Game
                       {
                           GameId = 3,
                           Title = "Chess",
                           Developer = "Chess.com",
                           Genre = "Strategy",
                           ReleaseYear = 2021,
                           PurchaseDate = new DateTime(2022, 12, 25),
                           Rating = 90
                       }
                   );
        }
    }
}
