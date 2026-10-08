using IoTMonitor.Data;
using IoTMonitor.Models;
using IoTMonitor.DTOs;

namespace IoTMonitor.Services
{
    public class ReadingService : IReadingService
    {
        private readonly AppDBContext _context;

        public ReadingService(AppDBContext context)
        {
            _context = context;
        }

        public async Task<Reading> CreateReadingAsync(CreateReadingRequest request)
        {
            var reading = new Reading
            {
                Temperature = request.Temperature,
                Humidity = request.Humidity,
                TimeStamp = DateTime.UtcNow
            };

            _context.Readings.Add(reading);
            await _context.SaveChangesAsync();

            return reading;
        }
    }
}