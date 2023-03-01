using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;
using Serilog;

namespace PropertyRental
{
    public static class LogFile
    {
        public static void WriteLog()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File(@"C:\tmp\log.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            Log.Information("Information");

        }

    }
}
