﻿using ParallelProcessPractice.Core;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace AndyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskRunnerBase run = new AndyTaskRunner();
            run.ExecuteTasks(30);
        }

    }
}
