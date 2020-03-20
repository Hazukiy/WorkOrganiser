using Organiser.Database;
using Organiser.Models;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Organiser
{
    public partial class DetailsWindow : Form
    {
        private static ProjectEntry _localInstance;

        public EventHandler<ProjectEntry> RecordDeleted;

        public DetailsWindow()
        {
            InitializeComponent();
        }

        public DetailsWindow(ProjectEntry entry)
        {
            InitializeComponent();

            var title = $"Project {entry.Id}: {entry.Title} ({entry.State})";
            Text = title;
            groupBox1.Text = title;

            linkLabelADO.Text = entry.URL;
            linkLabelADO.Links[0].LinkData = entry.URL;

            lblCreationDate.Text = entry.DateCreated.ToString();
            lblState.Text = entry.State.ToString();
            txtBoxComments.Text = entry.Comments;

            txtBoxHost.Text = entry.Details.Host;
            txtBoxPort.Text = entry.Details.Port;
            txtBoxUsername.Text = entry.Details.Username;
            txtBoxPassword.Text = entry.Details.Password;
            txtBoxExtra.Text = entry.Details.ExtraValue;

            _localInstance = entry;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    DataAccess.Instance.DeleteRecord(_localInstance);
                    RecordDeleted?.Invoke(this, _localInstance);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        private void linkLabelADO_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var target = e.Link.LinkData as string;
            if (target != null)
            {
                Process.Start(target);
            }
        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }
    }
}
