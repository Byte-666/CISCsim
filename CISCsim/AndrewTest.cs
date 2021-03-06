﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CISCsim
{
    static class AndrewTest
    {
        public static void RunTest()
        {
            // First Cycle
            CPU.completeStage.runCycle();
            CPU.executeStage.runCycle();
            CPU.issueStage.runCycle();
            CPU.dispatchStage.runCycle();
            CPU.decodeStage.runCycle();
            CPU.fetchStage.Fetch();


            // Second Cycle
            CPU.completeStage.runCycle();
            CPU.executeStage.runCycle();
            CPU.issueStage.runCycle();
            CPU.dispatchStage.runCycle();
            CPU.decodeStage.runCycle();
            CPU.fetchStage.Fetch();

            // Third Cycle
            CPU.completeStage.runCycle();
            CPU.executeStage.runCycle();
            CPU.issueStage.runCycle();
            CPU.dispatchStage.runCycle();
            CPU.decodeStage.runCycle();
            CPU.fetchStage.Fetch();

            // Fourth Cycle
            CPU.completeStage.runCycle();
            CPU.executeStage.runCycle();
            CPU.issueStage.runCycle();
            CPU.dispatchStage.runCycle();
            CPU.decodeStage.runCycle();
            CPU.fetchStage.Fetch();

            // Fifth Cycle (executes something)
            CPU.executeStage.runCycle();
            CPU.issueStage.runCycle();
            CPU.dispatchStage.runCycle();
            CPU.decodeStage.runCycle();
            CPU.fetchStage.Fetch();

        }
    }
}
