﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Services
{
    public interface IBox
    {
        string GetId();
        int GetDayExpiration();
        double GetVolume();
        double GetScale();
    }
}
