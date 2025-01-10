using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_4.Models;
using task_4.Views;
using task_4.Interfaces;

namespace task_4.Presenters
{
    public class CalculatorPresenter
    {
        private readonly CalculatorModel _model;
        private readonly ICalculatorView _view;

        public CalculatorPresenter(ICalculatorView view)
        {
            _model = new CalculatorModel();
            _view = view;
            AttachViewEvents();
        }

        private void AttachViewEvents()
        {
            _view.AddEvent += (sender, args) => _view.Result = _model.Add(_view.Value1, _view.Value2);
            _view.SubtractEvent += (sender, args) => _view.Result = _model.Subtract(_view.Value1, _view.Value2);
            _view.MultiplyEvent += (sender, args) => _view.Result = _model.Multiply(_view.Value1, _view.Value2);
            _view.DivideEvent += (sender, args) => _view.Result = _model.Divide(_view.Value1, _view.Value2);
        }
    }
}
