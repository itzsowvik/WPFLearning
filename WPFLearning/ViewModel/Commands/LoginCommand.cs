using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLearning.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginViewModel LVM { get; set; }

        public LoginCommand(LoginViewModel lvm)
        {
            LVM = lvm;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            LVM.LoginPerform();
        }
    }
}
