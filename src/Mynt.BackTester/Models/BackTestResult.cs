﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mynt.BackTester.Models
{
    internal class BackTestResult
    {
        public string Currency { get; set; }
        public decimal Profit { get; set; }
        public int Duration { get; set; }
    }
}