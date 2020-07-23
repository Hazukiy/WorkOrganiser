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

namespace OrganiserV2
{
    /// <summary>
    /// Interaction logic for Notes.xaml
    /// </summary>
    public partial class Notes : UserControl
    {
        private static NotesInfo _todaysNotes;

        public Notes()
        {
            InitializeComponent();

            //Load in yesterdays notes
            var yesterdayResult = NotesData.Instance.GetYesterdaysNote();
            if (yesterdayResult != null)
            {
                yesterdayNoteText.Text = yesterdayResult.Content;
                yesterdayNoteTitle.Content = $"Yesterday's Notes ({yesterdayResult.Date})";
            }
            else
            {
                yesterdayNoteText.Text = $"No notes from yesterday.";
            }

            //Load in todays
            _todaysNotes = NotesData.Instance.GetTodaysNote();
            if (_todaysNotes != null)
            {
                todaysNoteText.Text = _todaysNotes.Content;
                todaysNoteTitle.Content = $"Today's Notes ({_todaysNotes.Date})";
            }
            else
            {
                todaysNoteText.Text = string.Empty;
            }
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            if (_todaysNotes != null)
            {
                _todaysNotes.Content = todaysNoteText.Text;
                NotesData.Instance.UpdateTodaysNote(_todaysNotes);
            }
            else
            {
                var newNotes = new NotesInfo()
                {
                    Date = DateTime.Parse(DateTime.Now.ToString("d")),
                    Content = todaysNoteText.Text
                };
                NotesData.Instance.UpdateTodaysNote(newNotes);
            }

            _todaysNotes = null;
        }
    }
}
