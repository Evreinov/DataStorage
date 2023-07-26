using DataStorage.Infrastructure.Commands.Base;
using System;

namespace DataStorage.Infrastructure.Commands;

internal class RelayCommand : Command
{
    private readonly Action<object> _execute;
    private readonly Func<object, bool>? _canExecute;

    public RelayCommand(Action<object> execute, Func<object, bool>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    protected override bool CanExecute(object? parameter) => parameter != null && (_canExecute?.Invoke(parameter) ?? true);

    protected override void Execute(object? parameter)
    {
        if (parameter != null) _execute(parameter);
    }
}

