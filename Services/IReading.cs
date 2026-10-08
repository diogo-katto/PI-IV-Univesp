using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTMonitor.DTOs;
using IoTMonitor.Models;

namespace IoTMonitor.Services
{
    public interface IReadingService
    {
        Task<Reading> CreateReadingAsync(CreateReadingRequest request);
    }
}