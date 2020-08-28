using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog log = new EventLog("Application");
            var entries = log.Entries.Cast<EventLogEntry>()
                                     .Where(x => x.InstanceId == 4624)
                                     .Select(x => new
                                     {
                                         x.MachineName,
                                         x.Site,
                                         x.Source,
                                         x.Message
                                     }).ToList();
            foreach(var i in entries)
            {
                if(i.Source == "Application Error")
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
