﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMSController
{
    public class PatientPrescInfo
    {
        public List<PrescDrug> prescriptions;
        public PatientPrescInfo()
        {
            prescriptions = new List<PrescDrug>();
        }

    }
}
