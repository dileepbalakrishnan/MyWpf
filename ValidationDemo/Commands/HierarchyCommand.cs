using System;
using System.Windows.Input;

namespace ValidationDemo.Commands
{
    public class HierarchyCommand : ICommand
    {
        private readonly Func<bool> _targetCanExecuteMethod;
        private readonly Action<string> _targetMethod;

        public HierarchyCommand(Action<string> targetMethod, Func<bool> targetCanExecuteMethod = null)
        {
            _targetMethod = targetMethod;
            _targetCanExecuteMethod = targetCanExecuteMethod;
        }


        public bool CanExecute(object parameter)
        {
            if (_targetCanExecuteMethod != null)
                return _targetCanExecuteMethod();
            return _targetMethod != null;
        }

        public void Execute(object parameter)
        {
            _targetMethod?.Invoke(parameter.ToString());
        }
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged = delegate { };
    }
}