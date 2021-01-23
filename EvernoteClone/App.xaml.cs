using EvernoteClone.ViewModel;
using System.Windows;
using Unity;

namespace EvernoteClone
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILoginVM, LoginVM>();
            container.RegisterType<INotesVM, NotesVM>();
        }
    }
}
