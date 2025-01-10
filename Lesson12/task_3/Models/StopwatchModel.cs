using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3.Models
{
    public class StopwatchModel
    {
        private TimeSpan elapsedTime;
        private DateTime? startTime;

        private EventHandler elapsedTimeChanged;

        public TimeSpan ElapsedTime => elapsedTime + (startTime.HasValue ? DateTime.Now - startTime.Value : TimeSpan.Zero);

        public void Start()
        {
            startTime = DateTime.Now;
            OnElapsedTimeChanged();
        }

        public void Stop()
        {
            if (startTime.HasValue)
            {
                elapsedTime += DateTime.Now - startTime.Value;
                startTime = null;
                OnElapsedTimeChanged();
            }
        }

        public void Reset()
        {
            elapsedTime = TimeSpan.Zero;
            startTime = null;
            OnElapsedTimeChanged();
        }

        public event EventHandler ElapsedTimeChanged
        {
            add
            {
                elapsedTimeChanged += value;
            }
            remove
            {
                elapsedTimeChanged -= value;
            }
        }

        protected virtual void OnElapsedTimeChanged()
        {
            elapsedTimeChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
