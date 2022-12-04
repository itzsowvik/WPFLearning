using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLearning.ViewModel.Commands
{
    public class FileOpenCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public MainWindowViewModel MVM { get; set; }

        public FileOpenCommand(MainWindowViewModel mvm)
        {
            MVM = mvm;
        }
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            
        }
    }
}
