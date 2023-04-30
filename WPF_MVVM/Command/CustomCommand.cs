using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_MVVM.Command
{
    public class CustomCommand : ICommand
    {
        private Action<object> _Execute;
        private Predicate<object> _CanExecute;
        private ICommand setCacheSize;
        private object p;
        private ICommand removeAFolderFromCleanup;
        private Func<object, bool> canRemoveAFolderFromCleanup;

        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object parameter)
        {
            return _CanExecute == null ? true : _CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _Execute(parameter);
        }

        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            _Execute = execute;
            _CanExecute = canExecute;
        }

      

      
    }
}
