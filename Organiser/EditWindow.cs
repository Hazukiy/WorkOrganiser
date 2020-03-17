using Organiser.Models;
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
            btnSave.Enabled = false;
            lblChangesPending.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _localInstance.Comments = txtBoxComments.Text;
            _localInstance.State = (ProjectState)ddlEntryState.SelectedItem;

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

        private void ToggleChange()
        {
            if (ddlEntryState.SelectedIndex != (int)_localInstance.State)
            {
                lblChangesPending.Visible = true;
                btnSave.Enabled = true;
            }

            if (txtBoxComments.Text != _localInstance.Comments)
            {
                lblChangesPending.Visible = true;
                btnSave.Enabled = true;
            }
        }
    }
}
