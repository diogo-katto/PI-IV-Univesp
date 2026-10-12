namespace IoTMonitor.Models{
    public class ReadingAnalysisResult{
        public string TemperatureStatus{get;set;} = "Normal";
        public string HumidityStatus{get;set;} = "Normal";
        public List<string> Alerts{get;set;} = new();
    }
}