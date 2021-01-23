using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class RegisterCommand : ICommand
    {
        public ILoginVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public RegisterCommand(ILoginVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: ...
        }
    }
}
