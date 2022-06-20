using System;
using System.Threading;

namespace EpicestHax69
{
    /// <summary>
    /// Helps perform long and nested threading actions quickly.
    /// </summary>
    public static class ThreadingHelper
    {
        public static void WaitFor(Action action, int timeout)
        {
            new Thread(() =>
            {
                Thread.Sleep(timeout);
                action();
            }).Start();
        }

        public static void WhileTrue(Action action)
        {
            new Thread(() =>
            {
                while (true)
                {
                    action();
                }
            }).Start();
        }
    }
}