using System;
using System.Windows.Input;

namespace HierarchyDemo.Commands
{
    public class HierarchyCommand<T> : ICommand
    {
        private readonly Func<T, bool> _targetCanExecuteMethod;
        private readonly Action<T> _targetMethod;

        public HierarchyCommand(Action<T> targetMethod, Func<T, bool> targetCanExecuteMethod = null)
        {
            _targetMethod = targetMethod;
            _targetCanExecuteMethod = targetCanExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            if (_targetCanExecuteMethod != null)
                return _targetCanExecuteMethod((T) parameter);
            return _targetMethod != null;
        }

        public void Execute(object parameter)
        {
            _targetMethod?.Invoke((T) parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}