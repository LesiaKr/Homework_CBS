using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using task_3.Models;

namespace task_3.ViewModels
{
    public class StopwatchViewModel : INotifyPropertyChanged
    {
        private readonly StopwatchModel stopwatch;
        private readonly System.Timers.Timer timer;
        public ICommand StartCommand { get; }
        public ICommand StopCommand { get; }
        public ICommand ResetCommand { get; }
        public StopwatchViewModel()
        {
            stopwatch = new StopwatchModel();
            stopwatch.ElapsedTimeChanged += (sender, e) => OnPropertyChanged(nameof(ElapsedTime));
            timer = new System.Timers.Timer(100);
            timer.Elapsed += (sender, e) => OnPropertyChanged(nameof(ElapsedTime));

            StartCommand = new RelayCommand(Start); 
            StopCommand = new RelayCommand(Stop); 
            ResetCommand = new RelayCommand(Reset);
        }

        public string ElapsedTime => stopwatch.ElapsedTime.ToString(@"hh\:mm\:ss\.fff");

        public void Start()
        {
            stopwatch.Start();
            timer.Start();
        }

        public void Stop()
        {
            stopwatch.Stop();
            timer.Stop();
        }

        public void Reset()
        {
            stopwatch.Reset();
            OnPropertyChanged(nameof(ElapsedTime));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

