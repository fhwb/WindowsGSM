﻿using System;
using System.Diagnostics;

namespace WindowsGSM.Functions
{
    class ServerTable
    {
        public string ID { get; set; }
        public string PID { get; set; }
        public string Game { get; set; }
        public string Icon { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string QueryPort { get; set; }
        public string Defaultmap { get; set; }
        public string Maxplayers { get; set; }
        public string Uptime 
        { 
            get
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(PID) && int.TryParse(PID, out int pid))
                    {
                        var time = DateTime.Now - Process.GetProcessById(pid).StartTime;
                        int numberOfDay = (int)time.TotalDays;
                        return $"{numberOfDay} 天{(numberOfDay > 1 ? "s" : string.Empty)}, {time.Hours:D2}:{time.Minutes:D2}";
                    }
                }
                catch { }

                return string.Empty;
            }
        }
    }
}
