using IoTMonitor.Models;

namespace IoTMonitor.Services
{
    public interface IReadingAnalysisService
    {
        ReadingAnalysisResult Analyze(Reading reading);
    }
}