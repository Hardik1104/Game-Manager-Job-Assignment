using Game.Core.Interfaces;
using Game.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Game.Infrastructure.Services
{
    public class GameService : IGameInterface
    {
        private readonly AppDbContext _context;

        public GameService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Game.Core.Entities.Game>> GetAllAsync() =>
            await _context.Games.ToListAsync();

        public async Task<Core.Entities.Game?> GetByIdAsync(int id) =>
            await _context.Games.FirstOrDefaultAsync(c => c.Id == id);

        public async Task<Core.Entities.Game> AddAsync(Core.Entities.Game game)
        {
            game.AddedOn = DateTime.UtcNow;
            game.ModifiedOn = DateTime.UtcNow;
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
            return game;
        }

        public async Task UpdateAsync(Core.Entities.Game game)
        {
            game.ModifiedOn = DateTime.UtcNow;
            _context.Games.Update(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var customer = await GetByIdAsync(id);
            if (customer != null)
            {
                _context.Games.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }
    }
}
