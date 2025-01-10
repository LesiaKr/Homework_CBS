using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using task_4.Interfaces;
using task_4.Presenters;

namespace task_4.Views
{
    /// <summary>
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : Window, ICalculatorView
    {
        public event EventHandler AddEvent;
        public event EventHandler SubtractEvent;
        public event EventHandler MultiplyEvent;
        public event EventHandler DivideEvent;

        public CalculatorView()
        {
            InitializeComponent();
            var presenter = new CalculatorPresenter(this);
        }

        public double Value1 => double.Parse(Value1TextBox.Text);
        public double Value2 => double.Parse(Value2TextBox.Text);
        public double Result { set => ResultTextBox.Text = value.ToString(); }

        private void AddButton_Click(object sender, RoutedEventArgs e) => AddEvent?.Invoke(this, EventArgs.Empty);
        private void SubtractButton_Click(object sender, RoutedEventArgs e) => SubtractEvent?.Invoke(this, EventArgs.Empty);
        private void MultiplyButton_Click(object sender, RoutedEventArgs e) => MultiplyEvent?.Invoke(this, EventArgs.Empty);
        private void DivideButton_Click(object sender, RoutedEventArgs e) => DivideEvent?.Invoke(this, EventArgs.Empty);
    }
}


