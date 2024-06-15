using BlazorFishStoreApp.Data;
using BlazorFishStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorFishStoreApp.Services
{
    public class FishService
    {
        private readonly FishContext _context;

        public FishService(FishContext context)
        {
            _context = context;
        }

        public async Task<List<Fish>> GetFishesAsync()
        {
            return await _context.Fish.ToListAsync();
        }

        public async Task<Fish> GetFishByIdAsync(int id)
        {
            return await _context.Fish.FindAsync(id);
        }

        public async Task AddFishAsync(Fish fish)
        {
            await _context.Fish.AddAsync(fish);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateFishAsync(Fish fish)
        {
            _context.Fish.Update(fish);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFishAsync(int id)
        {
            var fish = await _context.Fish.FindAsync(id);
            if (fish != null)
            {
                _context.Fish.Remove(fish);
                await _context.SaveChangesAsync();
            }
        }
    }
}
