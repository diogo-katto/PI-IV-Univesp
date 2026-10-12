using IoTMonitor.Models;

namespace IoTMonitor.DTOs
{
    public class CreateReadingResponse
    {
        public Reading Reading { get; set; } = null!;

        public ReadingAnalysisResult Analysis { get; set; } = new();
    }
}