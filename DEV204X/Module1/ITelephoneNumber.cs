﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV204X.Module1
{
    /// <summary>
    /// Telephone number using the North American Numbering Plan
    /// http://en.wikipedia.org/wiki/North_American_Numbering_Plan
    /// </summary>
    internal interface ITelephoneNumber
    {
        int CountryCode { get; }
        int AreaCode { get; }
        int Exchange { get; }
        int SubscriberNumber { get; }
    }
}
