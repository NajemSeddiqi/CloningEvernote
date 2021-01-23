using EvernoteClone.Models;
using System;
using System.Windows.Input;

namespace EvernoteClone.ViewModel.Commands
{
    public class NewNoteCommand : ICommand
    {
        public INotesVM VM { get; set; }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public NewNoteCommand(INotesVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            Notebook selectedNoteBook = (Notebook)parameter;
            return selectedNoteBook != null;
        }

        public void Execute(object parameter)
        {
            Notebook selectedNotebook = (Notebook)parameter;
            VM.CreateNote(selectedNotebook.Id);
        }
    }
}
