using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTMonitor.DTOs;
using IoTMonitor.Services;

namespace IoTMonitor.Endpoints
{
    public static class ReadingEndpoint
    {
        public static void MapReadingEndpoint(this WebApplication app)
        {
            app.MapPost("/api/readings" , async(CreateReadingRequest request, IReadingService service) =>
            {
                var reading = await service.CreateReadingAsync(request);
                return Results.Ok(reading);
            });
             app.MapGet("/api/readings/latest", async (IReadingService service) =>
            {
                var reading = await service.GetLatestReadingAsync();
                return Results.Ok(reading);
            });
            }  
        }
}
