using IoTMonitor.DTOs;
using IoTMonitor.Models;

namespace IoTMonitor.Services
{
    public interface IReadingService
    {
        Task<CreateReadingResponse> CreateReadingAsync(
            CreateReadingRequest request);

        Task<Reading?> GetLatestReadingAsync();
    }
}