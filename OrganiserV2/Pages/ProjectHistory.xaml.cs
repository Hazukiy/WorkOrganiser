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
using OrganiserV2.Utils;
using System.Linq;
using OrganiserV2.Models;

namespace OrganiserV2.Pages
{
    /// <summary>
    /// Interaction logic for ProjectHistory.xaml
    /// </summary>
    public partial class ProjectHistory : UserControl
    {
        private static List<ProjectInfo> _projectData;

        public ProjectHistory()
        {
            InitializeComponent();

            LoadProjects();
        }

        private void LoadProjects()
        {
            var projects = GetProjectListItems();
            if (projects != null)
            {
                oldProjectsList.ItemsSource = projects;
            }
        }

        private List<ListBoxItem> GetProjectListItems()
        {
            try
            {
                List<ListBoxItem> items = new List<ListBoxItem>();

                if (_projectData == null)
                {
                    _projectData = ProjectData.Instance.GetOldProjects();
                }

                foreach (var item in _projectData)
                {
                    items.Add(new ListBoxItem()
                    {
                        Content = item.ToString(),
                        DataContext = item
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

        private List<ListBoxItem> GetProjectsBySearch(string searchCritera)
        {
            try
            {
                List<ListBoxItem> items = new List<ListBoxItem>();

                foreach (var item in _projectData.Where(x => x.Title.ToLower().Contains(searchCritera.ToLower())))
                {
                    items.Add(new ListBoxItem()
                    {
                        Content = item.ToString(),
                        DataContext = item
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

        private void projectSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(projectSearch.Text))
            {
                LoadProjects();
                return;
            }

            var result = GetProjectsBySearch(projectSearch.Text);
            if (result != null)
            {
                oldProjectsList.ItemsSource = result;
            }
        }
    }
}
