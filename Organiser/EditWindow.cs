using System;
using System.Windows.Forms;
using Organiser.Models;
using Organiser.Models.Enums;
using Organiser.Extensions.Auto_Paste_Details_Plugin;
using Organiser.Database;
using System.Diagnostics;
using System.Drawing;

namespace Organiser
{
    public partial class EditWindow : Form
    {
        private static ProjectEntry _localInstance;

        public EventHandler<ProjectEntry> RecordDeleted;
        public EventHandler<ProjectEntry> ChangesMade;

        public EditWindow()
        {
            InitializeComponent();
        }

        public EditWindow(ProjectEntry entry)
        {
            InitializeComponent();

            _localInstance = entry;

            groupBox1.Text = entry.Title;
            groupBox1.ForeColor = Color.White;

            Host.Text = entry.Details.Host;
            Port.Text = entry.Details.Port;
            Username.Text = entry.Details.Username;
            Password.Text = entry.Details.Password;
            Extravalue.Text = entry.Details.ExtraValue;
            Comments.Text = entry.Comments;

            ADOLink.Text = entry.URL;
            ADOLink.Links[0].LinkData = entry.URL;

            CreationDate.Text = entry.DateCreated.ToString();

            State.DataSource = Enum.GetValues(typeof(ProjectState));
            State.SelectedIndex = (int)entry.State;

            Save.Enabled = false;
            ChangesPending.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _localInstance.Comments = Comments.Text;
            _localInstance.State = (ProjectState)State.SelectedItem;
            _localInstance.Details = new ConnectionDetails()
            {
                Host = Host.Text,
                Port = Port.Text,
                Username = Username.Text,
                Password = Password.Text,
                ExtraValue = Extravalue.Text
            };

            ChangesMade?.Invoke(this, _localInstance);

            this.Close();
        }

        private void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void Comments_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void Host_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void Port_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void ExtraValues_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void ToggleChange()
        {
            var hasChanges = false;
            var extraValues = _localInstance.Details.ExtraValue == null ? string.Empty : _localInstance.Details.ExtraValue;

            if(Host.Text != _localInstance.Details.Host)
            {
                hasChanges = true;
            }
            else if(Port.Text != _localInstance.Details.Port)
            {
                hasChanges = true;
            }
            else if(Username.Text != _localInstance.Details.Username)
            {
                hasChanges = true;
            }
            else if(Password.Text != _localInstance.Details.Password)
            {
                hasChanges = true;
            }
            else if(Extravalue.Text != extraValues)
            {
                hasChanges = true;
            }
            else if(Comments.Text != _localInstance.Comments)
            {
                hasChanges = true;
            }
            else if(State.SelectedIndex != (int)_localInstance.State)
            {
                hasChanges = true;
            }

            ChangesPending.Visible = hasChanges;
            Save.Enabled = hasChanges;
        }

        private void CopyDetails_Click(object sender, EventArgs e)
        {
            var data = SerialiseLogic.Instance.ConvertToJSON(_localInstance.Details);
            Clipboard.SetText(data);
        }

        private void ADOLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var target = e.Link.LinkData as string;
            if (target != null)
            {
                Process.Start(target);
            }
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
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
    }
}
