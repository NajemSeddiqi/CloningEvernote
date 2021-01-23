using EvernoteClone.Models;
using EvernoteClone.ViewModel.Commands;

namespace EvernoteClone.ViewModel
{
    public interface ILoginVM
    {

    }

    public class LoginVM : ILoginVM
    {
        private User user;
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public LoginCommand LoginCommand { get; set; }

        public RegisterCommand RegisterCommand { get; set; }

        public LoginVM()
        {
            RegisterCommand = new RegisterCommand(this);
            LoginCommand = new LoginCommand(this);
        }
    }
}
