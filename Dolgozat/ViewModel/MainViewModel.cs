using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dolgozat.Command;
using Dolgozat.View;

namespace Dolgozat.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        

        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set { currentView = value; OnPropertyChanged(); }
        }

        Task1View task1View;
        Task2View task2View;
        Task3View task3view;

        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand OpenTask1 { get; }
        public RelayCommand OpenTask2 { get; }
        public RelayCommand OpenTask3 { get; }

        public MainViewModel()
        {
            task1View = new Task1View();
            task2View = new Task2View();
            task3view = new Task3View();

            OpenTask1 = new RelayCommand(x => CurrentView = task1View);
            OpenTask2 = new RelayCommand(x => CurrentView = task2View);
            OpenTask3 = new RelayCommand(x => CurrentView = task3view);

            currentView = task1View;
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
