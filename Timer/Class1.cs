using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimerLib
{
    /// <summary>
    /// Event arguments for event of <see cref="Timer"/>.
    /// </summary>
    public sealed class TimeIsOverEventArgs : EventArgs
    {
        public string Msg { get; set; }
    }

    /// <summary>
    /// Countdown timer.
    /// </summary>
    public sealed class Timer
    {
     

        private int time;




   

        /// <summary>
        /// Time for countdown.
        /// </summary>
        public int Time
        {
            get => time;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Time must be more than zero.");
                time = value;
            }
        }

        /// <summary>
        /// The event when time is over.
        /// </summary>
        public event EventHandler<TimeIsOverEventArgs> TimeIsOver = delegate { };

        /// <summary>
        /// Starts the time.
        /// </summary>
        /// <param name="msg"> The message to listeners. </param>
        public void Start(string msg)
        {
            Thread.Sleep(1000 * Time);
            OnTimeIsOver(new TimeIsOverEventArgs() { Msg = msg });
        }

        private void OnTimeIsOver(TimeIsOverEventArgs eventArgs)
        {
            EventHandler<TimeIsOverEventArgs> temp = TimeIsOver;
            temp?.Invoke(this, eventArgs);
        }

  
    }
}
