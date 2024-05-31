using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using Database.Data;
using Database.Models;
using System.IO;
using Microsoft.EntityFrameworkCore;


namespace Dolgozat.View
{
    /// <summary>
    /// Interaction logic for Task3View.xaml
    /// </summary>
    public partial class Task3View : UserControl
    {

        public ObservableCollection<People> People;
        public Context context;
        public Task3View()
        {
            InitializeComponent();
            People = new ObservableCollection<People>();
            context = new Context();
            Refresh();
            ListBox.ItemsSource = People;
            DataInput.DataContext = People;
        }

        private void Refresh()
        {
            People.Clear();

            if (context.People.Any())
                foreach (var item in context.People)
                    People.Add((People)item);
            else People.Add(new People());

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

            People user = ListBox.SelectedItem as People;
            if (user == null) user = new People();
            user.Id = 0;
            context.People.Add(user);
            context.SaveChanges();
            Refresh();
            ListBox.SelectedItem = user;
            ListBox.UpdateLayout();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            People user = ListBox.SelectedItem as People;
            if (user != null)
            {
                int index = ListBox.SelectedIndex;

                context.People.Remove(user);
                context.SaveChanges();
                Refresh();

                ListBox.SelectedIndex = index < ListBox.Items.Count - 1 ? index : ListBox.Items.Count - 1;
                ListBox.UpdateLayout();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            People user = ListBox.SelectedItem as People;
            if (user != null)
            {
                context.People.Update(user);
                context.SaveChanges();
                Refresh();
                ListBox.SelectedItem = user;
                ListBox.UpdateLayout();
            }
        }
    }
}
