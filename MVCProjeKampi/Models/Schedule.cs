﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProjeKampi.Models
{
    public class Schedule
    {
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public bool allDay { get; set; }
    }
}