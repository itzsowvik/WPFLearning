using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFLearning.View;
using WPFLearning.ViewModel.Commands;

namespace WPFLearning.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public LoginCommand LCM { get; set; }

        string _userName = "sowvik";
        string _password = "samsung";
      

       
        private string username;

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged(Username);
            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public LoginViewModel()
        {
            LCM = new LoginCommand(this);
        }

        /// <summary>
        /// Performing Login using Login Button
        /// </summary>
        public void LoginPerform()
        {
            MessageBox.Show("Button Pressed");
            if(Username == _userName && Password == _password)
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Login Failed, please check username or password");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
    
}
