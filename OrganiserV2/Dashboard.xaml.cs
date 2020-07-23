using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;
using OrganiserV2.Pages;

namespace OrganiserV2
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();

            //Set default load page 
            MainContentControl.Content = new Projects(this);
        }

        private void notesButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Notes();
        }
        private void projectsButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new Projects();
        }

        private void projectHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentControl.Content = new ProjectHistory();
        }
    }
}
