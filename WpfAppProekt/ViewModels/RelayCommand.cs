using System;
using System.Windows.Input;

namespace WpfAppProekt.ViewModels
{
    public sealed class RelayCommand : RelayCommandBase, ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _can;

        public RelayCommand(Action<object?> execute, Func<object?, bool>? can = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _can = can;
        }

        public bool CanExecute(object? parameter)
        {
            return _can?.Invoke(parameter) ?? true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
