﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise12f
{
    interface ILogger
    {
        List<string> LogPosts { get;set; }

        void Log(string message);
    }
}