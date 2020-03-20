﻿using Organiser.Models;
using Organiser.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organiser
{
    public partial class EditWindow : Form
    {
        private static ProjectEntry _localInstance;

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
            if (!lblChangesPending.Visible && !btnSave.Enabled)
            {
                if (ddlEntryState.SelectedIndex != (int)_localInstance.State) hasChanges = true;
                if (txtBoxComments.Text != _localInstance.Comments) hasChanges = true;
                if (txtBoxHost.Text != _localInstance.Details.Host) hasChanges = true;
                if (txtBoxPort.Text != _localInstance.Details.Port) hasChanges = true;
                if (txtBoxUsername.Text != _localInstance.Details.Username) hasChanges = true;
                if (txtBoxPassword.Text != _localInstance.Details.Password) hasChanges = true;
                if (txtBoxExtraValues.Text != _localInstance.Details.ExtraValue) hasChanges = true;
            }

            if(hasChanges)
            {
                lblChangesPending.Visible = true;
                btnSave.Enabled = true;
            }
        }
    }
}
