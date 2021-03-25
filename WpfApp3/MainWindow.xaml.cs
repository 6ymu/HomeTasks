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

namespace WpfApp3
{
    public class CoachLesson
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public int Price { get; set; }

      
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var lessons = new List<CoachLesson>
            {
                new CoachLesson
                {
                    Title = "Math",
                    Date  = DateTime.Now.ToString(),
                    Price = 1000
                },
                 new CoachLesson
                {
                    Title = "English",
                    Date  = DateTime.Now.ToString(),
                    Price = 2000
                },
                  new CoachLesson
                {
                    Title = "Physics",
                    Date  = DateTime.Now.ToString(),
                    Price = 3000
                },
                   new CoachLesson
                {
                    Title = "Chemistry",
                    Date  = DateTime.Now.ToString(),
                    Price = 4000
                },

            };

            listAnimals.ItemsSource = lessons;
        }

        
    }
}
