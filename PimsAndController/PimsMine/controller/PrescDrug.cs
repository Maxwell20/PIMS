﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PrescDrug
    {
        public string id { get; set; }
        public string name { get; set; }
        public string ndc { get; set; }
        public int cost { get; set; }
        public DateTime dateFilled { get; set; }

    }
}
