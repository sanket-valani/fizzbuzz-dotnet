﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz.BusinessLogic.Interface
{
    public interface IDateTimeProvider
    {
        DayOfWeek GetCurrentDay();
    }
}
