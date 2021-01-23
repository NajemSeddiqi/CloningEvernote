using EvernoteClone.Models;
using EvernoteClone.ViewModel.Commands;
using EvernoteClone.ViewModel.Helpers;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace EvernoteClone.ViewModel
{
    public interface INotesVM
    {
        void CreateNote(int notebookId);
        void CreateNotebook();
    }

    public class NotesVM : INotesVM, INotifyPropertyChanged
    {
        public ObservableCollection<Notebook> NoteBooks { get; set; }
        private Notebook selectedNoteBook;
        public Notebook SelectedNoteBook
        {
            get { return selectedNoteBook; }
            set
            {
                selectedNoteBook = value;
                OnPropertyChanged("SelectedNoteBook");
                GetNotes();
            }
        }
        public ObservableCollection<Note> Notes { get; set; }
        public NewNoteBookCommand NewNoteBookCommand { get; set; }
        public NewNoteCommand NewNoteCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public NotesVM()
        {
            NewNoteBookCommand = new NewNoteBookCommand(this);
            NewNoteCommand = new NewNoteCommand(this);

            NoteBooks = new ObservableCollection<Notebook>();
            Notes = new ObservableCollection<Note>();

            GetNoteBooks();
        }

        public void CreateNote(int id)
        {
            var newNote = new Note()
            {
                NotebookId = id,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Title = $"Note for {DateTime.Now}"
            };
            DataBaseHelper.Insert(newNote);

            GetNotes();
        }

        public void CreateNotebook()
        {
            var newNotebook = new Notebook() { Name = "Notebook" };
            DataBaseHelper.Insert(newNotebook);

            GetNoteBooks();
        }

        private void GetNoteBooks()
        {
            var noteBooks = DataBaseHelper.Read<Notebook>();

            NoteBooks.Clear();
            foreach (var n in noteBooks)
                NoteBooks.Add(n);
        }

        private void GetNotes()
        {
            if (SelectedNoteBook != null)
            {
                var notes = DataBaseHelper.Read<Note>().Where(w => w.NotebookId == selectedNoteBook.Id);

                Notes.Clear();
                foreach (var n in notes)
                    Notes.Add(n);
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
