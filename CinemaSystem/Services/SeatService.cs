using CinemaSystem.Services.Contracts;
using CinemaSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystem.Services
{
    public class SeatService : ISeatService
    {
        private readonly CinemaDatabaseContext _cinemaDatabaseContext;


        public SeatService(CinemaDatabaseContext cinemaDatabaseContext)
        {
            _cinemaDatabaseContext = cinemaDatabaseContext;
        }

        public async Task<string?> CreateAsync(Seat seat)
        {
            _cinemaDatabaseContext.Seats.Add(seat);   
            await _cinemaDatabaseContext.SaveChangesAsync();
            return ("Created seat sucessfully");
        }
            
        public async Task<string> DeleteAsync(int id)
        {
            var entity = _cinemaDatabaseContext.Seats.FirstOrDefault(s => s.Id == id);
            if(entity != null)
            {
                _cinemaDatabaseContext.Seats.Remove(entity);
                await _cinemaDatabaseContext.SaveChangesAsync();
            }
            return ($"Sucessfully Deleted Seat {id}");        
        }

        public async Task<IEnumerable<Seat?>> GetAllAsync()
        {
            var seats = _cinemaDatabaseContext.Seats.ToList();
            return seats;
        }

        public async Task<Seat?> GetAsync(int id)
        {
            var entity =  _cinemaDatabaseContext.Seats.FirstOrDefault(s => s.Id == id);
            return entity;
        }

        public Task<string?> SaveAsync(Seat seat)
        {
            throw new NotImplementedException();
        }

        public async Task<string?> UpdateAsync(Seat seat)
        {
            _cinemaDatabaseContext.Entry(seat).State = EntityState.Modified;
            await _cinemaDatabaseContext.SaveChangesAsync();
            return ($"Seat {seat.Id} successfully updated");
        }
    }
}
