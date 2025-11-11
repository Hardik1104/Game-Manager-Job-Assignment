using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Core.Interfaces
{
    public interface IGameInterface
    {
        Task<IEnumerable<Game.Core.Entities.Game>> GetAllAsync();
        Task<Entities.Game?> GetByIdAsync(int id);
        Task<Entities.Game> AddAsync(Entities.Game game);
        Task UpdateAsync(Entities.Game game);
        Task DeleteAsync(int id);
    }
}
