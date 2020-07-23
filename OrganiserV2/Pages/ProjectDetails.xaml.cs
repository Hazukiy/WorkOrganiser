using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using OrganiserV2.Models;

namespace OrganiserV2.Pages
{
    /// <summary>
    /// Interaction logic for ProjectDetails.xaml
    /// </summary>
    public partial class ProjectDetails : UserControl
    {
        private static ProjectInfo _projectInfo;

        public ProjectDetails()
        {
            InitializeComponent();
        }

        public ProjectDetails(ProjectInfo projectInfo)
        {
            InitializeComponent();

            _projectInfo = projectInfo;

            //Setup form properties
            projectTitle.Content = _projectInfo.Title;
            stateText.Content = $"{stateText.Content} {_projectInfo.State.ToString()}";
            dateCreatedText.Content = $"{dateCreatedText.Content} {_projectInfo.DateCreated}";

            adoLink.NavigateUri = new Uri(_projectInfo.URL);
        }

        private void adoLink_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(adoLink.NavigateUri.ToString());
        }
    }
}
