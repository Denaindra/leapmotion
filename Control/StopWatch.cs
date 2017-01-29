using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMotion.Control
{
    class StopWatch
    {
        private static StopWatch Stopwatch;
        private Stopwatch stopwatch = new Stopwatch();
        public StopWatch() { 
        
        }

        public static StopWatch getinstance() {
            Stopwatch = new StopWatch();
            return Stopwatch;
        }
        public void resetStopeWatch() {
            stopwatch.Reset();
        }
        public void StartStopWatch() {
            stopwatch.Start();
        }
        public TimeSpan getcurentWaitingTime() {
        
            return stopwatch.Elapsed;
        }
    }
}
