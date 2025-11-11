using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.Entities
{
    public class Game
    {
        [Key] // Marks Id as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(256)]
        public required string Title { get; set; }
        [MaxLength(2000)]
        public required string Description { get; set; }
        [MaxLength(256)]
        public required string Genres { get; set; }
        public required string Tags { get; set; }
        public required int Rating { get; set; }
        
        public DateTime LaunchDate { get; set; }

        public required DateTime AddedOn { get; set; }
        public required DateTime ModifiedOn { get; set; }
    }
}
