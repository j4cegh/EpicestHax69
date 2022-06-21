using System;
using System.Threading;

namespace EpicestHax69
{
    /// <summary>
    /// Helps perform long and nested threading actions quickly.
    /// </summary>
    public static class ThreadingHelper
    {
        public static void DoThreaded(Action action)
        {
            new Thread(new ThreadStart(action)).Start();
        }
        
        public static void WaitFor(Action action, int timeout)
        {
            DoThreaded(() =>
            {
                Thread.Sleep(timeout);
                action();
            });
        }

        public static void WhileTrue(Action action)
        {
            DoThreaded(() =>
            {
                while (true)
                {
                    action();
                }
            });
        }
    }
}