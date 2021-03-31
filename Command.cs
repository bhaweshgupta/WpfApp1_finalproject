using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
namespace WpfApp1_finalproject
{
    class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<Object> execute;
        Predicate<Object> canexecute;

        public Command(Action<object> execute, Predicate<Object> canexecute)
        {
            this.execute = execute;
            this.canexecute = canexecute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }
    }
}
