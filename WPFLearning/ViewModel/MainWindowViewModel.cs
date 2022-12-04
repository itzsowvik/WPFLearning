using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFLearning.ViewModel.Commands;

namespace WPFLearning.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string filepath;

        public string FilePath
        {
            get { return filepath; }
            set
            {
                filepath = value;
                OnPropertyChanged("FilePath");
            }
        }

        public FileOpenCommand  FPC { get; set; }
        public MainWindowViewModel()
        {
            FPC = new FileOpenCommand(this);
        }





        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
