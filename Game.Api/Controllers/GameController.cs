using Game.Core.Entities;
using Game.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Game.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameInterface _gameService;
        public GameController(IGameInterface gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _gameService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) => Ok(await _gameService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(Game.Infrastructure.ViewModel.Game game) => Ok(await _gameService.AddAsync(game.ToModel()));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Game.Infrastructure.ViewModel.Game game)
        {
            game.Id = id;
            await _gameService.UpdateAsync(game.ToModel());
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _gameService.DeleteAsync(id);
            return NoContent();
        }
    }
}
