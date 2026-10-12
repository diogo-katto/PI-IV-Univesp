using IoTMonitor.Models;

namespace IoTMonitor.Services
{
    public class ReadingAnalysisService : IReadingAnalysisService
    {
        private const double MinTemperature = 10;
        private const double MaxTemperature = 30;
        private const double MinHumidity = 40;
        private const double MaxHumidity = 85;

        public ReadingAnalysisResult Analyze(Reading reading)
        {
            var result = new ReadingAnalysisResult();

            if (reading.Temperature < MinTemperature)
            {
                result.TemperatureStatus = "Low";
                result.Alerts.Add(
                    "Temperatura abaixo do limite configurado.");
            }
            else if (reading.Temperature > MaxTemperature)
            {
                result.TemperatureStatus = "High";
                result.Alerts.Add(
                    "Temperatura acima do limite configurado.");
            }

            if (reading.Humidity < MinHumidity)
            {
                result.HumidityStatus = "Low";
                result.Alerts.Add(
                    "Umidade abaixo do limite configurado.");
            }
            else if (reading.Humidity > MaxHumidity)
            {
                result.HumidityStatus = "High";
                result.Alerts.Add(
                    "Umidade acima do limite configurado.");
            }

            return result;
        }
    }
}