using CinemaSystem.Models;

namespace CinemaSystem.Services.Contracts
{
    public interface IMoviesService
    {
        Task<Movie?> GetMovieAsync(int id);
        Task<IEnumerable<Movie?>> GetAllMoviesAsync();
        Task<string?> CreatMovieAsync(Movie movie);
        Task<string?> UpdateMovieAsync(Movie movie);
        Task<string?> DeleteMovieAsync(int id);
        Task<bool?> IsPromo(int id);
    }
}
