using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public ILoginVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public LoginCommand(ILoginVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            //TODO: Login func
        }
    }
}
