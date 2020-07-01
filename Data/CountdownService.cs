

using System;
using System.Linq;
using System.Threading;

namespace Countdown.Data
{
    public class CountdownService
    {
        public Timer Timer { get; set; }
        public int Current { get; set; } = 42;
        public Action Handler { get; set; }

        public CountdownService()
        {
            this.Timer = new Timer(this.OnTimedEvent, null, 0, 1000);
        }

        public void Decrement()
        {
            this.Current--;
        }

        private void OnTimedEvent(Object source)
        {
            if (this.Handler != null) this.Handler.Invoke();
        }
    }
}
