﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EverWingForever
{
    /// <summary>
    /// This bot will just strafe from left to right, and then from right to left.
    /// Its purpose is to assist the player by allowing the player to toggle auto-strafe.
    /// </summary>
    class SweepAssistBot : AssistBot
    {
        // Default constructor just calls parent class constructor.
        public SweepAssistBot() : base() { }

        // Parameterized constructor just calls parent class constructor.
        public SweepAssistBot(double endPosition, bool leftDown) : base(endPosition, leftDown) { }
        
        protected override void RunInternal()
        {
            SweepRight(0.1, 5, 10);
            SweepLeft(0.1, 5, 10);
        }
    }
}
