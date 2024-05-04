using CinemaSystem.Models;
using CinemaSystem.Services;
using CinemaSystem.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CinemaSystem.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class SeatController : Controller
    {
        private readonly ISeatService _service;

        public SeatController(ISeatService seatService)
        {
             _service = seatService;
        }

        /// <summary>
        /// Gets Seat by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResult</returns>

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetSeat(int id)
        {
            var seat = await _service.GetAsync(id);
            return (seat == null) ? NotFound("Seat not Found") : Ok(seat);  
        }


        /// <summary>
        /// Gets a list of all movies
        /// </summary>
        /// <returns>ActionResult</returns>
        [HttpGet("/seats")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> GetAllSeats()
        {
            var seats = await _service.GetAllAsync();
            return  (seats == null) ? NotFound("Seats not Found") : Ok(seats);
        }

        /// <summary>
        /// Creates a new Seat
        /// </summary>
        /// <param name="seat"></param>
        /// <returns>ActionResult</returns>
        [HttpPost("/create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateSeat(Seat seat)
        {        
            var result = await _service.CreateAsync(seat);
            return (result == null) ? NotFound() : Ok(result);
        }

        /// <summary>
        /// Updates a Seat's details
        /// </summary>
        /// <param name="seat"></param>
        /// <returns>ActionResult</returns>
        [HttpPut("/update")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> UpdateSeat(Seat seat)
        {
            var result = await _service.UpdateAsync(seat);
            return (result == null) ? NotFound() : Ok(result);
        }


        /// <summary>
        /// Deletes a Seat by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ActionResult</returns>
        [HttpPut("/Delete/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> RemoveSeat(int id)
        {
            var result = await _service.DeleteAsync(id);
            return (result == null)? NotFound() : Ok(result);
        }

    }
}
