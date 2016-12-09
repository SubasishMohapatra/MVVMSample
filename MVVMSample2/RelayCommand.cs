using System;
using System.Windows.Input;

namespace MVVMSample
{
    internal class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        Action<object> executeCommand;
        Func<object, bool> canExecuteCommand;

        public RelayCommand(Action<object> executeCommand, Func<object, bool> canExecuteCommand)
        {
            this.executeCommand += executeCommand;
            this.canExecuteCommand = canExecuteCommand;
        }

        public bool CanExecute(object parameter)
        {
            if (this.canExecuteCommand == null) return true;
            return this.canExecuteCommand(parameter);
        }

        public void Execute(object parameter)
        {
            this.executeCommand(parameter);
        }
    }
}