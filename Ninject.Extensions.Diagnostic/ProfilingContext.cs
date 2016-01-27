﻿using System.Collections.Generic;
using System.Diagnostics;

namespace Ninject.Extensions.Diagnostic
{
    public class ProfilingContext
    {
        public Stopwatch Timer { get; set; }
        public List<object> Data { get; set; }
    }
}
