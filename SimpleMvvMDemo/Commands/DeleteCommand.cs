using System;
using System.Windows.Input;

namespace SimpleMvvMDemo.Commands
{
    public class DeleteCommand : ICommand
    {
        private readonly Func<bool> _canExecuteCommand;
        private readonly Action _executeCommand;

        public DeleteCommand(Action executeCommand, Func<bool> canExecuteCommand)
        {
            _executeCommand = executeCommand;
            _canExecuteCommand = canExecuteCommand;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecuteCommand != null)
                return _canExecuteCommand();
            return _executeCommand != null;
        }

        public void Execute(object parameter)
        {
            _executeCommand?.Invoke();
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}