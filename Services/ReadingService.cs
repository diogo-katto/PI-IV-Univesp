using IoTMonitor.Data;
using IoTMonitor.Models;
using IoTMonitor.DTOs;
using Microsoft.EntityFrameworkCore;

namespace IoTMonitor.Services
{
    public class ReadingService : IReadingService
    {
        private readonly AppDBContext _context;
        private readonly IReadingAnalysisService _analysisService;

        public ReadingService(
            AppDBContext context,
            IReadingAnalysisService analysisService)
        {
            _context = context;
            _analysisService = analysisService;
        }

        public async Task<CreateReadingResponse> CreateReadingAsync(
            CreateReadingRequest request)
        {
            var reading = new Reading
            {
                Temperature = request.Temperature,
                Humidity = request.Humidity,
                TimeStamp = DateTime.UtcNow
            };

            _context.Readings.Add(reading);
            await _context.SaveChangesAsync();

            var analysis = _analysisService.Analyze(reading);

            return new CreateReadingResponse
            {
                Reading = reading,
                Analysis = analysis
            };
        }

        public async Task<Reading?> GetLatestReadingAsync()
        {
            return await _context.Readings
                .OrderByDescending(reading => reading.TimeStamp)
                .FirstOrDefaultAsync();
        }
    }
}