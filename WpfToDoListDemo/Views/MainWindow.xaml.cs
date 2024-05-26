using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDemoMvvm.Models;
using WpfToDoListDemo.Services;

namespace WpfDemoMvvm.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<ToDoItem> toDoItems;
        
        public MainWindow()
        {
            InitializeComponent();
            InitialToDoItems();
            this.Closing += MainWindow_Closing;
        }

        private void AddTodo_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtToDoItem.Text))
            {
                toDoItems.Add(new ToDoItem { IsChecked = false, Content = txtToDoItem.Text });
                txtToDoItem.Clear();
            }
        }

        private void RemoveToDo_Click(object sender, RoutedEventArgs e)
        {
            if(sender is FrameworkElement frameworkElement)
            {
                if(frameworkElement.DataContext is ToDoItem toDoItem)
                {
                    toDoItems.Remove(toDoItem);
                }
            }
        }

        private async void InitialToDoItems()
        {
            var jsonToDoList = await ToDoListFileService.LoadFromFileAsync();

            toDoItems = jsonToDoList != null
                ? new ObservableCollection<ToDoItem>(jsonToDoList)
                : new ObservableCollection<ToDoItem>
                {
                    new ToDoItem { IsChecked = false, Content = "Task 1" },
                    new ToDoItem { IsChecked = true, Content = "Task 2" },
                    new ToDoItem { IsChecked = false, Content = "Task 3" }
                };

            lstToDoControl.ItemsSource = toDoItems;
        }

        private async void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            await ToDoListFileService.SaveToFileAsync(this.toDoItems);
        }
    }
}