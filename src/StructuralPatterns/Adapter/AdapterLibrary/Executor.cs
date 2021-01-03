﻿using AdapterLibrary.BillingSystemExample;
using AdapterLibrary.MovieBroadcasterExample;
using DesignPatternsLibrary.PatternExecutors;

namespace AdapterLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Adapter - Adapter Library - Structural Pattern";

        public override void Execute()
        {
            MovieBroadcasterExecutor.Execute();
            BillingSystemExecutor.Execute();
        }
    }
}