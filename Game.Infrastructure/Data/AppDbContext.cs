using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.Entities;
using Microsoft.EntityFrameworkCore;
namespace Game.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Game.Core.Entities.Game> Games { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Core.Entities.Game>().HasData(
                new Core.Entities.Game { Id = 1, 
                                    Title = "Grand Theft Auto V", 
                                    Description = "Grand Theft Auto V is a 2013 action-adventure game developed by Rockstar North and published by Rockstar Games. It is the seventh main entry in the Grand Theft Auto series, following 2008's Grand Theft Auto IV",
                                    AddedOn = DateTime.Parse("11/11/2025"),
                                    ModifiedOn = DateTime.Parse("11/11/2025"),
                                    LaunchDate = DateTime.Parse("09/17/2013"),
                                    Genres= "Open world,Action-adventure,First-Person Shooter",
                                    Rating = 9,
                                    Tags = "#OpenWorld#Adventure#Shooting#RockstarGames"

                },
                new Core.Entities.Game { Id = 2, 
                            Title = "Red Dead Redemption 2", 
                            Description = "Red Dead Redemption 2 is a 2018 action-adventure game developed and published by Rockstar Games. The game is the third entry in the Red Dead series and a prequel to the 2010 game Red Dead Redemption.",
                            AddedOn = DateTime.Parse("11/11/2025"),
                            ModifiedOn = DateTime.Parse("11/11/2025"),
                            LaunchDate = DateTime.Parse("10/28/2018"),
                            Genres="Open world,Action-adventure,Western",
                            Rating = 9,
                            Tags="#OpenWorld#Adventure#Shooting"
                },
                 new Core.Entities.Game
                 {
                     Id = 3,
                     Title = "God of War",
                     Description = "God of War is a third-person action-adventure video game. It features an over-the-shoulder free camera (a departure from the previous installments which featured a fixed cinematic camera, with the exception of 2007's two-dimensional side-scroller Betrayal)",
                     AddedOn = DateTime.Parse("11/11/2025"),
                     ModifiedOn = DateTime.Parse("11/11/2025"),
                     LaunchDate = DateTime.Parse("4/20/2022"),
                     Genres = "Open world,Action-adventure, Hack and slash,Puzzle,Role-playing",
                     Rating = 10,
                     Tags = "#OpenWorld#Adventure#RolePlaying#Kartos##Loki#Norse#Mythology"
                 }
            );

            
        }

    }
}
