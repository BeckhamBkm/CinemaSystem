using CinemaSystem.Models;
using CinemaSystem.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystem.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;      
        }

        [HttpGet]
        [Route("/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<Movie>> getMoviesById(int id)
        {
            var results = await _service.GetMovieAsync(id);
            return (results == null) ? NotFound("Movie not Found") : Ok(results);
        }


        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [Route("/movies")]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {
            var results = await _service.GetAllMoviesAsync();
            return (results == null) ? NotFound("There are currently no Movies Available") : Ok(results);
        }
    }
}
