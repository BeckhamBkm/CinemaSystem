using CinemaSystem.Models;

namespace CinemaSystem.Services.Contracts
{
    public interface ISeatService
    {
        Task<string?> CreateAsync(Seat seat);
        Task<Seat?> GetAsync(int id);
        Task<IEnumerable<Seat?>> GetAllAsync();
        Task<string?> UpdateAsync(Seat seat);
        Task<string?> SaveAsync(Seat seat);
        Task<string> DeleteAsync(int id);
    }
}
