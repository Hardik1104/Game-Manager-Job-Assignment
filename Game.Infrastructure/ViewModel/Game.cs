using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.Entities;

namespace Game.Infrastructure.ViewModel
{
    public class Game
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Genres { get; set; }
        public required string Tags { get; set; }
        public required int Rating { get; set; }
        public DateTime LaunchDate { get; set; }
        public DateTime? AddedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }

        public static ViewModel.Game CreateFromModel(Core.Entities.Game model)
        {
            return new ViewModel.Game
            {
                Id = model.Id,
                Title = model.Title,
                Description = model.Description,
                Genres = model.Genres,
                Tags = model.Tags,
                Rating = model.Rating,
                LaunchDate = model.LaunchDate,
                AddedOn = model.AddedOn,
                ModifiedOn = model.ModifiedOn
            };
        }
        public Core.Entities.Game ToModel()
        {
            Core.Entities.Game model = new Core.Entities.Game
            {

                Id = Id,
                Title = Title,
                Description = Description,
                AddedOn = AddedOn ?? DateTime.UtcNow,
                Genres = Genres,
                Tags = Tags,
                Rating = Rating,
                LaunchDate = LaunchDate,
                ModifiedOn = ModifiedOn ?? DateTime.UtcNow,
            };
            return model;

        }
    }
}
