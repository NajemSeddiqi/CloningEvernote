using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class NewNoteBookCommand : ICommand
    {
        public INotesVM VM { get; set; }
        public event EventHandler CanExecuteChanged;

        public NewNoteBookCommand(INotesVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CreateNotebook();
        }
    }
}
