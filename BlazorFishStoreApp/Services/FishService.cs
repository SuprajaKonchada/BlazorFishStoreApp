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

        /// <summary>
        /// Retrieves a list of all fish from the database.
        /// </summary>
        /// <returns>A list of Fish objects.</returns>
        public async Task<List<Fish>> GetFishesAsync()
        {
            return await _context.Fish.ToListAsync();
        }

        /// <summary>
        /// Retrieves a specific fish by its ID.
        /// </summary>
        /// <param name="id">The ID of the fish to retrieve.</param>
        /// <returns>The Fish object if found; otherwise, null.</returns>
        public async Task<Fish> GetFishByIdAsync(int id)
        {
            return await _context.Fish.FindAsync(id);
        }

        /// <summary>
        /// Adds a new fish to the database.
        /// </summary>
        /// <param name="fish">The Fish object to add.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task AddFishAsync(Fish fish)
        {
            await _context.Fish.AddAsync(fish);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates an existing fish in the database.
        /// </summary>
        /// <param name="fish">The Fish object with updated data.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public async Task UpdateFishAsync(Fish fish)
        {
            _context.Fish.Update(fish);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a fish from the database by its ID.
        /// </summary>
        /// <param name="id">The ID of the fish to delete.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
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
