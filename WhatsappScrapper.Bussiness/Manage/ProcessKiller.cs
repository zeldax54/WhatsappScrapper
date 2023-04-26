using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappScrapper.Bussiness.Manage
{
    public interface IProcessKiller 
    {
        void KillProcessByName(string processName);
    }

    public class ProcessKiller : IProcessKiller
    {
        private readonly ILogger<ProcessKiller> _logger;
        private readonly IWebHostEnvironment _webHostEnvironmentl;
        public ProcessKiller(ILogger<ProcessKiller> logger, IWebHostEnvironment webHostEnvironmentl) 
        {
            _logger = logger;
            _webHostEnvironmentl = webHostEnvironmentl;
        }
        public void KillProcessByName(string processName)
        {
            if (_webHostEnvironmentl.IsDevelopment()) 
            {
                Process[] processes = Process.GetProcessesByName(processName);

                if (processes.Length > 0)
                {
                    foreach (var process in processes)
                    {
                        try
                        {
                            process.Kill();
                            process.WaitForExit();
                            _logger.LogInformation($"Proceso {process.ProcessName} con ID {process.Id} ha sido terminado.");
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"Error al intentar terminar el proceso {process.ProcessName}: {ex.Message}");
                        }
                    }
                }
                else
                {
                    _logger.LogInformation($"No se encontraron procesos con el nombre '{processName}'.");
                }

            }
           
        }
    }
}
