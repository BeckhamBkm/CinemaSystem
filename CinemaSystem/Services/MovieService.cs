using CinemaSystem.Models;
using Microsoft.EntityFrameworkCore;
using CinemaSystem.Services.Contracts;

namespace CinemaSystem.Services
{
    public class MovieService : IMoviesService
    {
        private readonly CinemaDatabaseContext _context;

        public MovieService(CinemaDatabaseContext context)
        {
            _context = context;
        }

        public async Task<string?> CreatMovieAsync(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return ("Created Movie sucessfully");
        }

        public async Task<string?> DeleteMovieAsync(int id)
        {
            var entity = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);

            if (entity != null)
            {
                _context.Movies.Remove(entity);
                await _context.SaveChangesAsync();
            }
            return ($"Sucessfully Deleted Movie {entity?.Title}");

        }

        public async Task<IEnumerable<Movie?>> GetAllMoviesAsync()
        {
            var entity = await _context.Movies.ToListAsync();
            return entity;
        }

        public async Task<Movie?> GetMovieAsync(int id)
        {
            var entity = await _context.Movies.FirstOrDefaultAsync(x => x.Id == id);
            return entity;
        }

        public Task<bool?> IsPromo(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<string?> UpdateMovieAsync(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return ($"Sucessfully updated movie {movie.Title}");
        }
    }
}
