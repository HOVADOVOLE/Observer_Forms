﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Forms
{
    internal interface IObserver
    {
        void Update(float temperature, float humidity);
    }
}
