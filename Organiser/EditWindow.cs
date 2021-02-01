using System;
using System.Windows.Forms;
using Organiser.Models;
using Organiser.Models.Enums;
using Organiser.Extensions.Auto_Paste_Details_Plugin;
using Organiser.Database;
using System.Diagnostics;

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
            ddlEntryState.DataSource = Enum.GetValues(typeof(ProjectState));
            ddlEntryState.SelectedIndex = (int)entry.State;
            txtBoxComments.Text = entry.Comments;

            txtBoxHost.Text = entry.Details.Host;
            txtBoxPort.Text = entry.Details.Port;
            txtBoxUsername.Text = entry.Details.Username;
            txtBoxPassword.Text = entry.Details.Password;
            txtBoxExtraValues.Text = entry.Details.ExtraValue;

            ADOLink.Text = entry.URL;
            ADOLink.Links[0].LinkData = entry.URL;

            CreationDate.Text = entry.DateCreated.ToString();

            btnSave.Enabled = false;
            lblChangesPending.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _localInstance.Comments = txtBoxComments.Text;
            _localInstance.State = (ProjectState)ddlEntryState.SelectedItem;
            _localInstance.Details = new ConnectionDetails()
            {
                Host = txtBoxHost.Text,
                Port = txtBoxPort.Text,
                Username = txtBoxUsername.Text,
                Password = txtBoxPassword.Text,
                ExtraValue = txtBoxExtraValues.Text
            };

            ChangesMade?.Invoke(this, _localInstance);

            this.Close();
        }

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxComments_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxHost_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxPort_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void txtBoxExtraValues_TextChanged(object sender, EventArgs e)
        {
            ToggleChange();
        }

        private void ToggleChange()
        {
            var hasChanges = false;
            var extraValues = _localInstance.Details.ExtraValue == null ? string.Empty : _localInstance.Details.ExtraValue;

            if(txtBoxHost.Text != _localInstance.Details.Host)
            {
                hasChanges = true;
            }
            else if(txtBoxPort.Text != _localInstance.Details.Port)
            {
                hasChanges = true;
            }
            else if(txtBoxUsername.Text != _localInstance.Details.Username)
            {
                hasChanges = true;
            }
            else if(txtBoxPassword.Text != _localInstance.Details.Password)
            {
                hasChanges = true;
            }
            else if(txtBoxExtraValues.Text != extraValues)
            {
                hasChanges = true;
            }
            else if(txtBoxComments.Text != _localInstance.Comments)
            {
                hasChanges = true;
            }
            else if(ddlEntryState.SelectedIndex != (int)_localInstance.State)
            {
                hasChanges = true;
            }

            lblChangesPending.Visible = hasChanges;
            btnSave.Enabled = hasChanges;
        }

        private void btnCopyDetails_Click(object sender, EventArgs e)
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
