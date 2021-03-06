﻿using System;

namespace P23.MetaTrader4.Manager.Contracts
{
    public class ReportGroupRequest
    {
        public string Name { get; set; }            // request group name
        public UInt32 From { get; set; }            // from
        public UInt32 To { get; set; }              // to

        [Obsolete]
        public int Total { get; set; }              // total logins in request group
    }
}
