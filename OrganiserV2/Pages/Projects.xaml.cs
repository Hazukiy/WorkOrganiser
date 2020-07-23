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
using OrganiserV2.Database;
using OrganiserV2.Models;
using OrganiserV2.Pages;
using OrganiserV2.Utils;

namespace OrganiserV2
{
    /// <summary>
    /// Interaction logic for Projects.xaml
    /// </summary>
    public partial class Projects : UserControl
    {
        private static Dashboard _dashboard;

        public Projects()
        {
            InitializeComponent();

            //Load current projects from database
            var projects = GetProjectListItems();
            if (projects != null)
            {
                currentProjectsList.ItemsSource = projects;
            }
        }

        public Projects(Dashboard dashboard)
        {
            InitializeComponent();

            //Set local reference to dashboard
            _dashboard = dashboard;

            //Load current projects from database
            var projects = GetProjectListItems();
            if (projects != null)
            {
                currentProjectsList.ItemsSource = projects;
            }
        }

        private List<ListBoxItem> GetProjectListItems()
        {
            try
            {
                List<ListBoxItem> items = new List<ListBoxItem>();
                var data = ProjectData.Instance.GetActiveProjects();

                foreach (var item in data)
                {
                    items.Add(new ListBoxItem()
                    {
                        Content = item.ToString(),
                        DataContext = item
                        //Background = GetProjectColor(item.State)
                    });
                }

                return items;
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return null;
        }

        private SolidColorBrush GetProjectColor(ProjectState state)
        {
            switch (state)
            {
                case ProjectState.Active:
                    return Brushes.LimeGreen;
                case ProjectState.Complete:
                    return Brushes.Gray;
                case ProjectState.Blocked:
                    return Brushes.Red;
                case ProjectState.Validation:
                    return Brushes.DarkBlue;
                default:
                    return Brushes.White;
            }
        }

        private void currentProjectsList_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Released)
            {
                var item = ItemsControl.ContainerFromElement(currentProjectsList, e.OriginalSource as DependencyObject) as ListBoxItem;
                if (item != null)
                {
                    //Change content view to details window and pass data context
                    _dashboard.MainContentControl.Content = new ProjectDetails((ProjectInfo)item.DataContext);
                }
            }
        }
    }
}
