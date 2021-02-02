using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Organiser.Database;
using Organiser.Models;

namespace Organiser
{
    public partial class Notes : Form
    {
        private ProjectNotes _todays;

        public Notes()
        {
            InitializeComponent();

            TodayLabel.Text = $"Today - {DateTime.Now.ToString(Constants.StandardDateTimeFormat)}";

            // Load & loop through notes and populate textbox
            var historyNotes = DataAccess.Instance.GetHistoryNotes();
            foreach (var item in historyNotes)
            {
                // NOTE: This is messy, maybe a nicer way of doing this?
                Richie.Rtf = @"{\rtf1\pc \b " + item.Created.ToString(Constants.StandardDateTimeFormat) + @":\b0 " + " ";
                Richie.AppendText($"\r\n{item.Content}\r\n");
            }

            // Load in todays notes (if any)
            _todays = DataAccess.Instance.GetTodaysNotes();
            if (_todays != null)
            {
                TodayNotes.Text = _todays.Content;
            }
        }

        private void Notes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_todays != null && _todays.Content != TodayNotes.Text)
            {
                _todays.Content = TodayNotes.Text;
                DataAccess.Instance.UpsertNote(_todays);
            }
            else if(_todays == null)
            {
                _todays = new ProjectNotes()
                {
                    Content = TodayNotes.Text,
                    Created = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat))
                };
                DataAccess.Instance.UpsertNote(_todays);
            }
            else
            {
                Trace.WriteLine($"No change, ignoring.");
            }
        }
    }
}
